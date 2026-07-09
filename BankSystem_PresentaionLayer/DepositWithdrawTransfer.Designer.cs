namespace BankSystem_PresentaionLayer
{
    partial class frmDepositWithdrawTransfer
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
            this.txtAccNum1 = new System.Windows.Forms.TextBox();
            this.txtAccNum2 = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lbAccNum1 = new System.Windows.Forms.Label();
            this.lbAccNum2 = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.gbClientCard = new System.Windows.Forms.GroupBox();
            this.lbPinCode = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAccountBalance = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDepositWithdrawTransfer = new System.Windows.Forms.Button();
            this.gbClientCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccNum1
            // 
            this.txtAccNum1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNum1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum1.Location = new System.Drawing.Point(61, 68);
            this.txtAccNum1.Name = "txtAccNum1";
            this.txtAccNum1.Size = new System.Drawing.Size(149, 21);
            this.txtAccNum1.TabIndex = 0;
            this.txtAccNum1.TextChanged += new System.EventHandler(this.txtAccNum1_TextChanged_1);
            this.txtAccNum1.Leave += new System.EventHandler(this.txtAccNum1_Leave);
            // 
            // txtAccNum2
            // 
            this.txtAccNum2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAccNum2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum2.Location = new System.Drawing.Point(61, 146);
            this.txtAccNum2.Name = "txtAccNum2";
            this.txtAccNum2.Size = new System.Drawing.Size(149, 21);
            this.txtAccNum2.TabIndex = 1;
            this.txtAccNum2.TextChanged += new System.EventHandler(this.txtAccNum2_TextChanged);
            this.txtAccNum2.Leave += new System.EventHandler(this.txtAccNum2_Leave);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(61, 229);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(149, 21);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lbAccNum1
            // 
            this.lbAccNum1.AutoSize = true;
            this.lbAccNum1.BackColor = System.Drawing.Color.Transparent;
            this.lbAccNum1.Location = new System.Drawing.Point(58, 52);
            this.lbAccNum1.Name = "lbAccNum1";
            this.lbAccNum1.Size = new System.Drawing.Size(35, 13);
            this.lbAccNum1.TabIndex = 3;
            this.lbAccNum1.Text = "label1";
            // 
            // lbAccNum2
            // 
            this.lbAccNum2.AutoSize = true;
            this.lbAccNum2.BackColor = System.Drawing.Color.Transparent;
            this.lbAccNum2.Location = new System.Drawing.Point(58, 130);
            this.lbAccNum2.Name = "lbAccNum2";
            this.lbAccNum2.Size = new System.Drawing.Size(35, 13);
            this.lbAccNum2.TabIndex = 4;
            this.lbAccNum2.Text = "label2";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Location = new System.Drawing.Point(58, 213);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(35, 13);
            this.lbAmount.TabIndex = 5;
            this.lbAmount.Text = "label3";
            // 
            // gbClientCard
            // 
            this.gbClientCard.BackColor = System.Drawing.Color.Transparent;
            this.gbClientCard.Controls.Add(this.lbPinCode);
            this.gbClientCard.Controls.Add(this.lbPhone);
            this.gbClientCard.Controls.Add(this.lbAccountBalance);
            this.gbClientCard.Controls.Add(this.lbEmail);
            this.gbClientCard.Controls.Add(this.lbLastName);
            this.gbClientCard.Controls.Add(this.lbFirstName);
            this.gbClientCard.Controls.Add(this.lbAccountNumber);
            this.gbClientCard.Controls.Add(this.label10);
            this.gbClientCard.Controls.Add(this.label9);
            this.gbClientCard.Controls.Add(this.label8);
            this.gbClientCard.Controls.Add(this.label7);
            this.gbClientCard.Controls.Add(this.label6);
            this.gbClientCard.Controls.Add(this.label5);
            this.gbClientCard.Controls.Add(this.label4);
            this.gbClientCard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientCard.Location = new System.Drawing.Point(269, 52);
            this.gbClientCard.Name = "gbClientCard";
            this.gbClientCard.Size = new System.Drawing.Size(279, 318);
            this.gbClientCard.TabIndex = 6;
            this.gbClientCard.TabStop = false;
            this.gbClientCard.Text = "Client Card";
            // 
            // lbPinCode
            // 
            this.lbPinCode.AutoSize = true;
            this.lbPinCode.Location = new System.Drawing.Point(129, 229);
            this.lbPinCode.Name = "lbPinCode";
            this.lbPinCode.Size = new System.Drawing.Size(0, 13);
            this.lbPinCode.TabIndex = 13;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(129, 190);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(0, 13);
            this.lbPhone.TabIndex = 12;
            // 
            // lbAccountBalance
            // 
            this.lbAccountBalance.AutoSize = true;
            this.lbAccountBalance.Location = new System.Drawing.Point(129, 268);
            this.lbAccountBalance.Name = "lbAccountBalance";
            this.lbAccountBalance.Size = new System.Drawing.Size(0, 13);
            this.lbAccountBalance.TabIndex = 11;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(129, 151);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 13);
            this.lbEmail.TabIndex = 10;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(129, 112);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(0, 13);
            this.lbLastName.TabIndex = 9;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(129, 73);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(0, 13);
            this.lbFirstName.TabIndex = 8;
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Location = new System.Drawing.Point(129, 34);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(0, 13);
            this.lbAccountNumber.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "First Name: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Account Balance: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "PinCode: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Number: ";
            // 
            // btnDepositWithdrawTransfer
            // 
            this.btnDepositWithdrawTransfer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDepositWithdrawTransfer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositWithdrawTransfer.Location = new System.Drawing.Point(73, 357);
            this.btnDepositWithdrawTransfer.Name = "btnDepositWithdrawTransfer";
            this.btnDepositWithdrawTransfer.Size = new System.Drawing.Size(112, 35);
            this.btnDepositWithdrawTransfer.TabIndex = 7;
            this.btnDepositWithdrawTransfer.Text = "button1";
            this.btnDepositWithdrawTransfer.UseVisualStyleBackColor = false;
            this.btnDepositWithdrawTransfer.Click += new System.EventHandler(this.btnDepositWithdrawTransfer_Click);
            // 
            // frmDepositWithdrawTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDepositWithdrawTransfer);
            this.Controls.Add(this.gbClientCard);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbAccNum2);
            this.Controls.Add(this.lbAccNum1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccNum2);
            this.Controls.Add(this.txtAccNum1);
            this.Name = "frmDepositWithdrawTransfer";
            this.Text = "frmDepositWithdrawTransfer";
            this.Load += new System.EventHandler(this.frmDepositWithdrawTransfer_Load);
            this.gbClientCard.ResumeLayout(false);
            this.gbClientCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccNum1;
        private System.Windows.Forms.TextBox txtAccNum2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lbAccNum1;
        private System.Windows.Forms.Label lbAccNum2;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.GroupBox gbClientCard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPinCode;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAccountBalance;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.Button btnDepositWithdrawTransfer;
    }
}