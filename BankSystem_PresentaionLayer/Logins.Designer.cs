namespace BankSystem_PresentaionLayer
{
    partial class frmLogins
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
            this.dgvLogins = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLoginDate = new System.Windows.Forms.DateTimePicker();
            this.lbLoginsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogins
            // 
            this.dgvLogins.AllowUserToAddRows = false;
            this.dgvLogins.AllowUserToDeleteRows = false;
            this.dgvLogins.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogins.Location = new System.Drawing.Point(102, 97);
            this.dgvLogins.Name = "dgvLogins";
            this.dgvLogins.ReadOnly = true;
            this.dgvLogins.Size = new System.Drawing.Size(601, 310);
            this.dgvLogins.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Date to search for";
            // 
            // dtpLoginDate
            // 
            this.dtpLoginDate.Location = new System.Drawing.Point(288, 55);
            this.dtpLoginDate.Name = "dtpLoginDate";
            this.dtpLoginDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLoginDate.TabIndex = 3;
            this.dtpLoginDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbLoginsCount
            // 
            this.lbLoginsCount.AutoSize = true;
            this.lbLoginsCount.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginsCount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginsCount.Location = new System.Drawing.Point(638, 55);
            this.lbLoginsCount.Name = "lbLoginsCount";
            this.lbLoginsCount.Size = new System.Drawing.Size(41, 13);
            this.lbLoginsCount.TabIndex = 13;
            this.lbLoginsCount.Text = "label2";
            // 
            // frmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLoginsCount);
            this.Controls.Add(this.dtpLoginDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLogins);
            this.Name = "frmLogins";
            this.Text = "frmLogins";
            this.Load += new System.EventHandler(this.frmLogins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpLoginDate;
        private System.Windows.Forms.Label lbLoginsCount;
    }
}