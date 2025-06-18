namespace Interface
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnProducts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClients = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatories = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCashRegister = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProducts,
            this.toolStripSeparator1,
            this.btnClients,
            this.toolStripSeparator4,
            this.btnSales,
            this.toolStripSeparator3,
            this.btnRelatories,
            this.toolStripSeparator5,
            this.btnCashRegister});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(526, 63);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnProducts
            // 
            this.btnProducts.AutoSize = false;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = global::Interface.Properties.Resources.pill_35;
            this.btnProducts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(60, 60);
            this.btnProducts.Text = "Produtos";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // btnClients
            // 
            this.btnClients.AutoSize = false;
            this.btnClients.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.Image = global::Interface.Properties.Resources.clients_35;
            this.btnClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(60, 60);
            this.btnClients.Text = "Clientes";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 63);
            // 
            // btnSales
            // 
            this.btnSales.AutoSize = false;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = global::Interface.Properties.Resources.shopping_cart_35;
            this.btnSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(60, 60);
            this.btnSales.Text = "Vendas";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 63);
            // 
            // btnRelatories
            // 
            this.btnRelatories.AutoSize = false;
            this.btnRelatories.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatories.Image = global::Interface.Properties.Resources.relatories_35;
            this.btnRelatories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRelatories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatories.Name = "btnRelatories";
            this.btnRelatories.Size = new System.Drawing.Size(60, 60);
            this.btnRelatories.Text = "Relatórios";
            this.btnRelatories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 63);
            // 
            // btnCashRegister
            // 
            this.btnCashRegister.AutoSize = false;
            this.btnCashRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashRegister.Image = global::Interface.Properties.Resources.cash_register_35;
            this.btnCashRegister.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCashRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCashRegister.Name = "btnCashRegister";
            this.btnCashRegister.Size = new System.Drawing.Size(60, 60);
            this.btnCashRegister.Text = "Caixa";
            this.btnCashRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "RaruPharmacies";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCashRegister;
        private System.Windows.Forms.ToolStripButton btnProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClients;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRelatories;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

