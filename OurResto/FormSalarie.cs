using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Windows.Forms;

namespace OurResto
{
    public partial class FormSalarie : Form
    {
        List<cda68_bd1DataSet.SalarieRow> salaries = new();

        public FormSalarie()
        {
            InitializeComponent();
        }

        private void FormSalarie_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn c in dGVSalarie.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            toolTip.SetToolTip(tBNom, "Nom du salarié");
            toolTip.SetToolTip(tBPrenom, "Prénom du salarié");
            toolTip.SetToolTip(tBEmail, "Email du salarié");
            toolTip.SetToolTip(tBSolde, "Solde du salarié");
            toolTip.SetToolTip(tBRechercheSalarie, "Permet de recherche un salarié par son nom, son prénom, ou son matricule");
            toolTip.SetToolTip(tBMontant, "Montant à créditer pour le compte repas du salarié");
            toolTip.SetToolTip(btCredit, "Créditer le compte repas du salarié");
            toolTip.SetToolTip(btEdit, "Modifier les informations du salarié");
            toolTip.SetToolTip(btQuitter, "Revenir à la fenêtre principale");
            toolTip.SetToolTip(btRefresh, "Remettre l'affichage à jour");
            toolTip.SetToolTip(btSellOff, "Solder le compte repas du salarié");
            toolTip.SetToolTip(cBTypePaiement, "Type de paiement pour l'accréditation du compte repas");

            RefreshDisplay();

            Manager.ResizeImage(btEdit, Properties.Resources.Edit_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btRefresh, Properties.Resources.Sync_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btCredit, Properties.Resources.Credit_card_256x2561, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btSellOff, Properties.Resources.Delete_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btQuitter, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);
        }

