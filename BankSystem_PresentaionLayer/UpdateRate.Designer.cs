namespace BankSystem_PresentaionLayer
{
    partial class frmUpdateRate
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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCurrencyCode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbCurrencyName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNewRate = new System.Windows.Forms.Button();
            this.txtNewRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(218, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Currency Code:";
            // 
            // cmbCurrencyCode
            // 
            this.cmbCurrencyCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbCurrencyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencyCode.FormattingEnabled = true;
            this.cmbCurrencyCode.Location = new System.Drawing.Point(353, 66);
            this.cmbCurrencyCode.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbCurrencyCode.Name = "cmbCurrencyCode";
            this.cmbCurrencyCode.Size = new System.Drawing.Size(202, 21);
            this.cmbCurrencyCode.TabIndex = 14;
            this.cmbCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cmbCurrencyCode_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbRate);
            this.groupBox1.Controls.Add(this.lbCode);
            this.groupBox1.Controls.Add(this.lbCurrencyName);
            this.groupBox1.Controls.Add(this.lbCountry);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(222, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(328, 252);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency  Card:";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(121, 214);
            this.lbRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(0, 13);
            this.lbRate.TabIndex = 7;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(121, 156);
            this.lbCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 13);
            this.lbCode.TabIndex = 6;
            // 
            // lbCurrencyName
            // 
            this.lbCurrencyName.AutoSize = true;
            this.lbCurrencyName.Location = new System.Drawing.Point(121, 98);
            this.lbCurrencyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrencyName.Name = "lbCurrencyName";
            this.lbCurrencyName.Size = new System.Drawing.Size(0, 13);
            this.lbCurrencyName.TabIndex = 5;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(121, 40);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(0, 13);
            this.lbCountry.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate(1$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Currency Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Name:";
            // 
            // btnSaveNewRate
            // 
            this.btnSaveNewRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveNewRate.Location = new System.Drawing.Point(644, 312);
            this.btnSaveNewRate.Name = "btnSaveNewRate";
            this.btnSaveNewRate.Size = new System.Drawing.Size(103, 35);
            this.btnSaveNewRate.TabIndex = 16;
            this.btnSaveNewRate.Text = "Save New Rate";
            this.btnSaveNewRate.UseVisualStyleBackColor = false;
            this.btnSaveNewRate.Click += new System.EventHandler(this.btnSaveNewRate_Click);
            // 
            // txtNewRate
            // 
            this.txtNewRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNewRate.Location = new System.Drawing.Point(619, 182);
            this.txtNewRate.Name = "txtNewRate";
            this.txtNewRate.Size = new System.Drawing.Size(155, 21);
            this.txtNewRate.TabIndex = 17;
            this.txtNewRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewRate_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(616, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Enter New Rate:";
            // 
            // frmUpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNewRate);
            this.Controls.Add(this.btnSaveNewRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCurrencyCode);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmUpdateRate";
            this.Text = "UpdateRate";
            this.Load += new System.EventHandler(this.frmUpdateRate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCurrencyCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbCurrencyName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNewRate;
        private System.Windows.Forms.TextBox txtNewRate;
        private System.Windows.Forms.Label label6;
    }
}