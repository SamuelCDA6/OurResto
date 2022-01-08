using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurResto
{
    public partial class FormPlanProduction : Form
    {
        DateTime mealDate = DateTime.Today;

        public FormPlanProduction()
        {
            InitializeComponent();
        }

        private void FormPlanProduction_Load(object sender, EventArgs e)
        {
            v_plancuisineTableAdapter.Fill(cda68_bd1DataSet.v_plancuisine);

            Manager.ResizeImage(btBefore, Properties.Resources.Arrow_left_256x256, ContentAlignment.MiddleCenter);
            Manager.ResizeImage(btAfter, Properties.Resources.Arrow_right_256x256, ContentAlignment.MiddleCenter);
            Manager.ResizeImage(btExit, Properties.Resources.Power_256x256, ContentAlignment.MiddleLeft);
            Manager.ResizeImage(btToday, Properties.Resources.Calendar_256x256, ContentAlignment.MiddleLeft);

            toolTip.SetToolTip(btExit, "Revenir à la fenêtre principale");
            toolTip.SetToolTip(btAfter, "Aller au jour suivant");
            toolTip.SetToolTip(btBefore, "Aller au jour précédent");
            toolTip.SetToolTip(btToday, "Revenir à aujoud'hui");

            dGVPlanProduction.DefaultCellStyle.BackColor = Color.White;

            foreach (DataGridViewColumn c in dGVPlanProduction.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            SetDate(mealDate);
        }

        private void SetDate(DateTime date)
        {
            var rows = cda68_bd1DataSet.v_plancuisine.OrderBy(r => Math.Abs((r.RepasDate - date).Days)).ToList();

            // Mettre à jour avec ses lignes
            UpdateDate(rows);
        }

        private void BtToday_Click(object sender, EventArgs e)
        {
            mealDate = DateTime.Today;
            SetDate(mealDate);
        }
        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtBefore_Click(object sender, EventArgs e)
        {
            var rows = ResearchDate(mealDate, false);

            // Mettre à jour avec ses lignes
            UpdateDate(rows);
        }

        private void BtAfter_Click(object sender, EventArgs e)
        {
            // Récupère les lignes après la date du repas
            var rows = ResearchDate(mealDate, true);

            // Mettre à jour avec ses lignes
            UpdateDate(rows);
        }

        /// <summary>
        /// Méthode de recherche de plan de repas à une date et un sens donné
        /// </summary>
        /// <param name="date"> date à partir de laquelle on recherche (date non incluse)</param>
        /// <param name="searchDirection"> sens de recherche : true = repas après cette date</param>
        /// <returns> les lignes qui sont correspondent à cette recherche dans l'ordre de la proche à la plus éloigné de la date initiale</returns>
        private List<cda68_bd1DataSet.v_plancuisineRow> ResearchDate(DateTime date, bool searchDirection)
        {
            // Sélectionne les lignes qui sont supérieur ou inférieur et les ordonne par la différence de jours
            return cda68_bd1DataSet.v_plancuisine.Where(r => searchDirection ? r.RepasDate > date : r.RepasDate < date)
                                                 .OrderBy(r => Math.Abs((r.RepasDate - date).Days))
                                                 .ToList();
        }

        /// <summary>
        /// Méthode de mise à jour de l'affichage du plan de production de repas avec les lignes 
        /// qui correspondent à la date de la première ligne 
        /// </summary>
        /// <param name="rows"> lignes qui contiennent les repas par ordre de date</param>
        private void UpdateDate(List<cda68_bd1DataSet.v_plancuisineRow> rows)
        {
            if (rows.Any())
            {
                // On 
                mealDate = rows.First().RepasDate;
                lblJour.Text = mealDate.ToString("D");

                vplancuisineBindingSource.DataSource = rows.TakeWhile(r => r.RepasDate == mealDate)
                                                           .OrderBy(r => r.Id_Moment)
                                                           .ThenBy(r => r.Id_Sorte)
                                                           .ToList();
            }
        }

        private void DGVPlanProduction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > 0 && e.ColumnIndex == 2)
            {
                if (dGVPlanProduction.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value.Equals(e.Value))
                {
                    e.Value = String.Empty;
                }
            }
        }
    }
}
