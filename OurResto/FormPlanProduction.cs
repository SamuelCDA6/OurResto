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
        DateTime date = DateTime.Today;

        public FormPlanProduction()
        {
            InitializeComponent();
        }

        private void FormPlanProduction_Load(object sender, EventArgs e)
        {
            v_plancuisineTableAdapter.Fill(cda68_bd1DataSet.v_plancuisine);

            vplancuisineBindingSource.DataSource = cda68_bd1DataSet.v_plancuisine.Where(r => r.RepasDate == date)
                                                                                 .OrderBy(r => r.Id_Moment)
                                                                                 .ThenBy(r => r.Id_Sorte).ToList();

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

            UpdateDate(0);
        }

        private void BtBefore_Click(object sender, EventArgs e)
        {
            UpdateDate(-1);
        }

        private void BtAfter_Click(object sender, EventArgs e)
        {
            UpdateDate(1);
        }

        private void UpdateDate(int nbjour)
        {
            date = date.AddDays(nbjour);
            if (date.DayOfWeek == DayOfWeek.Sunday) date = nbjour < 0 ?  date.AddDays(-2) : date.AddDays(1);
            else if (date.DayOfWeek == DayOfWeek.Saturday) date = nbjour < 0 ? date.AddDays(-1) : date.AddDays(2);

            lblJour.Text = date.ToString("D");

            vplancuisineBindingSource.DataSource = cda68_bd1DataSet.v_plancuisine.Where(r => r.RepasDate == date)
                                                                                 .OrderBy(r => r.Id_Moment).ToList();
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

        private void BtQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtToday_Click(object sender, EventArgs e)
        {
            date = DateTime.Today;
            UpdateDate(0);
        }
    }
}
