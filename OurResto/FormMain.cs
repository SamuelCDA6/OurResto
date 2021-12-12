using System;
using System.Drawing;
using System.Windows.Forms;

namespace OurResto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);
        }

        private void BtSalarie_Click(object sender, EventArgs e)
        {
            using (FormSalarie formSalarie = new FormSalarie())
            {
                Visible = false;
                formSalarie.ShowDialog();
                Visible = true;
            }
        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            using (FormMenu formMenu = new FormMenu())
            {
                Visible = false;
                formMenu.ShowDialog();
                Visible = true;
            }
        }

        private void BtQuantitePrevisionelle_Click(object sender, EventArgs e)
        {
            using (FormQuantitePrevisionnelle formQuantitePrevisionnelle = new FormQuantitePrevisionnelle())
            {
                Visible = false;
                formQuantitePrevisionnelle.ShowDialog();
                Visible = true;
            }
        }

        private void BtPlanProduction_Click(object sender, EventArgs e)
        {
            using (FormPlanProduction formPlanProduction = new FormPlanProduction())
            {
                Visible = false;
                formPlanProduction.ShowDialog();
                Visible = true;
            }
        }

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
