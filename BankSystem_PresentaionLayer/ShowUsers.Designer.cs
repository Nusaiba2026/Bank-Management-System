namespace BankSystem_PresentaionLayer
{
    partial class frmShowUsers
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
            this.dgvShowUsers = new System.Windows.Forms.DataGridView();
            this.txtFindUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUserCount = new System.Windows.Forms.Label();
            this.showUsersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowUsers
            // 
            this.dgvShowUsers.AllowUserToAddRows = false;
            this.dgvShowUsers.AllowUserToDeleteRows = false;
            this.dgvShowUsers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUsers.Location = new System.Drawing.Point(105, 116);
            this.dgvShowUsers.Name = "dgvShowUsers";
            this.dgvShowUsers.ReadOnly = true;
            this.dgvShowUsers.Size = new System.Drawing.Size(571, 286);
            this.dgvShowUsers.TabIndex = 13;
            // 
            // txtFindUser
            // 
            this.txtFindUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFindUser.Location = new System.Drawing.Point(257, 73);
            this.txtFindUser.Name = "txtFindUser";
            this.txtFindUser.Size = new System.Drawing.Size(171, 20);
            this.txtFindUser.TabIndex = 14;
            this.txtFindUser.TextChanged += new System.EventHandler(this.txtFindUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Find User by User Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.loginsToolStripMenuItem,
            this.showUsersListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // loginsToolStripMenuItem
            // 
            this.loginsToolStripMenuItem.Name = "loginsToolStripMenuItem";
            this.loginsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.loginsToolStripMenuItem.Text = "Logins";
            this.loginsToolStripMenuItem.Click += new System.EventHandler(this.loginsToolStripMenuItem_Click);
            // 
            // lbUserCount
            // 
            this.lbUserCount.AutoSize = true;
            this.lbUserCount.BackColor = System.Drawing.Color.Transparent;
            this.lbUserCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserCount.Location = new System.Drawing.Point(626, 73);
            this.lbUserCount.Name = "lbUserCount";
            this.lbUserCount.Size = new System.Drawing.Size(39, 13);
            this.lbUserCount.TabIndex = 17;
            this.lbUserCount.Text = "Users";
            // 
            // showUsersListToolStripMenuItem
            // 
            this.showUsersListToolStripMenuItem.Name = "showUsersListToolStripMenuItem";
            this.showUsersListToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.showUsersListToolStripMenuItem.Text = "Show Users List";
            // 
            // frmShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbUserCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindUser);
            this.Controls.Add(this.dgvShowUsers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmShowUsers";
            this.Text = "frmShowUsers";
            this.Load += new System.EventHandler(this.frmShowUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowUsers;
        private System.Windows.Forms.TextBox txtFindUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.Label lbUserCount;
        private System.Windows.Forms.ToolStripMenuItem loginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUsersListToolStripMenuItem;
    }
}