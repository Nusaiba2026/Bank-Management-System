namespace BankSystem_PresentaionLayer
{
    partial class frmCurrencyCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbCurrencyName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCurrencyCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCurrencyCode2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRate1 = new System.Windows.Forms.Label();
            this.lbCode1 = new System.Windows.Forms.Label();
            this.lbCurrencyName1 = new System.Windows.Forms.Label();
            this.lbCountry1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(133, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(281, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency From Card:";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(104, 214);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(0, 13);
            this.lbRate.TabIndex = 7;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(104, 156);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 13);
            this.lbCode.TabIndex = 6;
            // 
            // lbCurrencyName
            // 
            this.lbCurrencyName.AutoSize = true;
            this.lbCurrencyName.Location = new System.Drawing.Point(104, 98);
            this.lbCurrencyName.Name = "lbCurrencyName";
            this.lbCurrencyName.Size = new System.Drawing.Size(0, 13);
            this.lbCurrencyName.TabIndex = 5;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(104, 40);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(0, 13);
            this.lbCountry.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate(1$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Currency Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country Name:";
            // 
            // cmbCurrencyCode
            // 
            this.cmbCurrencyCode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbCurrencyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencyCode.FormattingEnabled = true;
            this.cmbCurrencyCode.Location = new System.Drawing.Point(246, 74);
            this.cmbCurrencyCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCurrencyCode.Name = "cmbCurrencyCode";
            this.cmbCurrencyCode.Size = new System.Drawing.Size(174, 21);
            this.cmbCurrencyCode.TabIndex = 1;
            this.cmbCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cmbCurrencyCode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(130, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Currency Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(435, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Currency Code:";
            // 
            // cmbCurrencyCode2
            // 
            this.cmbCurrencyCode2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbCurrencyCode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencyCode2.FormattingEnabled = true;
            this.cmbCurrencyCode2.Location = new System.Drawing.Point(546, 71);
            this.cmbCurrencyCode2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbCurrencyCode2.Name = "cmbCurrencyCode2";
            this.cmbCurrencyCode2.Size = new System.Drawing.Size(173, 21);
            this.cmbCurrencyCode2.TabIndex = 6;
            this.cmbCurrencyCode2.SelectedIndexChanged += new System.EventHandler(this.cmbCurrencyCode2_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbRate1);
            this.groupBox2.Controls.Add(this.lbCode1);
            this.groupBox2.Controls.Add(this.lbCurrencyName1);
            this.groupBox2.Controls.Add(this.lbCountry1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(438, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(281, 252);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency To Card";
            // 
            // lbRate1
            // 
            this.lbRate1.AutoSize = true;
            this.lbRate1.Location = new System.Drawing.Point(105, 214);
            this.lbRate1.Name = "lbRate1";
            this.lbRate1.Size = new System.Drawing.Size(0, 13);
            this.lbRate1.TabIndex = 11;
            // 
            // lbCode1
            // 
            this.lbCode1.AutoSize = true;
            this.lbCode1.Location = new System.Drawing.Point(105, 156);
            this.lbCode1.Name = "lbCode1";
            this.lbCode1.Size = new System.Drawing.Size(0, 13);
            this.lbCode1.TabIndex = 10;
            // 
            // lbCurrencyName1
            // 
            this.lbCurrencyName1.AutoSize = true;
            this.lbCurrencyName1.Location = new System.Drawing.Point(105, 98);
            this.lbCurrencyName1.Name = "lbCurrencyName1";
            this.lbCurrencyName1.Size = new System.Drawing.Size(0, 13);
            this.lbCurrencyName1.TabIndex = 9;
            // 
            // lbCountry1
            // 
            this.lbCountry1.AutoSize = true;
            this.lbCountry1.Location = new System.Drawing.Point(105, 40);
            this.lbCountry1.Name = "lbCountry1";
            this.lbCountry1.Size = new System.Drawing.Size(0, 13);
            this.lbCountry1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rate(1$):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Currency Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Currency Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Country Name:";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConvert.Location = new System.Drawing.Point(626, 406);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(93, 32);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAmount.Location = new System.Drawing.Point(133, 417);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 21);
            this.txtAmount.TabIndex = 14;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(130, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Enter Amount To Convert:";
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbResult.Location = new System.Drawing.Point(398, 417);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(160, 21);
            this.lbResult.TabIndex = 16;
            // 
            // frmCurrencyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCurrencyCode2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCurrencyCode);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCurrencyCalculator";
            this.Text = "CurrencyCalculator";
            this.Load += new System.EventHandler(this.frmCurrencyCalculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCurrencyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCurrencyCode2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbCurrencyName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbRate1;
        private System.Windows.Forms.Label lbCode1;
        private System.Windows.Forms.Label lbCurrencyName1;
        private System.Windows.Forms.Label lbCountry1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbResult;
    }
}