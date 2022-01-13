namespace OurResto
{
    partial class FormPlanProduction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanProduction));
            this.vplancuisineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda68_bd1DataSet = new OurResto.cda68_bd1DataSet();
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblJour = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btExit = new System.Windows.Forms.Button();
            this.btToday = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dGVPlanProduction = new System.Windows.Forms.DataGridView();
            this.v_plancuisineTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.v_plancuisineTableAdapter();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.repasDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMomentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.momentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSorteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vplancuisineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).BeginInit();
            this.tLPMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlanProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // vplancuisineBindingSource
            // 
            this.vplancuisineBindingSource.DataMember = "v_plancuisine";
            this.vplancuisineBindingSource.DataSource = this.cda68_bd1DataSet;
            this.vplancuisineBindingSource.CurrentChanged += new System.EventHandler(this.VplancuisineBindingSource_CurrentChanged);
            // 
            // cda68_bd1DataSet
            // 
            this.cda68_bd1DataSet.DataSetName = "cda68_bd1DataSet";
            this.cda68_bd1DataSet.Namespace = "http://tempuri.org/cda68_bd1DataSet.xsd";
            this.cda68_bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tLPMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tLPMain.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 3;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPMain.Size = new System.Drawing.Size(1135, 507);
            this.tLPMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblJour, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btBefore, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAfter, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblJour
            // 
            this.lblJour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJour.AutoSize = true;
            this.lblJour.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJour.Location = new System.Drawing.Point(416, 7);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(296, 30);
            this.lblJour.TabIndex = 6;
            this.lblJour.Text = "Jeudi 9 décembre 2021";
            // 
            // btBefore
            // 
            this.btBefore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btBefore.Location = new System.Drawing.Point(17, 3);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(80, 38);
            this.btBefore.TabIndex = 0;
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.BtBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAfter.Location = new System.Drawing.Point(1032, 3);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(80, 38);
            this.btAfter.TabIndex = 1;
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.BtAfter_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btExit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btToday, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 434);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1129, 70);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.Location = new System.Drawing.Point(200, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(164, 64);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "&Quitter";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // btToday
            // 
            this.btToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btToday.BackColor = System.Drawing.Color.Transparent;
            this.btToday.Location = new System.Drawing.Point(764, 3);
            this.btToday.Name = "btToday";
            this.btToday.Size = new System.Drawing.Size(164, 64);
            this.btToday.TabIndex = 3;
            this.btToday.Text = "&Aujourd\'hui";
            this.btToday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btToday.UseVisualStyleBackColor = false;
            this.btToday.Click += new System.EventHandler(this.BtToday_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dGVPlanProduction, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1129, 375);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(567, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(559, 371);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            // 
            // dGVPlanProduction
            // 
            this.dGVPlanProduction.AllowUserToAddRows = false;
            this.dGVPlanProduction.AllowUserToDeleteRows = false;
            this.dGVPlanProduction.AllowUserToResizeColumns = false;
            this.dGVPlanProduction.AllowUserToResizeRows = false;
            this.dGVPlanProduction.AutoGenerateColumns = false;
            this.dGVPlanProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPlanProduction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVPlanProduction.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGVPlanProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPlanProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repasDateDataGridViewTextBoxColumn,
            this.idMomentDataGridViewTextBoxColumn,
            this.momentDataGridViewTextBoxColumn,
            this.idPlatDataGridViewTextBoxColumn,
            this.platDataGridViewTextBoxColumn,
            this.idSorteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dGVPlanProduction.DataSource = this.vplancuisineBindingSource;
            this.dGVPlanProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVPlanProduction.Location = new System.Drawing.Point(3, 2);
            this.dGVPlanProduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVPlanProduction.MultiSelect = false;
            this.dGVPlanProduction.Name = "dGVPlanProduction";
            this.dGVPlanProduction.ReadOnly = true;
            this.dGVPlanProduction.RowHeadersVisible = false;
            this.dGVPlanProduction.RowHeadersWidth = 51;
            this.dGVPlanProduction.RowTemplate.Height = 24;
            this.dGVPlanProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVPlanProduction.Size = new System.Drawing.Size(558, 371);
            this.dGVPlanProduction.TabIndex = 1;
            this.dGVPlanProduction.TabStop = false;
            this.dGVPlanProduction.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVPlanProduction_CellFormatting_1);
            // 
            // v_plancuisineTableAdapter
            // 
            this.v_plancuisineTableAdapter.ClearBeforeFill = true;
            // 
            // repasDateDataGridViewTextBoxColumn
            // 
            this.repasDateDataGridViewTextBoxColumn.DataPropertyName = "RepasDate";
            this.repasDateDataGridViewTextBoxColumn.HeaderText = "RepasDate";
            this.repasDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repasDateDataGridViewTextBoxColumn.Name = "repasDateDataGridViewTextBoxColumn";
            this.repasDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.repasDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMomentDataGridViewTextBoxColumn
            // 
            this.idMomentDataGridViewTextBoxColumn.DataPropertyName = "Id_Moment";
            this.idMomentDataGridViewTextBoxColumn.HeaderText = "Id_Moment";
            this.idMomentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMomentDataGridViewTextBoxColumn.Name = "idMomentDataGridViewTextBoxColumn";
            this.idMomentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMomentDataGridViewTextBoxColumn.Visible = false;
            // 
            // momentDataGridViewTextBoxColumn
            // 
            this.momentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.momentDataGridViewTextBoxColumn.DataPropertyName = "Moment";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.momentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.momentDataGridViewTextBoxColumn.HeaderText = "Moment";
            this.momentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.momentDataGridViewTextBoxColumn.Name = "momentDataGridViewTextBoxColumn";
            this.momentDataGridViewTextBoxColumn.ReadOnly = true;
            this.momentDataGridViewTextBoxColumn.Width = 98;
            // 
            // idPlatDataGridViewTextBoxColumn
            // 
            this.idPlatDataGridViewTextBoxColumn.DataPropertyName = "Id_Plat";
            this.idPlatDataGridViewTextBoxColumn.HeaderText = "Id_Plat";
            this.idPlatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlatDataGridViewTextBoxColumn.Name = "idPlatDataGridViewTextBoxColumn";
            this.idPlatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlatDataGridViewTextBoxColumn.Visible = false;
            // 
            // platDataGridViewTextBoxColumn
            // 
            this.platDataGridViewTextBoxColumn.DataPropertyName = "Plat";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.platDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.platDataGridViewTextBoxColumn.HeaderText = "Plat";
            this.platDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.platDataGridViewTextBoxColumn.Name = "platDataGridViewTextBoxColumn";
            this.platDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSorteDataGridViewTextBoxColumn
            // 
            this.idSorteDataGridViewTextBoxColumn.DataPropertyName = "Id_Sorte";
            this.idSorteDataGridViewTextBoxColumn.HeaderText = "Id_Sorte";
            this.idSorteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idSorteDataGridViewTextBoxColumn.Name = "idSorteDataGridViewTextBoxColumn";
            this.idSorteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSorteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 97;
            // 
            // FormPlanProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1135, 507);
            this.Controls.Add(this.tLPMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 373);
            this.Name = "FormPlanProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plan de production";
            this.Load += new System.EventHandler(this.FormPlanProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vplancuisineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).EndInit();
            this.tLPMain.ResumeLayout(false);
            this.tLPMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPlanProduction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private cda68_bd1DataSet cda68_bd1DataSet;
        private cda68_bd1DataSetTableAdapters.v_plancuisineTableAdapter v_plancuisineTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.BindingSource vplancuisineBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btToday;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dGVPlanProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn repasDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMomentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn momentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSorteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}