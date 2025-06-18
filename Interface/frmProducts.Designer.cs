namespace Interface
{
    partial class frmProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCategories = new System.Windows.Forms.ToolStripButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBarcode = new System.Windows.Forms.RadioButton();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numCurrent = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgRegisterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgStockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgStockCurrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(244, 68);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(145, 20);
            this.txtBarcode.TabIndex = 36;
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgId,
            this.dtgBarcode,
            this.dtgName,
            this.dtgDetails,
            this.dtgRegisterDate,
            this.dtgStockMin,
            this.dtgStockCurrent,
            this.dtgCost,
            this.dtgSale,
            this.dtgCategory,
            this.categoryId,
            this.dtgEdit,
            this.dtgDelete});
            this.dtgProducts.Location = new System.Drawing.Point(13, 234);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersVisible = false;
            this.dtgProducts.Size = new System.Drawing.Size(683, 196);
            this.dtgProducts.TabIndex = 55;
            this.dtgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducts_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(420, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Data de cadastro";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Enabled = false;
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(520, 70);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(100, 20);
            this.dtpRegistrationDate.TabIndex = 53;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(71, 71);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 52;
            this.txtId.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Código:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSale);
            this.groupBox3.Controls.Add(this.txtCost);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(278, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 99);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valor unitário";
            // 
            // txtSale
            // 
            this.txtSale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSale.Location = new System.Drawing.Point(56, 60);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(69, 22);
            this.txtSale.TabIndex = 21;
            this.txtSale.Text = "0";
            this.txtSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(56, 22);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(69, 22);
            this.txtCost.TabIndex = 20;
            this.txtCost.Text = "0";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Custo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Venda:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(139, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Código de barras:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.toolStripSeparator4,
            this.btnCategories});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 53);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Interface.Properties.Resources.pill_35;
            this.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 50);
            this.btnNew.Text = "Novo";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::Interface.Properties.Resources.clients_35;
            this.btnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.Text = "Salvar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 53);
            // 
            // btnCategories
            // 
            this.btnCategories.AutoSize = false;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Image = global::Interface.Properties.Resources.clients_35;
            this.btnCategories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(60, 50);
            this.btnCategories.Text = "Categorias";
            this.btnCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 20);
            this.txtName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mínimo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Atual:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBarcode);
            this.groupBox1.Controls.Add(this.rbCategory);
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(420, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 99);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // rbBarcode
            // 
            this.rbBarcode.AutoSize = true;
            this.rbBarcode.Location = new System.Drawing.Point(153, 63);
            this.rbBarcode.Name = "rbBarcode";
            this.rbBarcode.Size = new System.Drawing.Size(114, 17);
            this.rbBarcode.TabIndex = 16;
            this.rbBarcode.Text = "Código de barras";
            this.rbBarcode.UseVisualStyleBackColor = true;
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(72, 63);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(75, 17);
            this.rbCategory.TabIndex = 15;
            this.rbCategory.Text = "Categoria";
            this.rbCategory.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(9, 63);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(57, 17);
            this.rbName.TabIndex = 14;
            this.rbName.TabStop = true;
            this.rbName.Text = "Nome";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(13, 143);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(109, 77);
            this.txtDetails.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Detalhes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numCurrent);
            this.groupBox2.Controls.Add(this.numMin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(142, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 99);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estoque";
            // 
            // numCurrent
            // 
            this.numCurrent.Location = new System.Drawing.Point(61, 60);
            this.numCurrent.Name = "numCurrent";
            this.numCurrent.Size = new System.Drawing.Size(56, 22);
            this.numCurrent.TabIndex = 21;
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(61, 26);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(56, 22);
            this.numMin.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Categoria:";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Window;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(487, 98);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(133, 21);
            this.cbCategory.TabIndex = 58;
            // 
            // dtgId
            // 
            this.dtgId.DataPropertyName = "id";
            this.dtgId.HeaderText = "ID";
            this.dtgId.Name = "dtgId";
            this.dtgId.ReadOnly = true;
            this.dtgId.Visible = false;
            // 
            // dtgBarcode
            // 
            this.dtgBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dtgBarcode.DataPropertyName = "barcode";
            this.dtgBarcode.FillWeight = 48.28601F;
            this.dtgBarcode.HeaderText = "Cód. Barras";
            this.dtgBarcode.Name = "dtgBarcode";
            this.dtgBarcode.ReadOnly = true;
            // 
            // dtgName
            // 
            this.dtgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dtgName.DataPropertyName = "name";
            this.dtgName.FillWeight = 166.5035F;
            this.dtgName.HeaderText = "Nome";
            this.dtgName.Name = "dtgName";
            this.dtgName.ReadOnly = true;
            this.dtgName.Width = 150;
            // 
            // dtgDetails
            // 
            this.dtgDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dtgDetails.DataPropertyName = "details";
            this.dtgDetails.FillWeight = 48.28601F;
            this.dtgDetails.HeaderText = "Detalhes";
            this.dtgDetails.Name = "dtgDetails";
            this.dtgDetails.ReadOnly = true;
            // 
            // dtgRegisterDate
            // 
            this.dtgRegisterDate.DataPropertyName = "registerDate";
            this.dtgRegisterDate.HeaderText = "Data de Registro";
            this.dtgRegisterDate.Name = "dtgRegisterDate";
            this.dtgRegisterDate.ReadOnly = true;
            this.dtgRegisterDate.Visible = false;
            // 
            // dtgStockMin
            // 
            this.dtgStockMin.DataPropertyName = "stockMin";
            this.dtgStockMin.FillWeight = 48.28601F;
            this.dtgStockMin.HeaderText = "Estoque Mín.";
            this.dtgStockMin.Name = "dtgStockMin";
            this.dtgStockMin.ReadOnly = true;
            this.dtgStockMin.Visible = false;
            // 
            // dtgStockCurrent
            // 
            this.dtgStockCurrent.DataPropertyName = "stockCurrent";
            this.dtgStockCurrent.FillWeight = 48.28601F;
            this.dtgStockCurrent.HeaderText = "Estoque";
            this.dtgStockCurrent.Name = "dtgStockCurrent";
            this.dtgStockCurrent.ReadOnly = true;
            // 
            // dtgCost
            // 
            this.dtgCost.DataPropertyName = "cost";
            this.dtgCost.FillWeight = 48.28601F;
            this.dtgCost.HeaderText = "Custo";
            this.dtgCost.Name = "dtgCost";
            this.dtgCost.ReadOnly = true;
            this.dtgCost.Visible = false;
            // 
            // dtgSale
            // 
            this.dtgSale.DataPropertyName = "sale";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dtgSale.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSale.HeaderText = "Venda";
            this.dtgSale.Name = "dtgSale";
            this.dtgSale.ReadOnly = true;
            // 
            // dtgCategory
            // 
            this.dtgCategory.DataPropertyName = "categoryName";
            this.dtgCategory.HeaderText = "Categoria";
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.ReadOnly = true;
            // 
            // categoryId
            // 
            this.categoryId.DataPropertyName = "categoryId";
            this.categoryId.HeaderText = "ID Categoria";
            this.categoryId.Name = "categoryId";
            this.categoryId.ReadOnly = true;
            this.categoryId.Visible = false;
            // 
            // dtgEdit
            // 
            this.dtgEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dtgEdit.HeaderText = "";
            this.dtgEdit.Image = global::Interface.Properties.Resources.edit_20;
            this.dtgEdit.Name = "dtgEdit";
            this.dtgEdit.ReadOnly = true;
            this.dtgEdit.Width = 30;
            // 
            // dtgDelete
            // 
            this.dtgDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dtgDelete.FillWeight = 99.9021F;
            this.dtgDelete.HeaderText = "";
            this.dtgDelete.Image = global::Interface.Properties.Resources.delete_20;
            this.dtgDelete.Name = "dtgDelete";
            this.dtgDelete.ReadOnly = true;
            this.dtgDelete.Width = 30;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 442);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripButton btnCategories;
        private System.Windows.Forms.NumericUpDown numCurrent;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.RadioButton rbBarcode;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgRegisterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgStockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgStockCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryId;
        private System.Windows.Forms.DataGridViewImageColumn dtgEdit;
        private System.Windows.Forms.DataGridViewImageColumn dtgDelete;
    }
}