        /// <summary>
        /// Méthode pour mettre à jour les données par rapport au SGBD
        /// </summary>
        private void RefreshDisplay()
        {
            try
            {
                typePaiementTableAdapter.Fill(cda68_bd1DataSet.TypePaiement);
                v_soldesalarieTableAdapter.Fill(cda68_bd1DataSet.v_soldesalarie);
                transactionTableAdapter.Fill(cda68_bd1DataSet.Transaction);
                salarieTableAdapter.Fill(cda68_bd1DataSet.Salarie);

                salaries = cda68_bd1DataSet.Salarie.ToList();

                salarieBindingSource.DataSource = salaries;

                typePaiementBindingSource.DataSource = cda68_bd1DataSet.TypePaiement.OrderByDescending(r => r.Nom).Select(r => r.Nom).ToList();
                
                tBRechercheSalarie.Text = String.Empty;
            }
            catch (Exception)
            {
                MessageBox.Show(this, Properties.Resources.TXTUPDATEFAIL, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVSalarie_SelectionChanged(object sender, EventArgs e)
        {
            tBMontant.Text = String.Empty;

            try
            {
                if (salarieBindingSource.Current is cda68_bd1DataSet.SalarieRow currentRow)
                {
                    btSellOff.Enabled = currentRow.EstActif;

                    transactionBindingSource.DataSource = cda68_bd1DataSet.Transaction.Where(r => r.Matricule == currentRow.Matricule)
                                                                                      .OrderBy(r => r.Horodate).ToList();

                    tBSolde.Text = cda68_bd1DataSet.v_soldesalarie.First(r => r.Matricule == currentRow.Matricule).Solde.ToString();

                    tBSoldeFinal.Text = tBSolde.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTDLTRANSAC);
            }
        }

        #region Recherche Salarie
        private void TBRechercheSalarie_TextChanged(object sender, EventArgs e)
        {
            // Redémarre le timer pour retarder la recherche pour ne pas rechercher a chaque changement
            // mais quand l'utilisateur à finit d'entrer ce qu'il veut rechercher
            timerRechercheSalarie.Stop();
            timerRechercheSalarie.Start();
        }

        private void TimerRechercheSalarie_Tick(object sender, EventArgs e)
        {
            // Arrêter le timer pour ne faire la recherche qu'une seule fois
            timerRechercheSalarie.Stop();

            try
            {
                // Récupérer les salariés dont le nom, ou le prénom commence par le texte ou le matricule est contenu dans le texte
                salaries = cda68_bd1DataSet.Salarie.Where(s => s.Matricule.Contains(tBRechercheSalarie.Text) ||
                                                          s.Nom.StartsWith(tBRechercheSalarie.Text, StringComparison.OrdinalIgnoreCase) ||
                                                          s.Prenom.StartsWith(tBRechercheSalarie.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                // Met a jour la binding source et n'afficher que ses lignes de salariés dans le DataGridView
                if (salaries.Any())
                {
                    salarieBindingSource.DataSource = salaries;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTRECHERCHESALARIE);
            }
        }
        #endregion

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            RefreshDisplay();
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            if (salarieBindingSource.Current is cda68_bd1DataSet.SalarieRow currentRow)
            {
                try
                {
                    currentRow.Nom = tBNom.Text;
                    currentRow.Prenom = tBPrenom.Text;
                    currentRow.Email = tBEmail.Text;

                    if (salarieTableAdapter.Update(currentRow) != 1)
                    {
                        MessageBox.Show(String.Format(Properties.Resources.TXTUPDATESALARIE, currentRow.Prenom, currentRow.Nom));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(String.Format(Properties.Resources.TXTUPDATESALARIE, currentRow.Prenom, currentRow.Nom));
                }
            }

            RefreshDisplay();
        }

        private void BtCredit_Click(object sender, EventArgs e)
        {
            if (salarieBindingSource.Current is cda68_bd1DataSet.SalarieRow currentSalarieRow)
            {
                try
                {
                    int Id_TypePaiement = cda68_bd1DataSet.TypePaiement.First(r => r.Nom == cBTypePaiement.Text).Id_TypePaiement;

                    if (decimal.TryParse(tBMontant.Text, out decimal montant) && montant >= 0)
                    {
                        if (decimal.Parse(tBSolde.Text) + montant > 100)
                        {
                            MessageBox.Show(this, Properties.Resources.TXTSOLDE_100, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            using (var trans = new TransactionScope())
                            {
                                if (transactionTableAdapter.Insert(currentSalarieRow.Matricule, Id_TypePaiement, DateTime.Now, montant) != 1)
                                {
                                    MessageBox.Show(Properties.Resources.TXTINSERTTRANSAC);
                                }
                                else
                                {
                                    currentSalarieRow.EstActif = true;

                                    if (salarieTableAdapter.Update(currentSalarieRow) != 1)
                                    {
                                        MessageBox.Show(Properties.Resources.TXTINSERTTRANSAC);
                                    }
                                    else
                                    {
                                        trans.Complete();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, Properties.Resources.TXTMONTANTINCORRECT, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(String.Format(Properties.Resources.TXTCREDITCOMPTE, currentSalarieRow.Prenom, currentSalarieRow.Nom));
                }
            }

            RefreshDisplay();
        }

        private void BtSellOff_Click(object sender, EventArgs e)
        {
            try
            {
                if (salarieBindingSource.Current is cda68_bd1DataSet.SalarieRow currentRow)
                {
                    if (MessageBox.Show(this, String.Format(Properties.Resources.TXTCONFIRMATIONSOLDER, currentRow.Prenom, currentRow.Nom), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int Id_TypePaiement = cda68_bd1DataSet.TypePaiement[cBTypePaiement.SelectedIndex].Id_TypePaiement;

                        decimal montant = decimal.Parse(tBSolde.Text);

                        using (var trans = new TransactionScope())
                        {
                            bool IsInsert = true;

                            IsInsert = transactionTableAdapter.Insert(currentRow.Matricule, Id_TypePaiement, DateTime.Now, -montant) == 1;

                            currentRow.EstActif = false;

                            if (!IsInsert || salarieTableAdapter.Update(currentRow) != 1)
                            {
                                MessageBox.Show(Properties.Resources.TXTSOLDERCOMPTE);
                            }
                            else
                            {
                                trans.Complete();
                            }
                        }

                        MySqlConnection.ClearAllPools();

                        MessageBox.Show(String.Format(Properties.Resources.TXTRETURNMONEY, montant, currentRow.Prenom, currentRow.Nom));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.TXTSOLDERCOMPTE);
            }

            RefreshDisplay();
        }

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVSalarie_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = dGVSalarie.Columns[e.ColumnIndex];

            SortOrder sortOrder = column.HeaderCell.SortGlyphDirection == SortOrder.Ascending ? SortOrder.Descending : 
                                                                                                SortOrder.Ascending;

            dGVSalarie.Columns.Cast<DataGridViewColumn>().ToList()
                              .ForEach(c => c.HeaderCell.SortGlyphDirection = SortOrder.None);

            salaries.Sort(new SalarieComparer(column.DataPropertyName, sortOrder));

            dGVSalarie.Refresh();

            column.HeaderCell.SortGlyphDirection = sortOrder;
        }

        private void TBMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') e.KeyChar = '.';

            var montant = String.Concat(tBMontant.Text, e.KeyChar);

            if (e.KeyChar != (char)Keys.Back &&
                    (!Regex.IsMatch(montant, @"^(0|[1-9]\d{0,2})([\.]\d{0,2})?$") ||
                     decimal.Parse(montant) + decimal.Parse(tBSolde.Text) > 100))
            {
                e.Handled = true;
            }
        }

        private void TBMontant_TextChanged(object sender, EventArgs e)
        {
            btCredit.Enabled = decimal.TryParse(tBMontant.Text, out decimal montant);
            tBSoldeFinal.Text = (decimal.Parse(tBSolde.Text) + montant).ToString();
        }

        private void TBNom_Prenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void DGVSalarie_MouseClick(object sender, MouseEventArgs e)
        {
            cMS.Items.Clear();

            if (e.Button == MouseButtons.Right)
            {
                cMS.Items.Add("Actualiser");
                cMS.Show(dGVSalarie, new Point(e.X, e.Y));
            }
        }

        private void CMS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            RefreshDisplay();
        }

        private void FormSalarie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.formSalarieX = DesktopLocation.X;
            Properties.Settings.Default.formSalarieY = DesktopLocation.Y;
        }

        private void TBNom_TextChanged(object sender, EventArgs e)
        {
            if (tBNom.Text.Length > 0)
            {
                tBNom.Text = tBNom.Text.ToUpper();
                tBNom.SelectionStart = tBNom.TextLength;
            }

            UpdateButtonsAndText();
        }

        private void TBPrenom_TextChanged(object sender, EventArgs e)
        {
            if (tBPrenom.Text.Length > 1)
            {
                tBPrenom.Text = char.ToUpper(tBPrenom.Text[0]) + tBPrenom.Text[1..].ToLower();
                tBPrenom.SelectionStart = tBPrenom.TextLength;
            }

            UpdateButtonsAndText();
        }

        private void tBEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonsAndText();
        }

        private void UpdateButtonsAndText()
        {
            if (!String.IsNullOrWhiteSpace(tBNom.Text) && !String.IsNullOrWhiteSpace(tBPrenom.Text) && !String.IsNullOrWhiteSpace(tBEmail.Text))
            {
                var isEmailValid = Regex.IsMatch(tBEmail.Text, @"^[\w.-]+[@]+[\w-]+[\.][a-zA-Z]{2,4}$");

                lblInfo.Text = isEmailValid ? "" : "L'email saisi n'est pas valide";

                btEdit.Enabled = isEmailValid && salarieBindingSource.Current is cda68_bd1DataSet.SalarieRow currentRow &&
                                 (tBNom.Text != currentRow.Nom || tBPrenom.Text != currentRow.Prenom ||
                                  !tBEmail.Text.Equals(currentRow.Email, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                btEdit.Enabled = false;

                lblInfo.Text = "Veuillez renseignez tout les champs";
            }
        }
    }
}
