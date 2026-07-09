namespace BankSystem_PresentaionLayer
{
    partial class frmTransactionLogs
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
            this.dgvTransactionLogs = new System.Windows.Forms.DataGridView();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactionLogs
            // 
            this.dgvTransactionLogs.AllowUserToAddRows = false;
            this.dgvTransactionLogs.AllowUserToDeleteRows = false;
            this.dgvTransactionLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionLogs.Location = new System.Drawing.Point(77, 86);
            this.dgvTransactionLogs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTransactionLogs.Name = "dgvTransactionLogs";
            this.dgvTransactionLogs.ReadOnly = true;
            this.dgvTransactionLogs.Size = new System.Drawing.Size(579, 311);
            this.dgvTransactionLogs.TabIndex = 0;
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Location = new System.Drawing.Point(245, 54);
            this.dtpTransactionDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(233, 21);
            this.dtpTransactionDate.TabIndex = 1;
            this.dtpTransactionDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(74, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Transaction By Date";
            // 
            // frmTransactionLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.dgvTransactionLogs);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTransactionLogs";
            this.Text = "ShowTransactionLogs";
            this.Load += new System.EventHandler(this.frmTransactionLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionLogs;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.Label label1;
    }
}