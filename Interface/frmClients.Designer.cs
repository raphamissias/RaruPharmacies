namespace Interface
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNeighborhood = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.dtgClients = new System.Windows.Forms.DataGridView();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgNeighborhood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgRegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgOberservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(689, 53);
            this.toolStrip1.TabIndex = 1;
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(89, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 141);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Endereço:";
            // 
            // txtNeighborhood
            // 
            this.txtNeighborhood.Location = new System.Drawing.Point(91, 168);
            this.txtNeighborhood.Name = "txtNeighborhood";
            this.txtNeighborhood.Size = new System.Drawing.Size(207, 20);
            this.txtNeighborhood.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(91, 195);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(207, 20);
            this.txtCity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "RG:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(9, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 22);
            this.txtSearch.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCpf);
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(314, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 87);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Location = new System.Drawing.Point(72, 61);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(45, 17);
            this.rbCpf.TabIndex = 15;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Checked = true;
            this.rbName.Location = new System.Drawing.Point(9, 61);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(57, 17);
            this.rbName.TabIndex = 14;
            this.rbName.TabStop = true;
            this.rbName.Text = "Nome";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(91, 222);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(101, 20);
            this.dtpBirthdate.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nascimento:";
            // 
            // txtObservation
            // 
            this.txtObservation.Location = new System.Drawing.Point(91, 248);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(207, 64);
            this.txtObservation.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Observações:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRg);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(314, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 99);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documentos";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(42, 58);
            this.txtRg.Mask = "00\\.000\\.000-0";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(75, 22);
            this.txtRg.TabIndex = 8;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(42, 26);
            this.txtCpf.Mask = "000\\.000\\.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(75, 22);
            this.txtCpf.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtCellphone);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(450, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 99);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(80, 14);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Email:";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellphone.Location = new System.Drawing.Point(80, 70);
            this.txtCellphone.Mask = "(00)00000-0000";
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(135, 22);
            this.txtCellphone.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(80, 42);
            this.txtPhone.Mask = "(00)00000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Residencial:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Celular:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(91, 63);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(36, 20);
            this.txtID.TabIndex = 28;
            this.txtID.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Código:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(314, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Data de cadastro";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.Enabled = false;
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(414, 63);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(90, 20);
            this.dtpRegistrationDate.TabIndex = 29;
            // 
            // dtgClients
            // 
            this.dtgClients.AllowUserToAddRows = false;
            this.dtgClients.AllowUserToDeleteRows = false;
            this.dtgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgClients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgId,
            this.dtgName,
            this.dtgLastName,
            this.dtgAddress,
            this.dtgNeighborhood,
            this.dtgCellphone,
            this.dtgPhone,
            this.dtgEmail,
            this.dtgRegistrationDate,
            this.dtgRg,
            this.dtgCity,
            this.dtgCpf,
            this.dtgBirthdate,
            this.dtgOberservation});
            this.dtgClients.Location = new System.Drawing.Point(13, 329);
            this.dtgClients.MultiSelect = false;
            this.dtgClients.Name = "dtgClients";
            this.dtgClients.ReadOnly = true;
            this.dtgClients.RowHeadersVisible = false;
            this.dtgClients.Size = new System.Drawing.Size(663, 170);
            this.dtgClients.TabIndex = 31;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(91, 116);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(207, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Sobrenome:";
            // 
            // dtgId
            // 
            this.dtgId.DataPropertyName = "id";
            this.dtgId.HeaderText = "ID";
            this.dtgId.Name = "dtgId";
            this.dtgId.ReadOnly = true;
            this.dtgId.Visible = false;
            // 
            // dtgName
            // 
            this.dtgName.DataPropertyName = "first_name";
            this.dtgName.HeaderText = "Nome";
            this.dtgName.Name = "dtgName";
            this.dtgName.ReadOnly = true;
            // 
            // dtgLastName
            // 
            this.dtgLastName.DataPropertyName = "last_name";
            this.dtgLastName.HeaderText = "Sobrenome";
            this.dtgLastName.Name = "dtgLastName";
            this.dtgLastName.ReadOnly = true;
            // 
            // dtgAddress
            // 
            this.dtgAddress.DataPropertyName = "address";
            this.dtgAddress.HeaderText = "Endereço";
            this.dtgAddress.Name = "dtgAddress";
            this.dtgAddress.ReadOnly = true;
            // 
            // dtgNeighborhood
            // 
            this.dtgNeighborhood.DataPropertyName = "neighborhood";
            this.dtgNeighborhood.HeaderText = "Bairro";
            this.dtgNeighborhood.Name = "dtgNeighborhood";
            this.dtgNeighborhood.ReadOnly = true;
            this.dtgNeighborhood.Visible = false;
            // 
            // dtgCellphone
            // 
            this.dtgCellphone.DataPropertyName = "cellphone";
            this.dtgCellphone.HeaderText = "Celular";
            this.dtgCellphone.Name = "dtgCellphone";
            this.dtgCellphone.ReadOnly = true;
            // 
            // dtgPhone
            // 
            this.dtgPhone.DataPropertyName = "phone";
            this.dtgPhone.HeaderText = "Telefone";
            this.dtgPhone.Name = "dtgPhone";
            this.dtgPhone.ReadOnly = true;
            // 
            // dtgEmail
            // 
            this.dtgEmail.DataPropertyName = "email";
            this.dtgEmail.HeaderText = "E-mail";
            this.dtgEmail.Name = "dtgEmail";
            this.dtgEmail.ReadOnly = true;
            // 
            // dtgRegistrationDate
            // 
            this.dtgRegistrationDate.DataPropertyName = "registrationDate";
            this.dtgRegistrationDate.HeaderText = "Data de Cadastro";
            this.dtgRegistrationDate.Name = "dtgRegistrationDate";
            this.dtgRegistrationDate.ReadOnly = true;
            this.dtgRegistrationDate.Visible = false;
            // 
            // dtgRg
            // 
            this.dtgRg.DataPropertyName = "rg";
            this.dtgRg.HeaderText = "RG";
            this.dtgRg.Name = "dtgRg";
            this.dtgRg.ReadOnly = true;
            this.dtgRg.Visible = false;
            // 
            // dtgCity
            // 
            this.dtgCity.DataPropertyName = "city";
            this.dtgCity.HeaderText = "Cidade";
            this.dtgCity.Name = "dtgCity";
            this.dtgCity.ReadOnly = true;
            this.dtgCity.Visible = false;
            // 
            // dtgCpf
            // 
            this.dtgCpf.DataPropertyName = "cpf";
            this.dtgCpf.HeaderText = "CPF";
            this.dtgCpf.Name = "dtgCpf";
            this.dtgCpf.ReadOnly = true;
            this.dtgCpf.Visible = false;
            // 
            // dtgBirthdate
            // 
            this.dtgBirthdate.DataPropertyName = "birthdate";
            this.dtgBirthdate.HeaderText = "Data de Nascimento";
            this.dtgBirthdate.Name = "dtgBirthdate";
            this.dtgBirthdate.ReadOnly = true;
            this.dtgBirthdate.Visible = false;
            // 
            // dtgOberservation
            // 
            this.dtgOberservation.DataPropertyName = "observation";
            this.dtgOberservation.HeaderText = "Observação";
            this.dtgOberservation.Name = "dtgOberservation";
            this.dtgOberservation.ReadOnly = true;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(689, 511);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dtgClients);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtObservation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNeighborhood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClients";
            this.Text = "Clientes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNeighborhood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpRegistrationDate;
        private System.Windows.Forms.DataGridView dtgClients;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtCellphone;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgNeighborhood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgRegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgOberservation;
    }
}