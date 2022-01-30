
namespace OurResto
{
    partial class FormQuantitePrevisionnelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuantitePrevisionnelle));
            this.vquantiteprevisionnelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda68_bd1DataSet = new OurResto.cda68_bd1DataSet();
            this.v_quantiteprevisionnelleTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.v_quantiteprevisionnelleTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dGVQuantitePrevisionelle = new System.Windows.Forms.DataGridView();
            this.repasDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btQuitter = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vquantiteprevisionnelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQuantitePrevisionelle)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vquantiteprevisionnelleBindingSource
            // 
            this.vquantiteprevisionnelleBindingSource.DataMember = "v_quantiteprevisionnelle";
            this.vquantiteprevisionnelleBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // cda68_bd1DataSet
            // 
            this.cda68_bd1DataSet.DataSetName = "cda68_bd1DataSet";
            this.cda68_bd1DataSet.Namespace = "http://tempuri.org/cda68_bd1DataSet.xsd";
            this.cda68_bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_quantiteprevisionnelleTableAdapter
            // 
            this.v_quantiteprevisionnelleTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dGVQuantitePrevisionelle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 740);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dGVQuantitePrevisionelle
            // 
            this.dGVQuantitePrevisionelle.AllowUserToAddRows = false;
            this.dGVQuantitePrevisionelle.AllowUserToDeleteRows = false;
            this.dGVQuantitePrevisionelle.AllowUserToResizeColumns = false;
            this.dGVQuantitePrevisionelle.AllowUserToResizeRows = false;
            this.dGVQuantitePrevisionelle.AutoGenerateColumns = false;
            this.dGVQuantitePrevisionelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVQuantitePrevisionelle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVQuantitePrevisionelle.BackgroundColor = System.Drawing.Color.White;
            this.dGVQuantitePrevisionelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQuantitePrevisionelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repasDateDataGridViewTextBoxColumn,
            this.ingredientDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.uniteDataGridViewTextBoxColumn});
            this.dGVQuantitePrevisionelle.DataSource = this.vquantiteprevisionnelleBindingSource;
            this.dGVQuantitePrevisionelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVQuantitePrevisionelle.Location = new System.Drawing.Point(3, 43);
            this.dGVQuantitePrevisionelle.Name = "dGVQuantitePrevisionelle";
            this.dGVQuantitePrevisionelle.ReadOnly = true;
            this.dGVQuantitePrevisionelle.RowHeadersVisible = false;
            this.dGVQuantitePrevisionelle.RowHeadersWidth = 51;
            this.dGVQuantitePrevisionelle.Size = new System.Drawing.Size(575, 621);
            this.dGVQuantitePrevisionelle.TabIndex = 1;
            this.dGVQuantitePrevisionelle.TabStop = false;
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
            // ingredientDataGridViewTextBoxColumn
            // 
            this.ingredientDataGridViewTextBoxColumn.DataPropertyName = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.HeaderText = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ingredientDataGridViewTextBoxColumn.Name = "ingredientDataGridViewTextBoxColumn";
            this.ingredientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantiteDataGridViewTextBoxColumn.Width = 101;
            // 
            // uniteDataGridViewTextBoxColumn
            // 
            this.uniteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uniteDataGridViewTextBoxColumn.DataPropertyName = "Unite";
            this.uniteDataGridViewTextBoxColumn.HeaderText = "Unite";
            this.uniteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uniteDataGridViewTextBoxColumn.Name = "uniteDataGridViewTextBoxColumn";
            this.uniteDataGridViewTextBoxColumn.ReadOnly = true;
            this.uniteDataGridViewTextBoxColumn.Width = 77;
            // 
            // tBTitle
            // 
            this.tBTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBTitle.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBTitle.Location = new System.Drawing.Point(3, 3);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.ReadOnly = true;
            this.tBTitle.Size = new System.Drawing.Size(575, 34);
            this.tBTitle.TabIndex = 2;
            this.tBTitle.TabStop = false;
            this.tBTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btQuitter, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 670);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(575, 67);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btQuitter.Location = new System.Drawing.Point(218, 3);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(138, 61);
            this.btQuitter.TabIndex = 10;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // FormQuantitePrevisionnelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 740);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "FormQuantitePrevisionnelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantite Previsionnelle d\'ingrédients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuantitePrevisionnelle_FormClosing);
            this.Load += new System.EventHandler(this.FormQuantitePrevisionnelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vquantiteprevisionnelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQuantitePrevisionelle)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private cda68_bd1DataSet cda68_bd1DataSet;
        private cda68_bd1DataSetTableAdapters.v_quantiteprevisionnelleTableAdapter v_quantiteprevisionnelleTableAdapter;
        private System.Windows.Forms.BindingSource vquantiteprevisionnelleBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dGVQuantitePrevisionelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn repasDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tBTitle;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btQuitter;
    }
}