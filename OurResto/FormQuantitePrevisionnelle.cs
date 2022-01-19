using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OurResto
{
    public partial class FormQuantitePrevisionnelle : Form
    {
        public FormQuantitePrevisionnelle()
        {
            InitializeComponent();

            foreach (DataGridViewColumn c in dGVQuantitePrevisionelle.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dGVQuantitePrevisionelle.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void FormQuantitePrevisionnelle_Load(object sender, EventArgs e)
        {
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);

            toolTip.SetToolTip(btQuitter, "Revenir à la fenêtre principale");

            try
            {
                v_quantiteprevisionnelleTableAdapter.Fill(cda68_bd1DataSet.v_quantiteprevisionnelle);
            }
            catch (Exception)
            {
                MessageBox.Show(this, Properties.Resources.TXTUPDATEFAIL, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            DateTime dateMonday = DateTime.Today.AddDays(7).WeekDay(DayOfWeek.Monday, 0).Date;
            DateTime dateFriday = dateMonday.WeekDay(DayOfWeek.Friday, 0).Date;

            // Si le lundi est sur le mois précédent prendre le mois aussi sinon que le jour
            string monday = (dateFriday.Day < dateMonday.Day) ? dateMonday.ToString("M") : dateMonday.Day.ToString();

            tBTitle.Text = String.Format("Semaine du {0} au {1}", monday, dateFriday.ToString("M"));

            vquantiteprevisionnelleBindingSource.DataSource = cda68_bd1DataSet.v_quantiteprevisionnelle.Where(r => r.RepasDate >= dateMonday && r.RepasDate <= dateFriday).ToList();
        }

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormQuantitePrevisionnelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formQtPrevX = DesktopLocation.X;
            Properties.Settings.Default.formQtPrevY = DesktopLocation.Y;
        }
    }
}
