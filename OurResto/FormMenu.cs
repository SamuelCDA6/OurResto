using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Transactions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace OurResto
{
    public partial class FormMenu : Form
    {
        DateTime dateMonday;
        DateTime dateFriday;
        DateTime dateAdd;

        List<cda68_bd1DataSet.v_affichermenuRow> menus = new List<cda68_bd1DataSet.v_affichermenuRow>();

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

            // 
            foreach (DataGridViewColumn c in dGVMenu.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dGVMenu.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dTPUpdateDate.Value = DateTime.Today;

            toolTip.SetToolTip(btAddRandom, "Ajouter des plats aléatoires pour toute la semaine");
            toolTip.SetToolTip(btActualiser, "Remetre l'affichage à jour");
            toolTip.SetToolTip(btModifier, "Modifier le menu actuellement sélectionné");
            toolTip.SetToolTip(btAjouter, "Ajouter un menu");
            toolTip.SetToolTip(btSupprimer, "Supprimer le menu actuellement sélectionné");
            toolTip.SetToolTip(btBefore, "Aller à la semaine précédente");
            toolTip.SetToolTip(btAfter, "Aller à la semaine suivante");
            toolTip.SetToolTip(btQuitter, "Revenir à la fenêtre principale");
            toolTip.SetToolTip(cBMoment, "Moment du repas");
            toolTip.SetToolTip(cBPlatEntree, "Nom du plat pour l'entrée");
            toolTip.SetToolTip(cBPlatPrincipal, "Nom du plat pour le plat principal");
            toolTip.SetToolTip(cBPlatAccompagnement, "Nom du plat pour l'accompagnement");
            toolTip.SetToolTip(cBPlatFromage, "Nom du plat pour le fromage");
            toolTip.SetToolTip(cBPlatDessert, "Nom du plat pour le dessert");
            toolTip.SetToolTip(dTPUpdateDate, "Date pour le repas");
            toolTip.SetToolTip(dGVMenu, "Contient la liste des menus");
        }
        #endregion

        #region Mise a jour des menus
        /// <summary>
        /// Met a jour l'affichage des menus pour la semaine
        /// </summary>
        /// <param name="date">date comprise dans la semaine à afficher</param>
        private void UpdateWeekMenus(DateTime date)
        {
            dateMonday = date.WeekDay(DayOfWeek.Monday);
            dateFriday = date.WeekDay(DayOfWeek.Friday);

            // Si le lundi est sur le mois precedent prendre le mois aussi sinon que le jour
            string monday = (dateFriday.Day < dateMonday.Day) ? dateMonday.ToString("M") : dateMonday.Day.ToString();

            // Remettre à jour le label de la semaine
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
                menus = cda68_bd1DataSet.v_affichermenu.Where(r => r.RepasDate.Date >= begin && r.RepasDate.Date <= end)
                                                          .OrderBy(r => r.RepasDate)
                                                          .ThenBy(r => r.Id_Moment).ToList();

                // Remettre à jour la DataSource de la BindingSource associé au DataGridView sur ses lignes
                vaffichermenuBindingSource.DataSource = menus;

                // Et repositionner la position de la BindingSource sur la date
                if (cda68_bd1DataSet.Moment.Count > 0)
                {
                    var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;

                    SetPositionBindingSource(dTPUpdateDate.Value.Date, idMoment);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTUPDATEFAIL);
            }
        }
        #endregion

        /// <summary>
        /// Méthode pour remettre à jour le DataSet avec le SGBD et mettre à jour l'affichage en conséquence
        /// </summary>
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
            dTPUpdateDate.Value = dTPUpdateDate.Value.AddDays(-7);
        }

        private void BtAfter_Click(object sender, EventArgs e)
        {
            dTPUpdateDate.Value = dTPUpdateDate.Value.AddDays(7);
        }

        private void BtActualiser_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        private void BtAjouter_Click(object sender, EventArgs e)
        {
            dateAdd = dTPUpdateDate.Value.Date;
            using (TransactionScope trans = new TransactionScope())
            {
                int nb = AddMenus();

                if (nb == 5)
                {
                    trans.Complete();
                }
            }

            MySqlConnection.ClearAllPools();

            RefreshDisplay();

            var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;
            SetPositionBindingSource(dateAdd, idMoment);
        }

        /// <summary>
        /// Méthode pour ajouter les menus dans le SGBD
        /// </summary>
        /// <returns>Retourne le résultat des requêtes d'ajouts</returns>
        private int AddMenus()
        {
            try
            {
                var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;
                DateTime date = dTPUpdateDate.Value;

                int nb = 0;

                // Si pas de plat à cette date ajouter les menus dans le SGBD
                if (!cda68_bd1DataSet.Menu.Any(r => r.Id_Moment == idMoment && r.RepasDate == date))
                {
                    nb += AddPlat(cBPlatEntree, idMoment, date);
                    nb += AddPlat(cBPlatPrincipal, idMoment, date);
                    nb += AddPlat(cBPlatAccompagnement, idMoment, date);
                    nb += AddPlat(cBPlatFromage, idMoment, date);
                    nb += AddPlat(cBPlatDessert, idMoment, date);
                }

                return nb;
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

            return 0;
        }

        /// <summary>
        /// Méthode pour ajouter un plat dans la SGBD
        /// </summary>
        /// <param name="cb">ComboBox lié au plat à ajouter</param>
        /// <param name="idmoment">Id du moment pour le plat à ajouter</param>
        /// <param name="daterepas">date du repas pour le plat à ajouter</param>
        /// <returns> entier retourner par l'insert du menu</returns>
        private int AddPlat(ComboBox cb, int idmoment, DateTime daterepas)
        {
            // Récupérer l'id qui correspond au plat
            var id = cda68_bd1DataSet.v_plats.First(r => r.Nom == cb.Text).Id_Plat;

            // Inserer le menu dans le SGBD et retourner le resultat
            return menuTableAdapter.Insert(id, idmoment, daterepas);
        }


        private void BtModifier_Click(object sender, EventArgs e)
        {
            UpdateMenus();

            RefreshDisplay();
        }

        private void UpdateMenus()
        {
            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    if (vaffichermenuBindingSource.Current is cda68_bd1DataSet.v_affichermenuRow currentRow)
                    {
                        cda68_bd1DataSet.Menu.Where(r => r.Id_Moment == currentRow.Id_Moment &&
                                                         r.RepasDate == currentRow.RepasDate)
                                             .ToList()
                                             .ForEach(r => r.Delete());

                        int nb = menuTableAdapter.Update(cda68_bd1DataSet.Menu.Select(null, null, DataViewRowState.Deleted));

                        var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;
                        DateTime dateRepas = dTPUpdateDate.Value;

                        if (!cda68_bd1DataSet.Menu.Any(r => r.Id_Moment == idMoment && r.RepasDate == dateRepas))
                        {
                            nb += AddPlat(cBPlatEntree, idMoment, dateRepas);
                            nb += AddPlat(cBPlatPrincipal, idMoment, dateRepas);
                            nb += AddPlat(cBPlatAccompagnement, idMoment, dateRepas);
                            nb += AddPlat(cBPlatFromage, idMoment, dateRepas);
                            nb += AddPlat(cBPlatDessert, idMoment, dateRepas);

                            if (nb == 10)
                            {
                                trans.Complete();
                            }
                        }
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
                        MessageBox.Show(Properties.Resources.TXTUPDATEMENU);
                    }

                }


            }

            MySqlConnection.ClearAllPools();
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
            DateTime date = dTPUpdateDate.Value.Date;
            // Si la date choisit n'est pas dans la semaine afficher en cours remettre à jour le DataGridView
            if (date < dateMonday || date > dateFriday)
            {
                UpdateWeekMenus(date);
            }

            if (cda68_bd1DataSet.Moment.Count > 0)
            {
                var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;

                SetPositionBindingSource(date, idMoment);
            }


        }

        /// <summary>
        /// Méthode pour placer la position de la BindingSource sur une position donnée
        /// </summary>
        /// <param name="date">la date ou placer la BindingSource</param>
        private void SetPositionBindingSource(DateTime date, int idMoment)
        {
            if (vaffichermenuBindingSource.Current != null)
            {
                // Chercher si un menu du DataGridView correspond à la date et au moment
                if (dGVMenu.Rows.OfType<DataGridViewRow>()
                                            .FirstOrDefault(r => (DateTime)r.Cells[0].Value == date &&
                                                                    (int)r.Cells[12].Value == idMoment)
                                            is DataGridViewRow row)
                {
                    // Si oui placer la BindingSource dessus
                    vaffichermenuBindingSource.Position = row.Index;
                }
                else // Si pas de menu vider les ComboBox
                {
                    cBPlatEntree.SelectedIndex = -1;
                    cBPlatPrincipal.SelectedIndex = -1;
                    cBPlatFromage.SelectedIndex = -1;
                    cBPlatAccompagnement.SelectedIndex = -1;
                    cBPlatDessert.SelectedIndex = -1;
                }
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

        private void CBMoment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;

            if (!cda68_bd1DataSet.Menu.Any(r => r.RepasDate == dTPUpdateDate.Value.Date && r.Id_Moment == idMoment))
            {
                cBPlatEntree.SelectedIndex = -1;
                cBPlatPrincipal.SelectedIndex = -1;
                cBPlatFromage.SelectedIndex = -1;
                cBPlatAccompagnement.SelectedIndex = -1;
                cBPlatDessert.SelectedIndex = -1;
            }
        }

        private void dGVMenu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dGVMenu.Columns[e.ColumnIndex];

            if (column.SortMode != DataGridViewColumnSortMode.NotSortable)
            {
                string columnName = column.DataPropertyName;

                SortOrder sortOrder = column.HeaderCell.SortGlyphDirection == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;

                menus.Sort(new MenuComparer(columnName, sortOrder));

                dGVMenu.Refresh();

                column.HeaderCell.SortGlyphDirection = sortOrder;
            }
        }

        private void BtAddRandom_Click(object sender, EventArgs e)
        {
            AddRandomWeekMeals();

            RefreshDisplay();
        }

        /// <summary>
        /// Méthode pour ajouter des menus aléatoires pour toute la semaine sans plat identique
        /// </summary>
        private void AddRandomWeekMeals()
        {
            Random random = new Random();

            // Récupere tous les plats de chaque type
            var Entrees = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 1).ToList();
            var PlatsPrincipaux = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 2).ToList();
            var Accompagnements = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 3).ToList();
            var Fromages = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 4).ToList();
            var Desserts = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 5).ToList();

            // Les stocker dans un tableau de liste de plats
            List<cda68_bd1DataSet.v_platsRow>[] PlatsLists = { Entrees, PlatsPrincipaux, Accompagnements, Fromages, Desserts };

            try
            {
                // Récupére tous les menus de la semaine en cours
                var menus = cda68_bd1DataSet.v_affichermenu.Where(r => r.RepasDate >= dateMonday && r.RepasDate <= dateFriday);

                // Si des menus sont deja remplit pour la semaine
                if (menus.Count() != 0)
                {
                    // Les supprimer des listes pour ne pas les réinsérer
                    Entrees.RemoveAll(e => menus.Select(m => m.Id_Plat_Entree).Contains(e.Id_Plat));
                    PlatsPrincipaux.RemoveAll(p => menus.Select(m => m.Id_Plat_Principal).Contains(p.Id_Plat));
                    Accompagnements.RemoveAll(a => menus.Select(m => m.Id_Plat_Accompagnement).Contains(a.Id_Plat));
                    Fromages.RemoveAll(f => menus.Select(m => m.Id_Plat_Fromage).Contains(f.Id_Plat));
                    Desserts.RemoveAll(d => menus.Select(m => m.Id_Plat_Dessert).Contains(d.Id_Plat));
                }

                using (TransactionScope trans = new TransactionScope())
                {
                    // Pour chaque jour de la semaine
                    foreach (DateTime dt in EachDay(dateMonday, dateFriday))
                    {
                        // Pour chaque moment repas
                        foreach (int moment in cda68_bd1DataSet.Moment.Select(r => r.Id_Moment))
                        {
                            // Si il n'y a pas deja de menu à cette date et ce moment
                            if (!menus.Any(m => m.Id_Moment == moment && m.RepasDate == dt))
                            {
                                // Pour chaque type de plat
                                foreach (List<cda68_bd1DataSet.v_platsRow> plats in PlatsLists)
                                {
                                    // Recuperer un plat aléatoire
                                    int i = random.Next(0, plats.Count);

                                    // Ajouter le plat dans le SGBD
                                    if (menuTableAdapter.Insert(plats[i].Id_Plat, moment, dt) != 1)
                                    {
                                        // Si le plat n'a pas été insérer quitter la méthode pour ne pas continuer
                                        // inutilement les insertions et ne pas valider la transaction
                                        MessageBox.Show(Properties.Resources.TXTADDMENU);
                                        return;
                                    }

                                    // Enlever le plat de la liste pour ne pas le réutiliser
                                    plats.RemoveAt(i);
                                }
                            }
                        }
                    }

                    // Si tous les plats on bien étés insérés, valider la transaction
                    trans.Complete();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTADDMENU);
            }
        }

        /// <summary>
        /// Méthode pour renvoyer toutes les dates comprises entre 2 dates
        /// </summary>
        /// <param name="start">date de debut</param>
        /// <param name="end">date de fin</param>
        /// <returns>Enumerable des dates comprise entre la date de debut et de fin</returns>
        private IEnumerable<DateTime> EachDay(DateTime start, DateTime end)
        {
            for (var day = start.Date; day.Date <= end.Date; day = day.AddDays(1))
            {
                yield return day;
            }
        }
    }
}
