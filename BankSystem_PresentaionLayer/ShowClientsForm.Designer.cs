namespace BankSystem_PresentaionLayer
{
    partial class frmShowClients
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
            this.dgvShowClients = new System.Windows.Forms.DataGridView();
            this.cmsManageClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmDeleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFindClients = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClientsNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClients)).BeginInit();
            this.cmsManageClients.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowClients
            // 
            this.dgvShowClients.AllowUserToAddRows = false;
            this.dgvShowClients.AllowUserToDeleteRows = false;
            this.dgvShowClients.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvShowClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowClients.ContextMenuStrip = this.cmsManageClients;
            this.dgvShowClients.Location = new System.Drawing.Point(82, 123);
            this.dgvShowClients.Name = "dgvShowClients";
            this.dgvShowClients.ReadOnly = true;
            this.dgvShowClients.Size = new System.Drawing.Size(615, 315);
            this.dgvShowClients.TabIndex = 13;
            // 
            // cmsManageClients
            // 
            this.cmsManageClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeleteClient});
            this.cmsManageClients.Name = "cmsManageClients";
            this.cmsManageClients.Size = new System.Drawing.Size(142, 26);
            // 
            // tsmDeleteClient
            // 
            this.tsmDeleteClient.Name = "tsmDeleteClient";
            this.tsmDeleteClient.Size = new System.Drawing.Size(141, 22);
            this.tsmDeleteClient.Text = "Delete Client";
            this.tsmDeleteClient.Click += new System.EventHandler(this.tsmDeleteClient_Click);
            // 
            // txtFindClients
            // 
            this.txtFindClients.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFindClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFindClients.ForeColor = System.Drawing.Color.Black;
            this.txtFindClients.Location = new System.Drawing.Point(82, 87);
            this.txtFindClients.Multiline = true;
            this.txtFindClients.Name = "txtFindClients";
            this.txtFindClients.Size = new System.Drawing.Size(167, 20);
            this.txtFindClients.TabIndex = 14;
            this.txtFindClients.TextChanged += new System.EventHandler(this.txtFindClients_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search for a client by Acc.Number";
            // 
            // lbClientsNumber
            // 
            this.lbClientsNumber.AutoSize = true;
            this.lbClientsNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbClientsNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientsNumber.ForeColor = System.Drawing.Color.Black;
            this.lbClientsNumber.Location = new System.Drawing.Point(626, 87);
            this.lbClientsNumber.Name = "lbClientsNumber";
            this.lbClientsNumber.Size = new System.Drawing.Size(45, 13);
            this.lbClientsNumber.TabIndex = 17;
            this.lbClientsNumber.Text = "Clients";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.showClientsListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // showClientsListToolStripMenuItem
            // 
            this.showClientsListToolStripMenuItem.Name = "showClientsListToolStripMenuItem";
            this.showClientsListToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.showClientsListToolStripMenuItem.Text = "Show Clients List";
            this.showClientsListToolStripMenuItem.Click += new System.EventHandler(this.showClientsListToolStripMenuItem_Click);
            // 
            // frmShowClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbClientsNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindClients);
            this.Controls.Add(this.dgvShowClients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmShowClients";
            this.Text = "frmShowClient";
            this.Load += new System.EventHandler(this.frmShowClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowClients)).EndInit();
            this.cmsManageClients.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowClients;
        private System.Windows.Forms.TextBox txtFindClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClientsNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsManageClients;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteClient;
        private System.Windows.Forms.ToolStripMenuItem showClientsListToolStripMenuItem;
    }
}