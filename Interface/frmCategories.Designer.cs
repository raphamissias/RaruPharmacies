namespace Interface
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgCategories = new System.Windows.Forms.DataGridView();
            this.dtgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategories)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(246, 67);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(186, 46);
            this.txtDetails.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Detalhes:";
            // 
            // dtgCategories
            // 
            this.dtgCategories.AllowUserToAddRows = false;
            this.dtgCategories.AllowUserToDeleteRows = false;
            this.dtgCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategories.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgId,
            this.dtgName,
            this.dtgDetails,
            this.dtgEdit,
            this.dtgDelete});
            this.dtgCategories.Location = new System.Drawing.Point(12, 126);
            this.dtgCategories.MultiSelect = false;
            this.dtgCategories.Name = "dtgCategories";
            this.dtgCategories.ReadOnly = true;
            this.dtgCategories.RowHeadersVisible = false;
            this.dtgCategories.Size = new System.Drawing.Size(420, 203);
            this.dtgCategories.TabIndex = 72;
            this.dtgCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategories_CellContentClick);
            // 
            // dtgId
            // 
            this.dtgId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dtgId.DataPropertyName = "id";
            this.dtgId.HeaderText = "Código";
            this.dtgId.Name = "dtgId";
            this.dtgId.ReadOnly = true;
            this.dtgId.Width = 50;
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
            this.dtgDetails.HeaderText = "Descrição";
            this.dtgDetails.Name = "dtgDetails";
            this.dtgDetails.ReadOnly = true;
            this.dtgDetails.Width = 150;
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
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(64, 66);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtId.Size = new System.Drawing.Size(43, 20);
            this.txtId.TabIndex = 69;
            this.txtId.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Código:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 53);
            this.toolStrip1.TabIndex = 60;
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
            this.btnNew.Size = new System.Drawing.Size(60, 50);
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
            this.btnSave.Size = new System.Drawing.Size(60, 50);
            this.btnSave.Text = "Salvar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nome:";
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 341);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgCategories);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategories)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgCategories;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgDetails;
        private System.Windows.Forms.DataGridViewImageColumn dtgEdit;
        private System.Windows.Forms.DataGridViewImageColumn dtgDelete;
    }
}