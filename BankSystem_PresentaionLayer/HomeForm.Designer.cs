namespace BankSystem_PresentaionLayer
{
    partial class frmHome
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCurrencyExchange = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(12, 359);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(121, 30);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCurrencyExchange.FlatAppearance.BorderSize = 0;
            this.btnCurrencyExchange.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCurrencyExchange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencyExchange.Location = new System.Drawing.Point(12, 300);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.Size = new System.Drawing.Size(121, 30);
            this.btnCurrencyExchange.TabIndex = 11;
            this.btnCurrencyExchange.Tag = "8";
            this.btnCurrencyExchange.Text = "CurrencyExchange";
            this.btnCurrencyExchange.UseVisualStyleBackColor = false;
            this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTransactions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.Location = new System.Drawing.Point(12, 241);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(121, 30);
            this.btnTransactions.TabIndex = 10;
            this.btnTransactions.Tag = "4";
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(12, 182);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(121, 30);
            this.btnManageUsers.TabIndex = 9;
            this.btnManageUsers.Tag = "2";
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageClients.FlatAppearance.BorderSize = 0;
            this.btnManageClients.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnManageClients.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.Location = new System.Drawing.Point(12, 123);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(121, 30);
            this.btnManageClients.TabIndex = 8;
            this.btnManageClients.Tag = "1";
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.UseVisualStyleBackColor = false;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.Enabled = false;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(12, 67);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(121, 30);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCurrencyExchange);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnManageClients);
            this.Controls.Add(this.btnHome);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCurrencyExchange;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Button btnHome;
    }
}

