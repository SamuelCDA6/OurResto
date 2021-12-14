using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Transactions;
using MySql.Data.MySqlClient;

namespace OurResto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Initialisation();
            RefreshDisplay();
        }

        #region Initialisation
        private void Initialisation()
        {
            Manager.ResizeImage(btAjouter, Properties.Resources.Add_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btModifier, Properties.Resources.Edit_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btSupprimer, Properties.Resources.Delete_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btActualiser, Properties.Resources.Sync_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btBefore, Properties.Resources.Arrow_left_256x256, ContentAlignment.MiddleCenter);
            Manager.ResizeImage(btAfter, Properties.Resources.Arrow_right_256x256, ContentAlignment.MiddleCenter);
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);

            foreach (ComboBox cb in Controls.OfType<ComboBox>())
            {
                cb.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            }

            dTPWeek.Value = DateTime.Today;
        }
        #endregion

        #region Mise a jour des menus
        /// <summary>
        /// Met a jour l'affichage des menus pour la semaine
        /// </summary>
        /// <param name="date">date comprise dans la semaine à afficher</param>
        private void UpdateWeekMenus(DateTime date)
        {
            DateTime dateMonday = date.WeekDay(DayOfWeek.Monday);
            DateTime dateFriday = date.WeekDay(DayOfWeek.Friday);

            // Si le lundi est sur le mois precedent prendre le mois aussi sinon que le jour
            string monday = (dateFriday.Day < dateMonday.Day) ? dateMonday.ToString("M") : dateMonday.Day.ToString();

            lblSemaine.Text = String.Format("Semaine du {0} au {1}", monday, dateFriday.ToString("M"));

            ChangeDataGridDisplayedMenus(dateMonday, dateFriday);
        }



        /// <summary>
        /// Modifie l'affichage du datagridview pour seulement les menus compris entre les date de debut et de fin
        /// </summary>
        /// <param name="begin">date de debut</param>
        /// <param name="end">date de fin</param>
        private void ChangeDataGridDisplayedMenus(DateTime begin, DateTime end)
        {
            try
            {
                // Pour la vue menu récupérer seulement les menus compris entre ces dates
                var rows = cda68_bd1DataSet.v_affichermenu.Where(r => r.RepasDate.Date >= begin && r.RepasDate.Date <= end)
                                                          .OrderBy(r => r.RepasDate)
                                                          .ThenBy(r => r.Id_Moment).ToList();

                vaffichermenuBindingSource.DataSource = rows;
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTUPDATEFAIL);
            }
        }
        #endregion

        private void RefreshDisplay()
        {
            try
            {
                momentTableAdapter.Fill(cda68_bd1DataSet.Moment);
                v_platsTableAdapter.Fill(cda68_bd1DataSet.v_plats);
                menuTableAdapter.Fill(cda68_bd1DataSet.Menu);
                v_affichermenuTableAdapter.Fill(cda68_bd1DataSet.v_affichermenu);

                SetupComboBoxs();

                UpdateWeekMenus(dTPUpdateDate.Value.Date);
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTUPDATEFAIL);
            }
        }

        /// <summary>
        /// Méthode pour mettre à jour toutes les ComboBoxs
        /// </summary>
        private void SetupComboBoxs()
        {
            SetupComboBoxPlat(cBPlatEntree, 1);
            SetupComboBoxPlat(cBPlatPrincipal, 2);
            SetupComboBoxPlat(cBPlatAccompagnement, 3);
            SetupComboBoxPlat(cBPlatFromage, 4);
            SetupComboBoxPlat(cBPlatDessert, 5);

            cBMoment.DataSource = cda68_bd1DataSet.Moment.Select(r => r.Nom).ToList();
        }

        /// <summary>
        /// Méthode pour configurer une ComboBox
        /// </summary>
        /// <param name="cb"> ComboBox à configurer</param>
        /// <param name="sorte"> Sorte de plat correspondant à la ComboBox à configurer</param>
        private void SetupComboBoxPlat(ComboBox cb, int sorte)
        {
            cb.ValueMember = "Id_Plat";
            cb.DisplayMember = "Nom";
            cb.DataSource = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == sorte).ToList();
        }

        private void DTPMain_ValueChanged(object sender, EventArgs e)
        {
            UpdateWeekMenus(dTPWeek.Value.Date);
            if (vaffichermenuBindingSource.Current != null)
            {
                vaffichermenuBindingSource.Position = dGVMenu.Rows.OfType<DataGridViewRow>().OrderBy(r => Math.Abs(((DateTime)r.Cells[0].Value - dTPWeek.Value).Days)).FirstOrDefault().Index;
            }
        }

        private void DGVMenu_SelectionChanged(object sender, EventArgs e)
        {
            UpdateComboboxs();
        }

        /// <summary>
        /// Méthode pour remettre la valeur sélectionnée des ComboBoxs à jour
        /// </summary>
        private void UpdateComboboxs()
        {
            if (vaffichermenuBindingSource.Current is cda68_bd1DataSet.v_affichermenuRow currentRow)
            {
                cBPlatEntree.SelectedValue = currentRow.Id_Plat_Entree;
                cBPlatPrincipal.SelectedValue = currentRow.Id_Plat_Principal;
                cBPlatAccompagnement.SelectedValue = currentRow.Id_Plat_Accompagnement;
                cBPlatFromage.SelectedValue = currentRow.Id_Plat_Fromage;
                cBPlatDessert.SelectedValue = currentRow.Id_Plat_Dessert;

                cBMoment.SelectedItem = currentRow.Moment;
            }
        }

        private void BtBefore_Click(object sender, EventArgs e)
        {
            dTPWeek.Value = dTPWeek.Value.AddDays(-7);
        }

        private void BtAfter_Click(object sender, EventArgs e)
        {
            dTPWeek.Value = dTPWeek.Value.AddDays(7);
        }

        private void BtActualiser_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        private void BtAjouter_Click(object sender, EventArgs e)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                AddMenus();

                trans.Complete();
            }

            MySqlConnection.ClearAllPools();

            RefreshDisplay();
        }

        /// <summary>
        /// Méthode pour ajouter les menus dans le SGBD
        /// </summary>
        private void AddMenus()
        {
            try
            {
                var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;
                DateTime dateRepas = dTPUpdateDate.Value;

                if (cda68_bd1DataSet.Menu.Where(r => r.Id_Moment == idMoment && r.RepasDate == dateRepas).Count() == 0)
                {
                    AddPlat(cBPlatEntree, idMoment, dateRepas);
                    AddPlat(cBPlatPrincipal, idMoment, dateRepas);
                    AddPlat(cBPlatAccompagnement, idMoment, dateRepas);
                    AddPlat(cBPlatFromage, idMoment, dateRepas);
                    AddPlat(cBPlatDessert, idMoment, dateRepas);
                }
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException || ex is InvalidOperationException)
                {
                    MessageBox.Show(Properties.Resources.TXTPLATINVALIDE);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.TXTADDMENU);
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter un plat dans la SGBD
        /// </summary>
        /// <param name="cb">ComboBox lié au plat à ajouter</param>
        /// <param name="idmoment">Id du moment pour le plat à ajouter</param>
        /// <param name="daterepas">date du repas pour le plat à ajouter</param>
        private void AddPlat(ComboBox cb, int idmoment, DateTime daterepas)
        {
            var id = (int)cb.SelectedValue;
            //var id = cda68_bd1DataSet.v_plats.First(r => r.Nom == cb.Text).Id_Plat;

            menuTableAdapter.Insert(id, idmoment, daterepas);
        }


        private void BtModifier_Click(object sender, EventArgs e)
        {
            using (TransactionScope trans = new TransactionScope())
            {
                DeleteMenuCurrentRow();

                AddMenus();

                trans.Complete();
            }

            MySqlConnection.ClearAllPools();

            RefreshDisplay();
        }

        private void BtSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.Resources.TXTCONFIRMATIONSUPPRMENU, "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    DeleteMenuCurrentRow();

                    trans.Complete();
                }

                MySqlConnection.ClearAllPools();

                RefreshDisplay();
            }

        }

        /// <summary>
        /// Méthode pour supprimer les menus correspondant à la ligne sélectionnée
        /// </summary>
        private void DeleteMenuCurrentRow()
        {
            try
            {
                if (vaffichermenuBindingSource.Current is cda68_bd1DataSet.v_affichermenuRow currentRow)
                {
                    // Supprimer les lignes de la data-table menu du dataset qui correspondent au jour et au moment
                    cda68_bd1DataSet.Menu.Where(r => r.Id_Moment == currentRow.Id_Moment &&
                                                     r.RepasDate == currentRow.RepasDate)
                                         .ToList()
                                         .ForEach(r => r.Delete());

                    // Mettre a jour la SGBD de ses lignes supprimées
                    menuTableAdapter.Update(cda68_bd1DataSet.Menu.Select(null, null, DataViewRowState.Deleted));
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTDELMENU);
            }
        }

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DTPUpdateDate_ValueChanged(object sender, EventArgs e)
        {
            switch (dTPUpdateDate.Value.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dTPUpdateDate.Value = dTPUpdateDate.Value.AddDays(1);
                    break;
                case DayOfWeek.Saturday:
                    dTPUpdateDate.Value = dTPUpdateDate.Value.AddDays(2);
                    break;
                default:
                    break;
            }
        }

        private void DGVMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Pour ne pas ré afficher la date si la même que celle d'au dessus
            if (e.RowIndex > 0 && e.ColumnIndex == 0)
            {
                if (dGVMenu.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.Equals(e.Value))
                {
                    e.Value = String.Empty;
                }
            }
        }
    }
}
