
namespace OurResto
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btQuitter = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuantitePrevisionelle = new System.Windows.Forms.Button();
            this.btSalarie = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.btPlanProduction = new System.Windows.Forms.Button();
            this.lblIntendant = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btQuitter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTitre, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQuitter.Location = new System.Drawing.Point(249, 375);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(136, 58);
            this.btQuitter.TabIndex = 2;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btQuantitePrevisionelle, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btSalarie, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btMenu, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btPlanProduction, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblIntendant, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(629, 246);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cuisinier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btQuantitePrevisionelle
            // 
            this.btQuantitePrevisionelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQuantitePrevisionelle.Location = new System.Drawing.Point(90, 185);
            this.btQuantitePrevisionelle.Name = "btQuantitePrevisionelle";
            this.btQuantitePrevisionelle.Size = new System.Drawing.Size(136, 51);
            this.btQuantitePrevisionelle.TabIndex = 2;
            this.btQuantitePrevisionelle.Text = "Quantité Prévisionnelle";
            this.btQuantitePrevisionelle.UseVisualStyleBackColor = true;
            this.btQuantitePrevisionelle.Click += new System.EventHandler(this.BtQuantitePrevisionelle_Click);
            // 
            // btSalarie
            // 
            this.btSalarie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSalarie.Location = new System.Drawing.Point(90, 52);
            this.btSalarie.Name = "btSalarie";
            this.btSalarie.Size = new System.Drawing.Size(136, 51);
            this.btSalarie.TabIndex = 0;
            this.btSalarie.Text = "Comptes Repas";
            this.btSalarie.UseVisualStyleBackColor = true;
            this.btSalarie.Click += new System.EventHandler(this.BtSalarie_Click);
            // 
            // btMenu
            // 
            this.btMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMenu.Location = new System.Drawing.Point(90, 118);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(136, 51);
            this.btMenu.TabIndex = 1;
            this.btMenu.Text = "Gestion des Menus";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.BtMenu_Click);
            // 
            // btPlanProduction
            // 
            this.btPlanProduction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPlanProduction.Location = new System.Drawing.Point(403, 118);
            this.btPlanProduction.Name = "btPlanProduction";
            this.btPlanProduction.Size = new System.Drawing.Size(136, 51);
            this.btPlanProduction.TabIndex = 3;
            this.btPlanProduction.Text = "Plan de production";
            this.btPlanProduction.UseVisualStyleBackColor = true;
            this.btPlanProduction.Click += new System.EventHandler(this.BtPlanProduction_Click);
            // 
            // lblIntendant
            // 
            this.lblIntendant.AutoSize = true;
            this.lblIntendant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIntendant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIntendant.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntendant.Location = new System.Drawing.Point(6, 3);
            this.lblIntendant.Name = "lblIntendant";
            this.lblIntendant.Size = new System.Drawing.Size(304, 40);
            this.lblIntendant.TabIndex = 4;
            this.lblIntendant.Text = "Intendant";
            this.lblIntendant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.LightGreen;
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitre.Font = new System.Drawing.Font("Matura MT Script Capitals", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(3, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(629, 120);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Our Resto";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 436);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(651, 475);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurResto";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btSalarie;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btPlanProduction;
        private System.Windows.Forms.Button btQuantitePrevisionelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIntendant;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

