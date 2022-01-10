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
            v_quantiteprevisionnelleTableAdapter.Connection.ConnectionString = Properties.Settings.Default.FilRouge2ConnectionString;
            
            if (!v_quantiteprevisionnelleTableAdapter.Connection.Ping())
            {
                v_quantiteprevisionnelleTableAdapter.Connection.ConnectionString = Properties.Settings.Default.cda68_bd1ConnectionString;
            }
            
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);

            toolTip.SetToolTip(btQuitter, "Revenir à la fenêtre principale");

            v_quantiteprevisionnelleTableAdapter.Fill(cda68_bd1DataSet.v_quantiteprevisionnelle);

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
    }
}
