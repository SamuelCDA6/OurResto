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
            this.tLPButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.tLPProgressBar = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.tLPDates = new System.Windows.Forms.TableLayoutPanel();
            this.dTPDateFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dTPDateDebut = new System.Windows.Forms.DateTimePicker();
            this.tLPJoursMoments = new System.Windows.Forms.TableLayoutPanel();
            this.gBDays = new System.Windows.Forms.GroupBox();
            this.cLBJours = new System.Windows.Forms.CheckedListBox();
            this.gBMoments = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cda68_bd1DataSet = new OurResto.cda68_bd1DataSet();
            this.tLPMain.SuspendLayout();
            this.tLPButtons.SuspendLayout();
            this.tLPProgressBar.SuspendLayout();
            this.tLPDates.SuspendLayout();
            this.tLPJoursMoments.SuspendLayout();
            this.gBDays.SuspendLayout();
            this.gBMoments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.Controls.Add(this.tLPButtons, 0, 2);
            this.tLPMain.Controls.Add(this.tLPDates, 0, 0);
            this.tLPMain.Controls.Add(this.tLPJoursMoments, 0, 1);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 3;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tLPMain.Size = new System.Drawing.Size(780, 530);
            this.tLPMain.TabIndex = 0;
            // 
            // tLPButtons
            // 
            this.tLPButtons.ColumnCount = 3;
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tLPButtons.Controls.Add(this.btQuitter, 0, 0);
            this.tLPButtons.Controls.Add(this.btAjouter, 2, 0);
            this.tLPButtons.Controls.Add(this.tLPProgressBar, 1, 0);
            this.tLPButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPButtons.Location = new System.Drawing.Point(3, 413);
            this.tLPButtons.Name = "tLPButtons";
            this.tLPButtons.RowCount = 1;
            this.tLPButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPButtons.Size = new System.Drawing.Size(774, 114);
            this.tLPButtons.TabIndex = 0;
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQuitter.BackColor = System.Drawing.SystemColors.Control;
            this.btQuitter.Location = new System.Drawing.Point(31, 25);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(138, 64);
            this.btQuitter.TabIndex = 11;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAjouter.BackColor = System.Drawing.SystemColors.Control;
            this.btAjouter.Location = new System.Drawing.Point(605, 25);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(138, 64);
            this.btAjouter.TabIndex = 16;
            this.btAjouter.Text = "&Ajouter";
            this.btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjouter.UseVisualStyleBackColor = false;
            this.btAjouter.Click += new System.EventHandler(this.BtAjouter_Click);
            // 
            // tLPProgressBar
            // 
            this.tLPProgressBar.ColumnCount = 1;
            this.tLPProgressBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPProgressBar.Controls.Add(this.progressBar, 0, 0);
            this.tLPProgressBar.Controls.Add(this.lblProgressBar, 0, 1);
            this.tLPProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPProgressBar.Location = new System.Drawing.Point(203, 3);
            this.tLPProgressBar.Name = "tLPProgressBar";
            this.tLPProgressBar.RowCount = 2;
            this.tLPProgressBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPProgressBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLPProgressBar.Size = new System.Drawing.Size(368, 108);
            this.tLPProgressBar.TabIndex = 17;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(362, 72);
            this.progressBar.TabIndex = 18;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgressBar.Location = new System.Drawing.Point(3, 78);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(362, 30);
            this.lblProgressBar.TabIndex = 19;
            this.lblProgressBar.Text = "label1";
            this.lblProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tLPDates
            // 
            this.tLPDates.ColumnCount = 2;
            this.tLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPDates.Controls.Add(this.dTPDateFin, 1, 1);
            this.tLPDates.Controls.Add(this.lblDateFin, 1, 0);
            this.tLPDates.Controls.Add(this.lblDateDebut, 0, 0);
            this.tLPDates.Controls.Add(this.dTPDateDebut, 0, 1);
            this.tLPDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPDates.Location = new System.Drawing.Point(3, 3);
            this.tLPDates.Name = "tLPDates";
            this.tLPDates.RowCount = 2;
            this.tLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLPDates.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPDates.Size = new System.Drawing.Size(774, 94);
            this.tLPDates.TabIndex = 1;
            // 
            // dTPDateFin
            // 
            this.dTPDateFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTPDateFin.Location = new System.Drawing.Point(390, 53);
            this.dTPDateFin.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.dTPDateFin.Name = "dTPDateFin";
            this.dTPDateFin.Size = new System.Drawing.Size(381, 27);
            this.dTPDateFin.TabIndex = 3;
            this.dTPDateFin.Value = new System.DateTime(2022, 1, 11, 13, 45, 13, 0);
            this.dTPDateFin.CloseUp += new System.EventHandler(this.DTP_CloseUp);
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateFin.Location = new System.Drawing.Point(390, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(381, 50);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "Date de fin";
            this.lblDateFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateDebut.Location = new System.Drawing.Point(3, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(381, 50);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date de début";
            this.lblDateDebut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dTPDateDebut
            // 
            this.dTPDateDebut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTPDateDebut.Location = new System.Drawing.Point(3, 53);
            this.dTPDateDebut.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.dTPDateDebut.Name = "dTPDateDebut";
            this.dTPDateDebut.Size = new System.Drawing.Size(381, 27);
            this.dTPDateDebut.TabIndex = 2;
            this.dTPDateDebut.Value = new System.DateTime(2022, 1, 11, 13, 45, 13, 0);
            this.dTPDateDebut.CloseUp += new System.EventHandler(this.DTP_CloseUp);
            // 
            // tLPJoursMoments
            // 
            this.tLPJoursMoments.ColumnCount = 2;
            this.tLPJoursMoments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPJoursMoments.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPJoursMoments.Controls.Add(this.gBDays, 0, 0);
            this.tLPJoursMoments.Controls.Add(this.gBMoments, 1, 0);
            this.tLPJoursMoments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPJoursMoments.Location = new System.Drawing.Point(3, 103);
            this.tLPJoursMoments.Name = "tLPJoursMoments";
            this.tLPJoursMoments.RowCount = 1;
            this.tLPJoursMoments.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPJoursMoments.Size = new System.Drawing.Size(774, 304);
            this.tLPJoursMoments.TabIndex = 2;
            // 
            // gBDays
            // 
            this.gBDays.Controls.Add(this.cLBJours);
            this.gBDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBDays.Location = new System.Drawing.Point(3, 3);
            this.gBDays.Name = "gBDays";
            this.gBDays.Size = new System.Drawing.Size(381, 298);
            this.gBDays.TabIndex = 0;
            this.gBDays.TabStop = false;
            this.gBDays.Text = "Jours";
            // 
            // cLBJours
            // 
            this.cLBJours.CheckOnClick = true;
            this.cLBJours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLBJours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cLBJours.FormattingEnabled = true;
            this.cLBJours.Items.AddRange(new object[] {
            "Dimanche",
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi"});
            this.cLBJours.Location = new System.Drawing.Point(3, 23);
            this.cLBJours.Name = "cLBJours";
            this.cLBJours.Size = new System.Drawing.Size(375, 272);
            this.cLBJours.TabIndex = 1;
            // 
            // gBMoments
            // 
            this.gBMoments.Controls.Add(this.checkedListBox1);
            this.gBMoments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBMoments.Location = new System.Drawing.Point(390, 3);
            this.gBMoments.Name = "gBMoments";
            this.gBMoments.Size = new System.Drawing.Size(381, 298);
            this.gBMoments.TabIndex = 1;
            this.gBMoments.TabStop = false;
            this.gBMoments.Text = "Moments";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Midi",
            "Soir"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(375, 272);
            this.checkedListBox1.TabIndex = 0;
            // 
            // cda68_bd1DataSet
            // 
            this.cda68_bd1DataSet.DataSetName = "cda68_bd1DataSet";
            this.cda68_bd1DataSet.Namespace = "http://tempuri.org/cda68_bd1DataSet.xsd";
            this.cda68_bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAjoutAleatoires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 530);
            this.Controls.Add(this.tLPMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(1219, 687);
            this.MinimumSize = new System.Drawing.Size(624, 468);
            this.Name = "FormAjoutAleatoires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout aléatoire de menus";
            this.Load += new System.EventHandler(this.FormAjoutAleatoires_Load);
            this.tLPMain.ResumeLayout(false);
            this.tLPButtons.ResumeLayout(false);
            this.tLPProgressBar.ResumeLayout(false);
            this.tLPProgressBar.PerformLayout();
            this.tLPDates.ResumeLayout(false);
            this.tLPDates.PerformLayout();
            this.tLPJoursMoments.ResumeLayout(false);
            this.gBDays.ResumeLayout(false);
            this.gBMoments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private System.Windows.Forms.TableLayoutPanel tLPDates;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DateTimePicker dTPDateFin;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dTPDateDebut;
        private System.Windows.Forms.TableLayoutPanel tLPJoursMoments;
        private System.Windows.Forms.GroupBox gBDays;
        private System.Windows.Forms.TableLayoutPanel tLPButtons;
        private System.Windows.Forms.CheckedListBox cLBJours;
        private System.Windows.Forms.GroupBox gBMoments;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btAjouter;
        private cda68_bd1DataSet cda68_bd1DataSet;
        private System.Windows.Forms.TableLayoutPanel tLPProgressBar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgressBar;
    }
}