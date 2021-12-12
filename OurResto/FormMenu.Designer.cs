
namespace OurResto
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.dGVMenu = new System.Windows.Forms.DataGridView();
            this.repasDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.momentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatEntreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatPrincipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatAccompagnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accompagnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatFromageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlatDessertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dessertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMomentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaffichermenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda68_bd1DataSet = new OurResto.cda68_bd1DataSet();
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tLPInputBox = new System.Windows.Forms.TableLayoutPanel();
            this.cBPlatFromage = new System.Windows.Forms.ComboBox();
            this.cBPlatAccompagnement = new System.Windows.Forms.ComboBox();
            this.cBPlatPrincipal = new System.Windows.Forms.ComboBox();
            this.cBPlatEntree = new System.Windows.Forms.ComboBox();
            this.lblPlat = new System.Windows.Forms.Label();
            this.lblDessert = new System.Windows.Forms.Label();
            this.lblFromage = new System.Windows.Forms.Label();
            this.lblEntree = new System.Windows.Forms.Label();
            this.lblAccompagnement = new System.Windows.Forms.Label();
            this.dTPUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.cBPlatDessert = new System.Windows.Forms.ComboBox();
            this.lblDateRepas = new System.Windows.Forms.Label();
            this.lblMoment = new System.Windows.Forms.Label();
            this.cBMoment = new System.Windows.Forms.ComboBox();
            this.tLPDateSemaine = new System.Windows.Forms.TableLayoutPanel();
            this.dTPWeek = new System.Windows.Forms.DateTimePicker();
            this.lblSemaine = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fLPButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btActualiser = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.momentTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.MomentTableAdapter();
            this.vplatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_platsTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.v_platsTableAdapter();
            this.menuTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.MenuTableAdapter();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_affichermenuTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.v_affichermenuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaffichermenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).BeginInit();
            this.tLPMain.SuspendLayout();
            this.tLPInputBox.SuspendLayout();
            this.tLPDateSemaine.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.fLPButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vplatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMenu
            // 
            this.dGVMenu.AllowUserToAddRows = false;
            this.dGVMenu.AllowUserToDeleteRows = false;
            this.dGVMenu.AllowUserToResizeColumns = false;
            this.dGVMenu.AllowUserToResizeRows = false;
            this.dGVMenu.AutoGenerateColumns = false;
            this.dGVMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVMenu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repasDateDataGridViewTextBoxColumn,
            this.momentDataGridViewTextBoxColumn,
            this.idPlatEntreeDataGridViewTextBoxColumn,
            this.entreeDataGridViewTextBoxColumn,
            this.idPlatPrincipalDataGridViewTextBoxColumn,
            this.platDataGridViewTextBoxColumn,
            this.idPlatAccompagnementDataGridViewTextBoxColumn,
            this.accompagnementDataGridViewTextBoxColumn,
            this.idPlatFromageDataGridViewTextBoxColumn,
            this.fromageDataGridViewTextBoxColumn,
            this.idPlatDessertDataGridViewTextBoxColumn,
            this.dessertDataGridViewTextBoxColumn,
            this.idMomentDataGridViewTextBoxColumn});
            this.dGVMenu.DataSource = this.vaffichermenuBindingSource;
            this.dGVMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVMenu.Location = new System.Drawing.Point(4, 64);
            this.dGVMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dGVMenu.MultiSelect = false;
            this.dGVMenu.Name = "dGVMenu";
            this.dGVMenu.ReadOnly = true;
            this.dGVMenu.RowHeadersVisible = false;
            this.dGVMenu.RowHeadersWidth = 51;
            this.dGVMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVMenu.Size = new System.Drawing.Size(1028, 271);
            this.dGVMenu.StandardTab = true;
            this.dGVMenu.TabIndex = 100;
            this.dGVMenu.TabStop = false;
            this.dGVMenu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVMenu_CellFormatting);
            this.dGVMenu.SelectionChanged += new System.EventHandler(this.DGVMenu_SelectionChanged);
            // 
            // repasDateDataGridViewTextBoxColumn
            // 
            this.repasDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.repasDateDataGridViewTextBoxColumn.DataPropertyName = "RepasDate";
            this.repasDateDataGridViewTextBoxColumn.HeaderText = "Date du repas";
            this.repasDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repasDateDataGridViewTextBoxColumn.Name = "repasDateDataGridViewTextBoxColumn";
            this.repasDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.repasDateDataGridViewTextBoxColumn.Width = 144;
            // 
            // momentDataGridViewTextBoxColumn
            // 
            this.momentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.momentDataGridViewTextBoxColumn.DataPropertyName = "Moment";
            this.momentDataGridViewTextBoxColumn.HeaderText = "Moment";
            this.momentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.momentDataGridViewTextBoxColumn.Name = "momentDataGridViewTextBoxColumn";
            this.momentDataGridViewTextBoxColumn.ReadOnly = true;
            this.momentDataGridViewTextBoxColumn.Width = 98;
            // 
            // idPlatEntreeDataGridViewTextBoxColumn
            // 
            this.idPlatEntreeDataGridViewTextBoxColumn.DataPropertyName = "Id_Plat_Entree";
            this.idPlatEntreeDataGridViewTextBoxColumn.HeaderText = "Id_Plat_Entree";
            this.idPlatEntreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlatEntreeDataGridViewTextBoxColumn.Name = "idPlatEntreeDataGridViewTextBoxColumn";
            this.idPlatEntreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlatEntreeDataGridViewTextBoxColumn.Visible = false;
            // 
            // entreeDataGridViewTextBoxColumn
            // 
            this.entreeDataGridViewTextBoxColumn.DataPropertyName = "Entree";
            this.entreeDataGridViewTextBoxColumn.HeaderText = "Entree";
            this.entreeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entreeDataGridViewTextBoxColumn.Name = "entreeDataGridViewTextBoxColumn";
            this.entreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPlatPrincipalDataGridViewTextBoxColumn
            // 
            this.idPlatPrincipalDataGridViewTextBoxColumn.DataPropertyName = "Id_Plat_Principal";
            this.idPlatPrincipalDataGridViewTextBoxColumn.HeaderText = "Id_Plat_Principal";
            this.idPlatPrincipalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlatPrincipalDataGridViewTextBoxColumn.Name = "idPlatPrincipalDataGridViewTextBoxColumn";
            this.idPlatPrincipalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlatPrincipalDataGridViewTextBoxColumn.Visible = false;
            // 
            // platDataGridViewTextBoxColumn
            // 
            this.platDataGridViewTextBoxColumn.DataPropertyName = "Plat";
            this.platDataGridViewTextBoxColumn.HeaderText = "Plat";
            this.platDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.platDataGridViewTextBoxColumn.Name = "platDataGridViewTextBoxColumn";
            this.platDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPlatAccompagnementDataGridViewTextBoxColumn
            // 
            this.idPlatAccompagnementDataGridViewTextBoxColumn.DataPropertyName = "Id_Plat_Accompagnement";
            this.idPlatAccompagnementDataGridViewTextBoxColumn.HeaderText = "Id_Plat_Accompagnement";
            this.idPlatAccompagnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlatAccompagnementDataGridViewTextBoxColumn.Name = "idPlatAccompagnementDataGridViewTextBoxColumn";
            this.idPlatAccompagnementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlatAccompagnementDataGridViewTextBoxColumn.Visible = false;
            // 
            // accompagnementDataGridViewTextBoxColumn
            // 
            this.accompagnementDataGridViewTextBoxColumn.DataPropertyName = "Accompagnement";
            this.accompagnementDataGridViewTextBoxColumn.HeaderText = "Accompagnement";
            this.accompagnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accompagnementDataGridViewTextBoxColumn.Name = "accompagnementDataGridViewTextBoxColumn";
            this.accompagnementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPlatFromageDataGridViewTextBoxColumn
            // 
            this.idPlatFromageDataGridViewTextBoxColumn.DataPropertyName = "Id_Plat_Fromage";
            this.idPlatFromageDataGridViewTextBoxColumn.HeaderText = "Id_Plat_Fromage";
            this.idPlatFromageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlatFromageDataGridViewTextBoxColumn.Name = "idPlatFromageDataGridViewTextBoxColumn";
            this.idPlatFromageDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlatFromageDataGridViewTextBoxColumn.Visible = false;
            // 
            // fromageDataGridViewTextBoxColumn
            // 
            this.fromageDataGridViewTextBoxColumn.DataPropertyName = "Fromage";
            this.fromageDataGridViewTextBoxColumn.HeaderText = "Fromage";
            this.fromageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fromageDataGridViewTextBoxColumn.Name = "fromageDataGridViewTextBoxColumn";
            this.fromageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idPlatDessertDataGridViewTextBoxColumn
            // 
            this.idPlatDessertDataGridViewTextBoxColumn.DataPropertyName = "Id_Plat_Dessert";
            this.idPlatDessertDataGridViewTextBoxColumn.HeaderText = "Id_Plat_Dessert";
            this.idPlatDessertDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlatDessertDataGridViewTextBoxColumn.Name = "idPlatDessertDataGridViewTextBoxColumn";
            this.idPlatDessertDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPlatDessertDataGridViewTextBoxColumn.Visible = false;
            // 
            // dessertDataGridViewTextBoxColumn
            // 
            this.dessertDataGridViewTextBoxColumn.DataPropertyName = "Dessert";
            this.dessertDataGridViewTextBoxColumn.HeaderText = "Dessert";
            this.dessertDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dessertDataGridViewTextBoxColumn.Name = "dessertDataGridViewTextBoxColumn";
            this.dessertDataGridViewTextBoxColumn.ReadOnly = true;
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
            // vaffichermenuBindingSource
            // 
            this.vaffichermenuBindingSource.DataMember = "v_affichermenu";
            this.vaffichermenuBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // cda68_bd1DataSet
            // 
            this.cda68_bd1DataSet.DataSetName = "cda68_bd1DataSet";
            this.cda68_bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.Controls.Add(this.dGVMenu, 0, 1);
            this.tLPMain.Controls.Add(this.tLPInputBox, 0, 2);
            this.tLPMain.Controls.Add(this.tLPDateSemaine, 0, 0);
            this.tLPMain.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 4;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tLPMain.Size = new System.Drawing.Size(1036, 581);
            this.tLPMain.TabIndex = 1;
            // 
            // tLPInputBox
            // 
            this.tLPInputBox.AutoSize = true;
            this.tLPInputBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tLPInputBox.ColumnCount = 4;
            this.tLPInputBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLPInputBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPInputBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLPInputBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPInputBox.Controls.Add(this.cBPlatFromage, 3, 3);
            this.tLPInputBox.Controls.Add(this.cBPlatAccompagnement, 3, 2);
            this.tLPInputBox.Controls.Add(this.cBPlatPrincipal, 3, 1);
            this.tLPInputBox.Controls.Add(this.cBPlatEntree, 3, 0);
            this.tLPInputBox.Controls.Add(this.lblPlat, 2, 1);
            this.tLPInputBox.Controls.Add(this.lblDessert, 2, 4);
            this.tLPInputBox.Controls.Add(this.lblFromage, 2, 3);
            this.tLPInputBox.Controls.Add(this.lblEntree, 2, 0);
            this.tLPInputBox.Controls.Add(this.lblAccompagnement, 2, 2);
            this.tLPInputBox.Controls.Add(this.dTPUpdateDate, 1, 1);
            this.tLPInputBox.Controls.Add(this.cBPlatDessert, 3, 4);
            this.tLPInputBox.Controls.Add(this.lblDateRepas, 0, 1);
            this.tLPInputBox.Controls.Add(this.lblMoment, 0, 3);
            this.tLPInputBox.Controls.Add(this.cBMoment, 1, 3);
            this.tLPInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPInputBox.Location = new System.Drawing.Point(3, 342);
            this.tLPInputBox.Name = "tLPInputBox";
            this.tLPInputBox.RowCount = 5;
            this.tLPInputBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPInputBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPInputBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPInputBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPInputBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLPInputBox.Size = new System.Drawing.Size(1030, 160);
            this.tLPInputBox.TabIndex = 3;
            // 
            // cBPlatFromage
            // 
            this.cBPlatFromage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBPlatFromage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBPlatFromage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBPlatFromage.FormattingEnabled = true;
            this.cBPlatFromage.Location = new System.Drawing.Point(653, 99);
            this.cBPlatFromage.Name = "cBPlatFromage";
            this.cBPlatFromage.Size = new System.Drawing.Size(374, 28);
            this.cBPlatFromage.TabIndex = 6;
            // 
            // cBPlatAccompagnement
            // 
            this.cBPlatAccompagnement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBPlatAccompagnement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBPlatAccompagnement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBPlatAccompagnement.FormattingEnabled = true;
            this.cBPlatAccompagnement.Location = new System.Drawing.Point(653, 67);
            this.cBPlatAccompagnement.Name = "cBPlatAccompagnement";
            this.cBPlatAccompagnement.Size = new System.Drawing.Size(374, 28);
            this.cBPlatAccompagnement.TabIndex = 5;
            // 
            // cBPlatPrincipal
            // 
            this.cBPlatPrincipal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBPlatPrincipal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBPlatPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBPlatPrincipal.FormattingEnabled = true;
            this.cBPlatPrincipal.Location = new System.Drawing.Point(653, 35);
            this.cBPlatPrincipal.Name = "cBPlatPrincipal";
            this.cBPlatPrincipal.Size = new System.Drawing.Size(374, 28);
            this.cBPlatPrincipal.TabIndex = 4;
            // 
            // cBPlatEntree
            // 
            this.cBPlatEntree.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBPlatEntree.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBPlatEntree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBPlatEntree.FormattingEnabled = true;
            this.cBPlatEntree.Location = new System.Drawing.Point(653, 3);
            this.cBPlatEntree.Name = "cBPlatEntree";
            this.cBPlatEntree.Size = new System.Drawing.Size(374, 28);
            this.cBPlatEntree.TabIndex = 3;
            // 
            // lblPlat
            // 
            this.lblPlat.AutoSize = true;
            this.lblPlat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlat.Location = new System.Drawing.Point(504, 32);
            this.lblPlat.Name = "lblPlat";
            this.lblPlat.Size = new System.Drawing.Size(143, 32);
            this.lblPlat.TabIndex = 6;
            this.lblPlat.Text = "Plat";
            this.lblPlat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDessert
            // 
            this.lblDessert.AutoSize = true;
            this.lblDessert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDessert.Location = new System.Drawing.Point(504, 128);
            this.lblDessert.Name = "lblDessert";
            this.lblDessert.Size = new System.Drawing.Size(143, 32);
            this.lblDessert.TabIndex = 5;
            this.lblDessert.Text = "Dessert";
            this.lblDessert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFromage
            // 
            this.lblFromage.AutoSize = true;
            this.lblFromage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFromage.Location = new System.Drawing.Point(504, 96);
            this.lblFromage.Name = "lblFromage";
            this.lblFromage.Size = new System.Drawing.Size(143, 32);
            this.lblFromage.TabIndex = 4;
            this.lblFromage.Text = "Fromage";
            this.lblFromage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEntree
            // 
            this.lblEntree.AutoSize = true;
            this.lblEntree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntree.Location = new System.Drawing.Point(504, 0);
            this.lblEntree.Name = "lblEntree";
            this.lblEntree.Size = new System.Drawing.Size(143, 32);
            this.lblEntree.TabIndex = 3;
            this.lblEntree.Text = "Entrée";
            this.lblEntree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccompagnement
            // 
            this.lblAccompagnement.AutoSize = true;
            this.lblAccompagnement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccompagnement.Location = new System.Drawing.Point(504, 64);
            this.lblAccompagnement.Name = "lblAccompagnement";
            this.lblAccompagnement.Size = new System.Drawing.Size(143, 32);
            this.lblAccompagnement.TabIndex = 2;
            this.lblAccompagnement.Text = "Accompagnement";
            this.lblAccompagnement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dTPUpdateDate
            // 
            this.dTPUpdateDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dTPUpdateDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vaffichermenuBindingSource, "RepasDate", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dTPUpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPUpdateDate.Location = new System.Drawing.Point(124, 35);
            this.dTPUpdateDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dTPUpdateDate.Name = "dTPUpdateDate";
            this.dTPUpdateDate.Size = new System.Drawing.Size(268, 26);
            this.dTPUpdateDate.TabIndex = 1;
            this.dTPUpdateDate.ValueChanged += new System.EventHandler(this.DTPUpdateDate_ValueChanged);
            // 
            // cBPlatDessert
            // 
            this.cBPlatDessert.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBPlatDessert.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBPlatDessert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBPlatDessert.FormattingEnabled = true;
            this.cBPlatDessert.Location = new System.Drawing.Point(653, 131);
            this.cBPlatDessert.Name = "cBPlatDessert";
            this.cBPlatDessert.Size = new System.Drawing.Size(374, 28);
            this.cBPlatDessert.TabIndex = 7;
            // 
            // lblDateRepas
            // 
            this.lblDateRepas.AutoSize = true;
            this.lblDateRepas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateRepas.Location = new System.Drawing.Point(3, 32);
            this.lblDateRepas.Name = "lblDateRepas";
            this.lblDateRepas.Size = new System.Drawing.Size(115, 32);
            this.lblDateRepas.TabIndex = 0;
            this.lblDateRepas.Text = "Date du repas";
            this.lblDateRepas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMoment
            // 
            this.lblMoment.AutoSize = true;
            this.lblMoment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMoment.Location = new System.Drawing.Point(3, 96);
            this.lblMoment.Name = "lblMoment";
            this.lblMoment.Size = new System.Drawing.Size(115, 32);
            this.lblMoment.TabIndex = 1;
            this.lblMoment.Text = "Moment";
            this.lblMoment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cBMoment
            // 
            this.cBMoment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBMoment.DisplayMember = "Nom";
            this.cBMoment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMoment.FormattingEnabled = true;
            this.cBMoment.Location = new System.Drawing.Point(124, 99);
            this.cBMoment.Name = "cBMoment";
            this.cBMoment.Size = new System.Drawing.Size(268, 28);
            this.cBMoment.TabIndex = 2;
            this.cBMoment.ValueMember = "Id_Nom";
            // 
            // tLPDateSemaine
            // 
            this.tLPDateSemaine.AutoSize = true;
            this.tLPDateSemaine.ColumnCount = 4;
            this.tLPDateSemaine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLPDateSemaine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLPDateSemaine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPDateSemaine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tLPDateSemaine.Controls.Add(this.dTPWeek, 0, 0);
            this.tLPDateSemaine.Controls.Add(this.lblSemaine, 2, 0);
            this.tLPDateSemaine.Controls.Add(this.btBefore, 1, 0);
            this.tLPDateSemaine.Controls.Add(this.btAfter, 3, 0);
            this.tLPDateSemaine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPDateSemaine.Location = new System.Drawing.Point(3, 3);
            this.tLPDateSemaine.Name = "tLPDateSemaine";
            this.tLPDateSemaine.RowCount = 1;
            this.tLPDateSemaine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPDateSemaine.Size = new System.Drawing.Size(1030, 54);
            this.tLPDateSemaine.TabIndex = 101;
            // 
            // dTPWeek
            // 
            this.dTPWeek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dTPWeek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPWeek.Location = new System.Drawing.Point(3, 14);
            this.dTPWeek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPWeek.Name = "dTPWeek";
            this.dTPWeek.Size = new System.Drawing.Size(285, 26);
            this.dTPWeek.TabIndex = 0;
            this.dTPWeek.TabStop = false;
            this.dTPWeek.Value = new System.DateTime(2021, 12, 5, 9, 10, 2, 0);
            this.dTPWeek.ValueChanged += new System.EventHandler(this.DTPMain_ValueChanged);
            // 
            // lblSemaine
            // 
            this.lblSemaine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSemaine.AutoSize = true;
            this.lblSemaine.Font = new System.Drawing.Font("Britannic Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemaine.Location = new System.Drawing.Point(442, 13);
            this.lblSemaine.Name = "lblSemaine";
            this.lblSemaine.Size = new System.Drawing.Size(460, 27);
            this.lblSemaine.TabIndex = 1;
            this.lblSemaine.Text = "Semaine du 29 novembre au 5 decembre";
            // 
            // btBefore
            // 
            this.btBefore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btBefore.Location = new System.Drawing.Point(308, 7);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(80, 40);
            this.btBefore.TabIndex = 2;
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.BtBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAfter.Location = new System.Drawing.Point(957, 7);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(70, 40);
            this.btAfter.TabIndex = 3;
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.BtAfter_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.fLPButtons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btQuitter, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 508);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1030, 70);
            this.tableLayoutPanel1.TabIndex = 102;
            // 
            // fLPButtons
            // 
            this.fLPButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fLPButtons.AutoSize = true;
            this.fLPButtons.BackColor = System.Drawing.SystemColors.Control;
            this.fLPButtons.Controls.Add(this.btActualiser);
            this.fLPButtons.Controls.Add(this.btAjouter);
            this.fLPButtons.Controls.Add(this.btModifier);
            this.fLPButtons.Controls.Add(this.btSupprimer);
            this.fLPButtons.Location = new System.Drawing.Point(299, 3);
            this.fLPButtons.Name = "fLPButtons";
            this.fLPButtons.Size = new System.Drawing.Size(576, 64);
            this.fLPButtons.TabIndex = 3;
            // 
            // btActualiser
            // 
            this.btActualiser.Location = new System.Drawing.Point(3, 3);
            this.btActualiser.Name = "btActualiser";
            this.btActualiser.Size = new System.Drawing.Size(138, 61);
            this.btActualiser.TabIndex = 11;
            this.btActualiser.Text = "&Actualiser";
            this.btActualiser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btActualiser.UseVisualStyleBackColor = true;
            this.btActualiser.Click += new System.EventHandler(this.BtActualiser_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(147, 3);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(138, 61);
            this.btAjouter.TabIndex = 8;
            this.btAjouter.Text = "A&jouter";
            this.btAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.BtAjouter_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(291, 3);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(138, 61);
            this.btModifier.TabIndex = 9;
            this.btModifier.Text = "&Modifier";
            this.btModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.BtModifier_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(435, 3);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(138, 61);
            this.btSupprimer.TabIndex = 10;
            this.btSupprimer.Text = "&Supprimer";
            this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.BtSupprimer_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btQuitter.BackColor = System.Drawing.SystemColors.Control;
            this.btQuitter.Location = new System.Drawing.Point(3, 3);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(138, 64);
            this.btQuitter.TabIndex = 12;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // momentTableAdapter
            // 
            this.momentTableAdapter.ClearBeforeFill = true;
            // 
            // vplatsBindingSource
            // 
            this.vplatsBindingSource.DataMember = "v_plats";
            this.vplatsBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // v_platsTableAdapter
            // 
            this.v_platsTableAdapter.ClearBeforeFill = true;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // v_affichermenuTableAdapter
            // 
            this.v_affichermenuTableAdapter.ClearBeforeFill = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 581);
            this.Controls.Add(this.tLPMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1052, 620);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menus";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaffichermenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).EndInit();
            this.tLPMain.ResumeLayout(false);
            this.tLPMain.PerformLayout();
            this.tLPInputBox.ResumeLayout(false);
            this.tLPInputBox.PerformLayout();
            this.tLPDateSemaine.ResumeLayout(false);
            this.tLPDateSemaine.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.fLPButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vplatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMenu;
        private cda68_bd1DataSet cda68_bd1DataSet;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private System.Windows.Forms.DateTimePicker dTPWeek;
        private System.Windows.Forms.TableLayoutPanel tLPInputBox;
        private System.Windows.Forms.Label lblPlat;
        private System.Windows.Forms.Label lblDessert;
        private System.Windows.Forms.Label lblFromage;
        private System.Windows.Forms.Label lblEntree;
        private System.Windows.Forms.Label lblAccompagnement;
        private System.Windows.Forms.Label lblMoment;
        private System.Windows.Forms.Label lblDateRepas;
        private System.Windows.Forms.DateTimePicker dTPUpdateDate;
        private System.Windows.Forms.ComboBox cBPlatFromage;
        private System.Windows.Forms.ComboBox cBPlatAccompagnement;
        private System.Windows.Forms.ComboBox cBPlatPrincipal;
        private System.Windows.Forms.ComboBox cBPlatEntree;
        private System.Windows.Forms.ComboBox cBMoment;
        private System.Windows.Forms.ComboBox cBPlatDessert;
        private cda68_bd1DataSetTableAdapters.MomentTableAdapter momentTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tLPDateSemaine;
        private System.Windows.Forms.Label lblSemaine;
        private System.Windows.Forms.BindingSource vplatsBindingSource;
        private cda68_bd1DataSetTableAdapters.v_platsTableAdapter v_platsTableAdapter;
        private cda68_bd1DataSetTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.BindingSource vaffichermenuBindingSource;
        private cda68_bd1DataSetTableAdapters.v_affichermenuTableAdapter v_affichermenuTableAdapter;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn repasDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn momentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatEntreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatPrincipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatAccompagnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accompagnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatFromageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatDessertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dessertDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMomentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel fLPButtons;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btQuitter;
    }
}