using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OurResto
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Constructeur du formulaire FormMain
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);

            if (!TestConnexion())
            {
                btMenu.Enabled = false;
                btPlanProduction.Enabled = false;
                btQuantitePrevisionelle.Enabled = false;
                btSalarie.Enabled = false;
                MessageBox.Show(this, "Impossible de se connecter à la base de données", "Erreur de connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            toolTip.SetToolTip(btQuitter, "Quitter l'application");
            toolTip.SetToolTip(btSalarie, "Gérer les comptes repas des salariés");
            toolTip.SetToolTip(btMenu, "Gérer les menus");
            toolTip.SetToolTip(btPlanProduction, "Voir le nombre de plats à préparer");
            toolTip.SetToolTip(btQuantitePrevisionelle, "Voir la quantité d'ingrédients nécessaires pour la semaine suivante");
        }

        /// <summary>
        /// Test la connexion avec le SGBD
        /// </summary>
        /// <returns> booléen true si connexion réussi sinon false</returns>
        private static bool TestConnexion()
        {
            var mySqlConnection = new MySqlConnection(Properties.Settings.Default.cda68_bd1ConnectionString);
            
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        private void BtSalarie_Click(object sender, EventArgs e)
        {
            using (var formSalarie = new FormSalarie())
            {
                if (Properties.Settings.Default.formSalarieX != -1 && Properties.Settings.Default.formSalarieY != -1)
                {
                    formSalarie.StartPosition = FormStartPosition.Manual;
                    formSalarie.Location = new Point(Properties.Settings.Default.formSalarieX, Properties.Settings.Default.formSalarieY);
                }
                else
                {
                    formSalarie.StartPosition = FormStartPosition.CenterScreen;
                }

                Visible = false;
                formSalarie.ShowDialog();
                Visible = true;
            }
        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            using (var formMenu = new FormMenu())
            {
                if (Properties.Settings.Default.formMenuX != -1 && Properties.Settings.Default.formMenuY != -1)
                {
                    formMenu.StartPosition = FormStartPosition.Manual;
                    formMenu.Location = new Point(Properties.Settings.Default.formMenuX, Properties.Settings.Default.formMenuY);
                }
                else
                {
                    formMenu.StartPosition = FormStartPosition.CenterScreen;
                }

                Visible = false;
                formMenu.ShowDialog();
                Visible = true;
            }
        }

        private void BtQuantitePrevisionelle_Click(object sender, EventArgs e)
        {
            using (var formQuantitePrevisionnelle = new FormQuantitePrevisionnelle())
            {
                if (Properties.Settings.Default.formQtPrevX != -1 && Properties.Settings.Default.formQtPrevY != -1)
                {
                    formQuantitePrevisionnelle.StartPosition = FormStartPosition.Manual;
                    formQuantitePrevisionnelle.Location = new Point(Properties.Settings.Default.formQtPrevX, Properties.Settings.Default.formQtPrevY);
                }
                else
                {
                    formQuantitePrevisionnelle.StartPosition = FormStartPosition.CenterScreen;
                }

                Visible = false;
                formQuantitePrevisionnelle.ShowDialog();
                Visible = true;
            }
        }

        private void BtPlanProduction_Click(object sender, EventArgs e)
        {
            using (var formPlanProduction = new FormPlanProduction())
            {
                if (Properties.Settings.Default.formPlanProdX != -1 && Properties.Settings.Default.formPlanProdY != -1)
                {
                    formPlanProduction.StartPosition = FormStartPosition.Manual;
                    formPlanProduction.Location = new Point(Properties.Settings.Default.formPlanProdX, Properties.Settings.Default.formPlanProdY);
                }
                else
                {
                    formPlanProduction.StartPosition = FormStartPosition.CenterScreen;
                }

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
