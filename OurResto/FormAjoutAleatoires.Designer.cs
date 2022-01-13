namespace OurResto
{
    partial class FormAjoutAleatoires
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
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tLPDates = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tLPMain.SuspendLayout();
            this.tLPDates.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tLPMain.Controls.Add(this.tLPDates, 0, 0);
            this.tLPMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 3;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tLPMain.Size = new System.Drawing.Size(733, 450);
            this.tLPMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 402);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(727, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tLPDates
            // 
            this.tLPDates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tLPDates.ColumnCount = 2;
            this.tLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDates.Controls.Add(this.dateTimePicker2, 1, 1);
            this.tLPDates.Controls.Add(this.label1, 1, 0);
            this.tLPDates.Controls.Add(this.lblDateDebut, 0, 0);
            this.tLPDates.Controls.Add(this.dateTimePicker1, 0, 1);
            this.tLPDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPDates.Location = new System.Drawing.Point(3, 3);
            this.tLPDates.Name = "tLPDates";
            this.tLPDates.RowCount = 2;
            this.tLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPDates.Size = new System.Drawing.Size(727, 94);
            this.tLPDates.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker2.Location = new System.Drawing.Point(366, 23);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(358, 27);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2022, 1, 11, 13, 45, 13, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(366, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date de fin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDebut.Location = new System.Drawing.Point(3, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(357, 20);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date de début";
            this.lblDateDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(357, 27);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 11, 13, 45, 13, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 293);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jours auquelles ajouter des menus";
            // 
            // FormAjoutAleatoires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.tLPMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormAjoutAleatoires";
            this.Text = "Ajout aléatoire de menus";
            this.tLPMain.ResumeLayout(false);
            this.tLPDates.ResumeLayout(false);
            this.tLPDates.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tLPDates;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}