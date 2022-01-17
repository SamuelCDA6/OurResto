using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Transactions;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace OurResto
{
    public partial class FormMenu : Form
    {
        readonly cda68_bd1DataSetTableAdapters.ReservationTableAdapter reservationTableAdapter = new();
        readonly cda68_bd1DataSetTableAdapters.FormuleTableAdapter formuleTableAdapter = new();
        readonly cda68_bd1DataSetTableAdapters.v_soldesalarieTableAdapter v_SoldesalarieTableAdapter = new();

        DateTime dateMonday;
        DateTime dateFriday;
        DateTime dateLimit;

        Bitmap bitmap;

        List<cda68_bd1DataSet.v_affichermenuRow> weekMeals;

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

            foreach (ComboBox cb in tLPInputBox.Controls.OfType<ComboBox>())
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
            UpdateWeekMenus(dTPUpdateDate.Value);

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
            dateMonday = date.WeekDay(DayOfWeek.Monday, 0);
            dateFriday = date.WeekDay(DayOfWeek.Friday, 0);

            // Si le lundi est sur le mois precedent prendre le mois aussi sinon que le jour
            string monday = dateMonday.Year < dateFriday.Year ? dateMonday.ToString("D") :
                                                               (dateFriday.Day < dateMonday.Day) ? dateMonday.ToString("dddd dd MMMM") :
                                                                                                   dateMonday.ToString("dddd dd");

            // Remettre à jour le label de la semaine
            lblSemaine.Text = String.Format("Semaine du {0} au {1}", monday, dateFriday.ToString("D"));

            ChangeDataGridDisplayedMenus(dateMonday, dateFriday);
        }

        /// <summary>
        /// Modifie l'affichage du datagridview pour seulement les menus compris entre les date de debut et de fin
        /// </summary>
        /// <param name="beginDate">date de debut</param>
        /// <param name="endDate">date de fin</param>
        private void ChangeDataGridDisplayedMenus(DateTime beginDate, DateTime endDate)
        {
            try
            {
                // Pour la vue menu récupérer seulement les menus compris entre ces dates
                weekMeals = cda68_bd1DataSet.v_affichermenu.Where(r => r.RepasDate.Date >= beginDate && r.RepasDate.Date <= endDate)
                                                          .OrderBy(r => r.RepasDate)
                                                          .ThenBy(r => r.Id_Moment).ToList();

                // Remettre à jour la DataSource de la BindingSource associé au DataGridView sur ses lignes
                vaffichermenuBindingSource.DataSource = weekMeals;

                // Et repositionner la position de la BindingSource sur la date
                if (cda68_bd1DataSet.Moment.Count > 0 && cBMoment.Text != String.Empty)
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

        /// <summary>
        /// Méthode pour remettre la valeur sélectionnée des ComboBoxs à jour
        /// </summary>
        private void UpdateComboboxs()
        {
            if (vaffichermenuBindingSource.Current is cda68_bd1DataSet.v_affichermenuRow currentRow)
            {
                dTPUpdateDate.Value = currentRow.RepasDate;
                cBMoment.SelectedItem = currentRow.Moment;
                cBPlatEntree.SelectedValue = currentRow.Id_Plat_Entree;
                cBPlatPrincipal.SelectedValue = currentRow.Id_Plat_Principal;
                cBPlatAccompagnement.SelectedValue = currentRow.Id_Plat_Accompagnement;
                cBPlatFromage.SelectedValue = currentRow.Id_Plat_Fromage;
                cBPlatDessert.SelectedValue = currentRow.Id_Plat_Dessert;
            }
        }

        private void VAfficherMenuBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            UpdateComboboxs();

            bool isCurrent = vaffichermenuBindingSource.Current is cda68_bd1DataSet.v_affichermenuRow;

            SetButtons(isCurrent);
        }

        private void DGVMenu_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Delete && dGVMenu.SelectedRows.Count > 0)
            {
                DeleteMenuSelectedRows();
                RefreshDisplay();
            }
        }

        private void BtBefore_Click(object sender, EventArgs e)
        {
            dTPUpdateDate.Value = dTPUpdateDate.Value.AddDays(-7);
            UpdateWeekMenus(dTPUpdateDate.Value);
        }

        private void BtAfter_Click(object sender, EventArgs e)
        {
            dTPUpdateDate.Value = dTPUpdateDate.Value.AddDays(7);
            UpdateWeekMenus(dTPUpdateDate.Value);
        }

        private void BtActualiser_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        private void CBMoment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;

            SetPositionBindingSource(dTPUpdateDate.Value, idMoment);
        }

        private void DTPUpdateDate_CloseUp(object sender, EventArgs e)
        {
            if (dTPUpdateDate.Value.DayOfWeek == DayOfWeek.Sunday) dTPUpdateDate.Value = dTPUpdateDate.Value.Date.AddDays(-2);
            else if (dTPUpdateDate.Value.DayOfWeek == DayOfWeek.Saturday) dTPUpdateDate.Value = dTPUpdateDate.Value.Date.AddDays(-1);

            DateTime date = dTPUpdateDate.Value.Date;

            // Si la date choisit n'est pas dans la semaine affichée en cours remettre à jour le DataGridView
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
            //Chercher si un menu du DataGridView correspond à la date et au moment
            if (dGVMenu.Rows.Cast<DataGridViewRow>()
                            .FirstOrDefault(r => (DateTime)r.Cells[0].Value == date &&
                                                 (int)r.Cells[12].Value == idMoment)
                            is DataGridViewRow row)
            {
                //Si oui placer la BindingSource dessus
                vaffichermenuBindingSource.Position = row.Index;
                // Mettre à jour les boutons en conséquence
                SetButtons(true);
            }
            else
            {
                // Si pas de menu enlever la ou les lignes sélectionnées du DataGridView 
                dGVMenu.ClearSelection();

                // Mettre
                SetButtons(false);
            }
        }

        /// <summary>
        /// Méthode pour mettre à jour l'activation des boutons
        /// </summary>
        /// <param name="isPositionValid"> booléen qui précise si cela correspond à une date et un moment déjà dans le SGBD</param>
        private void SetButtons(bool isPositionValid)
        {
            btAjouter.Enabled = !isPositionValid;

            DateTime dateMonday8h = DateTime.Now.WeekDay(DayOfWeek.Monday, 8);
            dateLimit = DateTime.Now < dateMonday8h ? dateMonday8h.AddDays(7).Date : dateMonday8h.AddDays(14).Date;

            bool isUpdatable = isPositionValid && dTPUpdateDate.Value.Date >= dateLimit;
            btSupprimer.Enabled = isUpdatable;
            btModifier.Enabled = isUpdatable;
            btAddRandom.Enabled = dTPUpdateDate.Value.Date >= dateLimit && dGVMenu.Rows.Count < 10;
        }

        private void BtAjouter_Click(object sender, EventArgs e)
        {
            var dateAdd = dTPUpdateDate.Value.Date;
            var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;

            using (var trans = new TransactionScope())
            {
                int nb = AddMeals();

                if (nb == 5)
                {
                    trans.Complete();
                }
            }

            MySqlConnection.ClearAllPools();

            RefreshDisplay();

            SetPositionBindingSource(dateAdd, idMoment);
        }

        /// <summary>
        /// Méthode pour ajouter les menus dans le SGBD
        /// </summary>
        /// <returns>Retourne le résultat des requêtes d'ajouts</returns>
        private int AddMeals()
        {
            try
            {
                var idMoment = cda68_bd1DataSet.Moment.First(r => r.Nom == cBMoment.Text).Id_Moment;
                DateTime date = dTPUpdateDate.Value;

                int nb = 0;

                // Si pas de plat à cette date ajouter les menus dans le SGBD
                if (!cda68_bd1DataSet.Menu.Any(r => r.Id_Moment == idMoment && r.RepasDate == date))
                {
                    nb += AddOneMeal(cBPlatEntree, idMoment, date);
                    nb += AddOneMeal(cBPlatPrincipal, idMoment, date);
                    nb += AddOneMeal(cBPlatAccompagnement, idMoment, date);
                    nb += AddOneMeal(cBPlatFromage, idMoment, date);
                    nb += AddOneMeal(cBPlatDessert, idMoment, date);
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
        /// <param name="idMoment">Id du moment pour le plat à ajouter</param>
        /// <param name="dateRepas">date du repas pour le plat à ajouter</param>
        /// <returns> entier retourner par l'insert du menu</returns>
        private int AddOneMeal(ComboBox cb, int idMoment, DateTime dateRepas)
        {
            // Récupérer l'id qui correspond au plat
            var id = cda68_bd1DataSet.v_plats.First(r => r.Nom == cb.Text).Id_Plat;

            // Insérer le menu dans le SGBD et retourner le résultat
            return menuTableAdapter.Insert(id, idMoment, dateRepas);
        }

        private void BtModifier_Click(object sender, EventArgs e)
        {
            UpdateMeals();

            RefreshDisplay();
        }

        private void UpdateMeals()
        {
            using (var trans = new TransactionScope())
            {
                if (vaffichermenuBindingSource.Current is cda68_bd1DataSet.v_affichermenuRow currentRow)
                {
                    try
                    {
                        int nb = UpdateOneMeal(currentRow, cBPlatEntree, currentRow.Id_Plat_Entree);
                        nb += UpdateOneMeal(currentRow, cBPlatPrincipal, currentRow.Id_Plat_Principal);
                        nb += UpdateOneMeal(currentRow, cBPlatAccompagnement, currentRow.Id_Plat_Accompagnement);
                        nb += UpdateOneMeal(currentRow, cBPlatFromage, currentRow.Id_Plat_Fromage);
                        nb += UpdateOneMeal(currentRow, cBPlatDessert, currentRow.Id_Plat_Dessert);


                        if (nb == 5)
                        {
                            trans.Complete();
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
                            MessageBox.Show(String.Format(Properties.Resources.TXTUPDATEMENU, currentRow.Moment, currentRow.RepasDate.ToString("D")));
                        }
                    }
                }
            }

            MySqlConnection.ClearAllPools();
        }

        /// <summary>
        /// Méthode pour mettre à jour un plat
        /// </summary>
        /// <param name="row">La ligne qui contient les données a mettre à jour</param>
        /// <param name="cb">La combobox qui à le nouveau nom du plat </param>
        /// <returns>Un entier qui est à 0 si l'update à échoué ou 1 si il à reussit</returns>
        private int UpdateOneMeal(cda68_bd1DataSet.v_affichermenuRow row, ComboBox cb, int id_Plat)
        {
            int id = cda68_bd1DataSet.v_plats.First(r => r.Nom == cb.Text).Id_Plat;
            return menuTableAdapter.Update(id, row.Id_Moment, row.RepasDate, id_Plat, row.Id_Moment, row.RepasDate);
        }

        private void BtSupprimer_Click(object sender, EventArgs e)
        {
            DeleteMenuSelectedRows();

            RefreshDisplay();
        }

        /// <summary>
        /// Méthode pour supprimer les menus correspondant aux lignes sélectionnées
        /// </summary>
        private void DeleteMenuSelectedRows()
        {
            if (vaffichermenuBindingSource.Current is cda68_bd1DataSet.v_affichermenuRow currentRow)
            {
                var message = dGVMenu.SelectedRows.Count == 1 ? String.Format(Properties.Resources.TXTCONFIRMATIONSUPPRMENU,
                                                                              currentRow.Moment,
                                                                              currentRow.RepasDate.ToString("D")) :
                                                                Properties.Resources.TXTCONFIRMATIONSUPPRMENUS;
                if (MessageBox.Show(this, message, "Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        using var trans = new TransactionScope();

                        foreach (DataGridViewRow dGVRow in dGVMenu.SelectedRows)
                        {
                            cda68_bd1DataSet.v_affichermenuRow row = (cda68_bd1DataSet.v_affichermenuRow)dGVRow.DataBoundItem;
                            var idMoment = row.Id_Moment;
                            var dateMenu = row.RepasDate;

                            int nb = menuTableAdapter.DeleteByDateAndMoment(idMoment, dateMenu);

                            if (nb != 5)
                            {
                                MessageBox.Show(String.Format(Properties.Resources.TXTDELMENU, idMoment, dateMenu.ToString("D")));
                                return;
                            }
                        }

                        trans.Complete();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(String.Format(Properties.Resources.TXTDELMENU, currentRow.Moment, currentRow.RepasDate.ToString("D")));
                    }
                }
            }
        }

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtAddRandom_Click(object sender, EventArgs e)
        {
            //using (FormAjoutAleatoires formAjout = new FormAjoutAleatoires(dateMonday, dateFriday))
            //{
            //    Visible = false;
            //    formAjout.ShowDialog();
            //    Visible = true;
            //}
            AddRandomWeekMeals();

            RefreshDisplay();

            progressBar.Visible = false;
        }

        /// <summary>
        /// Méthode pour ajouter des menus aléatoires pour toute la semaine sans plat identique
        /// </summary>
        private void AddRandomWeekMeals()
        {
            var random = new Random();

            progressBar.Value = 0;
            progressBar.Visible = true;

            var dates = EachDay(dateMonday, dateFriday).ToImmutableList();
            var moments = cda68_bd1DataSet.Moment.Select(r => r.Id_Moment).ToImmutableList();

            // Récupère tous les menus de la semaine en cours
            var menus = cda68_bd1DataSet.v_affichermenu.Where(r => r.RepasDate >= dateMonday && r.RepasDate <= dateFriday).ToImmutableList();

            // Récupère tous les plats de chaque type et enleve ceux qui sont déjà dans les menus de la semaine
            var Entrees = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 1 && !menus.Any(m => m.Id_Plat_Entree == r.Id_Plat)).ToList();
            var PlatsPrincipaux = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 2 && !menus.Any(m => m.Id_Plat_Principal == r.Id_Plat)).ToList();
            var Accompagnements = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 3 && !menus.Any(m => m.Id_Plat_Accompagnement == r.Id_Plat)).ToList();
            var Fromages = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 4 && !menus.Any(m => m.Id_Plat_Fromage == r.Id_Plat)).ToList();
            var Desserts = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 5 && !menus.Any(m => m.Id_Plat_Dessert == r.Id_Plat)).ToList();

            // Les stocker dans un tableau de liste de plats
            List<cda68_bd1DataSet.v_platsRow>[] PlatsLists = { Entrees, PlatsPrincipaux, Accompagnements, Fromages, Desserts };

            progressBar.Maximum = ((moments.Count * dates.Count) - menus.Count) * PlatsLists.Length;

            try
            {
                using var trans = new TransactionScope();

                // Pour chaque date de la semaine
                foreach (DateTime dt in dates)
                {
                    // Pour chaque moment repas
                    foreach (int idmoment in moments)
                    {
                        // Si il n'y a pas deja de menu à cette date et ce moment
                        if (!menus.Any(m => m.Id_Moment == idmoment && m.RepasDate == dt))
                        {
                            // Pour chaque type de plat
                            foreach (List<cda68_bd1DataSet.v_platsRow> plats in PlatsLists)
                            {
                                // Récupérer un plat aléatoire
                                int i = random.Next(0, plats.Count);

                                // Ajouter le plat dans le SGBD
                                if (menuTableAdapter.Insert(plats[i].Id_Plat, idmoment, dt) != 1)
                                {
                                    // Si le plat n'a pas pus être insérer, prévenir l'utilisateur et quitter la méthode 
                                    // pour ne pas continuer inutilement les insertions et ne pas valider la transaction
                                    MessageBox.Show(menus.Count == 49 ?
                                                        String.Format(Properties.Resources.TXTADDMENU,
                                                                      cda68_bd1DataSet.Moment.First(m => m.Id_Moment == idmoment).Nom,
                                                                      dt.ToString("D")) :
                                                        Properties.Resources.TXTADDMENUS);
                                    return;
                                }

                                // Enlever le plat de la liste pour ne pas le réutiliser
                                plats.RemoveAt(i);

                                // Incrémenter et mettre à jour la barre de progression
                                progressBar.PerformStep();
                                progressBar.Update();
                            }
                        }
                    }
                }

                // Si tous les plats on bien étés insérés, valider la transaction
                trans.Complete();
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTADDMENUS);
            }
        }

        /// <summary>
        /// Méthode pour renvoyer toutes les dates comprises entre 2 dates
        /// </summary>
        /// <param name="startDate">date de debut</param>
        /// <param name="endDate">date de fin</param>
        /// <returns>Enumerable des dates comprises entre la date de debut et de fin</returns>
        private static IEnumerable<DateTime> EachDay(DateTime startDate, DateTime endDate)
        {
            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
            {
                yield return day;
            }
        }

        /// <summary>
        /// Event qui se produit lors de l'affichage du contenu d'une cellule
        /// </summary>
        private void DGVMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Pour ne pas ré afficher la date si la même que celle d'au dessus
            if (e.RowIndex > 0 && (e.ColumnIndex == 0 || e.ColumnIndex == 1))
            {
                if (dGVMenu.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.Equals(e.Value))
                {
                    e.Value = String.Empty;
                }
            }
        }

        /// <summary>
        /// Méthode quand l'on clique sur un titre d'une colonne
        /// </summary>
        private void DGVMenu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dGVMenu.Columns[e.ColumnIndex];

            // Récupérer le sens de tri (ascendant par defaut)
            var sortOrder = column.HeaderCell.SortGlyphDirection == SortOrder.Ascending ? SortOrder.Descending :
                                                                                          SortOrder.Ascending;

            // Supprimer les icones de direction des colonnes
            dGVMenu.Columns.Cast<DataGridViewColumn>().ToList()
                           .ForEach(c => c.HeaderCell.SortGlyphDirection = SortOrder.None);

            // Trier les menus en fonction de la colonne et du sens de tri
            weekMeals.Sort(new MenuComparer(column.DataPropertyName, sortOrder));

            dGVMenu.Refresh();

            column.HeaderCell.SortGlyphDirection = sortOrder;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var random = new Random();

                var dates = EachDay(dateMonday, dateFriday).ToList();
                var moments = cda68_bd1DataSet.Moment.Select(r => r.Id_Moment).ToImmutableList();

                // Récupère tous les menus de la semaine en cours
                var menus = cda68_bd1DataSet.v_affichermenu.Where(r => r.RepasDate >= dateMonday && r.RepasDate <= dateFriday).ToImmutableList();

                // Récupère tous les plats de chaque type et enleve ceux qui sont déjà dans les menus de la semaine
                var Entrees = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 1 && !menus.Any(m => m.Id_Plat_Entree == r.Id_Plat)).ToList();
                var PlatsPrincipaux = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 2 && !menus.Any(m => m.Id_Plat_Principal == r.Id_Plat)).ToList();
                var Accompagnements = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 3 && !menus.Any(m => m.Id_Plat_Accompagnement == r.Id_Plat)).ToList();
                var Fromages = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 4 && !menus.Any(m => m.Id_Plat_Fromage == r.Id_Plat)).ToList();
                var Desserts = cda68_bd1DataSet.v_plats.Where(r => r.Id_Sorte == 5 && !menus.Any(m => m.Id_Plat_Dessert == r.Id_Plat)).ToList();
                //var data = from Entree in cda68_bd1DataSet.v_plats
                //          where Entree.Id_Sorte == 1 && 
                //          !(from menu in menus 
                //            select menu.Id_Plat_Entree)
                //            .Contains(Entree.Id_Plat)
                //          select Entree.Id_Plat;

                //cda68_bd1DataSet.v_plats.Aggregate((a, b) => (a.Id_Plat > b.Id_Plat) ? a : b);
                //cda68_bd1DataSet.v_plats.Max(a => a.Id_Plat + a.Id_Sorte);

                // Les stocker dans un tableau de liste de plats
                List<cda68_bd1DataSet.v_platsRow>[] PlatsLists = { Entrees, PlatsPrincipaux, Accompagnements, Fromages, Desserts };

                using var trans = new TransactionScope();

                int max = ((moments.Count * dates.Count) - menus.Count) * PlatsLists.Length;
                int j = 0;
                // Pour chaque date de la semaine
                foreach (DateTime dt in dates)
                {
                    // Pour chaque moment repas
                    foreach (int idmoment in moments)
                    {
                        // Si il n'y a pas deja de menu à cette date et ce moment
                        if (!menus.Any(m => m.Id_Moment == idmoment && m.RepasDate == dt))
                        {
                            // Pour chaque type de plat
                            foreach (List<cda68_bd1DataSet.v_platsRow> plats in PlatsLists)
                            {
                                // Récupérer un plat aléatoire
                                int i = random.Next(0, plats.Count);

                                // Ajouter le plat dans le SGBD
                                if (menuTableAdapter.Insert(plats[i].Id_Plat, idmoment, dt) != 1)
                                {
                                    // Si le plat n'a pas pus être insérer, prévenir l'utilisateur et quitter la méthode 
                                    // pour ne pas continuer inutilement les insertions et ne pas valider la transaction
                                    MessageBox.Show(menus.Count == 49 ?
                                                        String.Format(Properties.Resources.TXTADDMENU,
                                                                      cda68_bd1DataSet.Moment.First(m => m.Id_Moment == idmoment).Nom,
                                                                      dt.ToString("D")) :
                                                        Properties.Resources.TXTADDMENUS);
                                    return;
                                }

                                // Enlever le plat de la liste pour ne pas le réutiliser
                                plats.RemoveAt(i);

                                // Incrémenter et mettre à jour la barre de progression
                                backgroundWorker.ReportProgress(j * 100 / max);
                            }
                        }
                    }
                }

                // Si tous les plats on bien étés insérés, valider la transaction
                trans.Complete();
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTADDMENUS);
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void BtReserve_Click(object sender, EventArgs e)
        {
            Random random = new();
            progressBar.Visible = true;
            
            var salarie = v_SoldesalarieTableAdapter.GetData().ToImmutableList();
            var formules = formuleTableAdapter.GetData().ToList();
            var menus = cda68_bd1DataSet.v_affichermenu.Where(m => m.RepasDate > DateTime.Today).ToList();
            var reservations = reservationTableAdapter.GetData().ToList();


            progressBar.Maximum = menus.Count;

            foreach (cda68_bd1DataSet.v_affichermenuRow menu in menus)
            {
                if (!reservations.Any(r => r.RepasDate == menu.RepasDate && r.Id_Moment == menu.Id_Moment))
                {
                    int nbRes = random.Next(5, 16);
                    var sal = salarie.ToList();

                    for (int i = 0; i < nbRes; i++)
                    {
                        int idFormule = random.Next(1, formules.Count + 1);
                        var indexSal = random.Next(0, sal.Count);
                        DateTime? datePassage = menu.RepasDate < DateTime.Today ? menu.RepasDate : null;
                        reservationTableAdapter.Insert(sal[indexSal].Matricule, idFormule, menu.Id_Moment, menu.RepasDate, 0, datePassage, formules[idFormule - 1].Prix);
                        sal.RemoveAt(indexSal);
                    }
                }                

                progressBar.PerformStep();
                progressBar.Update();
            }

            progressBar.Visible = false;
            progressBar.Value = 0;
        }

        private void DGVMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cMS.Items.Clear();
                int currentMouseRow = dGVMenu.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseRow >= 0)
                {
                    vaffichermenuBindingSource.Position = currentMouseRow;
                    if (dTPUpdateDate.Value >= dateLimit)
                    {
                        cMS.Items.Add("Supprimer");
                    }
                }
                cMS.Items.Add("Actualiser");
                cMS.Show(dGVMenu, new Point(e.X, e.Y));
            }
        }

        private void CMS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Supprimer"))
            {
                cMS.Close();
                DeleteMenuSelectedRows();
                RefreshDisplay();
            }
            else
            {
                cMS.Close();
                RefreshDisplay();
            }
        }

        private void BtPrint_Click(object sender, EventArgs e)
        {
            //Resize DataGridView to full height.
            int height = dGVMenu.Height;
            dGVMenu.Height = dGVMenu.RowCount * dGVMenu.RowTemplate.Height;

            dGVMenu.ClearSelection();

            //Create a Bitmap and draw the DataGridView on it.
            bitmap = new Bitmap(dGVMenu.Width, dGVMenu.Height);
            dGVMenu.DrawToBitmap(bitmap, new Rectangle(0, 0, dGVMenu.Width, dGVMenu.Height));

            //Resize DataGridView back to original height.
            dGVMenu.Height = height;

            //Show the Print Preview Dialog.
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.PrintPreviewControl.Zoom = 1;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.Landscape = true;
            
            e.Graphics.DrawImage(bitmap, 0, 0);            
        }
    }
}
