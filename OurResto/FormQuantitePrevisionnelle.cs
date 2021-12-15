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
        }

        private void FormQuantitePrevisionnelle_Load(object sender, EventArgs e)
        {
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);

            v_quantiteprevisionnelleTableAdapter.Fill(cda68_bd1DataSet.v_quantiteprevisionnelle);

            //DateTime dateMonday = Convert.ToDateTime("2021/11/08");
            //DateTime dateFriday = Convert.ToDateTime("2021/11/12");

            DateTime dateMonday = DateTime.Today.AddDays(7).WeekDay(DayOfWeek.Monday).Date;
            DateTime dateFriday = DateTime.Today.AddDays(7).WeekDay(DayOfWeek.Friday).Date;

            // Si le lundi est sur le mois precedent prendre le mois aussi sinon que le jour
            string monday = (dateFriday.Day < dateMonday.Day) ? dateMonday.ToString("M") : dateMonday.Day.ToString();

            tBTitle.Text = String.Format("Quantité d'ingrédients pour la semaine du {0} au {1}", monday, dateFriday.ToString("M"));

            vquantiteprevisionnelleBindingSource.DataSource = cda68_bd1DataSet.v_quantiteprevisionnelle.Where(r => r.RepasDate >= dateMonday && r.RepasDate <= dateFriday).ToList();
        }

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
