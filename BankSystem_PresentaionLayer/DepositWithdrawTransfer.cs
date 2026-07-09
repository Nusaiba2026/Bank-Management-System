using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemBusinessLayer;


namespace BankSystem_PresentaionLayer
{
    public partial class frmDepositWithdrawTransfer : Form
    {
        public frmDepositWithdrawTransfer()
        {
            InitializeComponent();
        }
        clsClient client1;
        clsClient client2;
        public enum enMode
        {
            Deposit = 0,
            Withdraw = 1,
            Transfer = 2
        }
        public enMode Mode;
        void CheckAllTextBoxesHaveValues()
        {
            if(Mode==enMode.Transfer)
            {
                btnDepositWithdrawTransfer.Enabled =
             !string.IsNullOrWhiteSpace(txtAccNum1.Text)
             && !string.IsNullOrWhiteSpace(txtAccNum2.Text)
             && !string.IsNullOrWhiteSpace(txtAmount.Text);
            }
            else
            {
                btnDepositWithdrawTransfer.Enabled =
             !string.IsNullOrWhiteSpace(txtAccNum1.Text)
             && !string.IsNullOrWhiteSpace(txtAmount.Text);
            }
         
        }
        void ShowClientCard()
        {

            client1 = clsClient.Find(txtAccNum1.Text);
                    lbAccountNumber.Text = client1.AccountNumber;
                    lbFirstName.Text = client1.FirstName;
                    lbLastName.Text = client1.LastName;
                    lbEmail.Text = client1.Email;
                    lbPhone.Text = client1.Phone;
                    lbPinCode.Text = client1.PinCode.ToString();
                    lbAccountBalance.Text = client1.AccountBalance.ToString();
                
           
     
     
        }

        private void frmDepositWithdrawTransfer_Load(object sender, EventArgs e)
        {
            btnDepositWithdrawTransfer.Enabled = false;
            if(Mode==enMode.Deposit)
            {
                btnDepositWithdrawTransfer.Text = "Deposit";
                txtAccNum2.Visible = false;
                lbAccNum2.Visible = false;
                lbAccNum1.Text = "Account Number: ";
                lbAmount.Text = "Deposit Amount: ";
            }
            if(Mode==enMode.Withdraw)
            {
                btnDepositWithdrawTransfer.Text = "Withdraw";
                txtAccNum2.Visible = false;
                lbAccNum2.Visible = false;
                lbAccNum1.Text = "Account Number: ";
                lbAmount.Text = "Withdraw Amount: ";
            }
            if(Mode==enMode.Transfer)
            {
                btnDepositWithdrawTransfer.Text = "Transfer";
                txtAccNum2.Visible = true;
                lbAccNum2.Visible = true;
                lbAccNum1.Text = "Account Number From: ";
                lbAccNum2.Text = "Account Number To: ";
                lbAmount.Text = "Transfer Amount: ";
                gbClientCard.Visible = false;
            }
        }

        private void btnDepositWithdrawTransfer_Click(object sender, EventArgs e)
        {
            float Amount = Convert.ToSingle(txtAmount.Text);

            if (Mode == enMode.Deposit)
            {
                if (client1!=null)
                {
                    if (MessageBox.Show("Are you sure to deposit this amount", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (clsTransactions.Deposit(client1.AccountNumber, Amount))
                        {
                            MessageBox.Show("Deposit done successfully");
                            clsTransactions.AddNewTransaction(frmLoginScreen.
                                clsCurrentUser.currentUser.UserID, Amount,
                                client1.ClientID,0, 1,
                                DateTime.Now);
                            ShowClientCard();

                        }
                        else
                        {
                            MessageBox.Show("Amount not Deposit successfully");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Client not found");
                }


            }
            if(Mode==enMode.Withdraw)
            {
           if(client1 != null)
                {
                  
                    if(client1 .AccountBalance>=Amount)
                    {
                        if ((MessageBox.Show("Are you sure to perform this withdraw?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)){
                            if (clsTransactions.Withdraw(client1.AccountNumber, Amount))
                            {
                                MessageBox.Show("Withdraw done successfully");
                                clsTransactions.AddNewTransaction(frmLoginScreen.
                               clsCurrentUser.currentUser.UserID, Amount,
                               client1.ClientID ,0, 2,
                               DateTime.Now);
                                ShowClientCard();
                            }
                            else
                            {
                                MessageBox.Show("Withdraw failed","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                            return;
                  
                    }
                    else
                    {
                        MessageBox.Show("There is not enough Amount in the account to withdraw","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Client not found");
                }
            }
         
            if (Mode == enMode.Transfer)
            {
                if (client1.AccountBalance >= Amount)
                {
                    if (MessageBox.Show("Are you surt to " +
                        "perform this transaction?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.
                        Question) == DialogResult.Yes)
                    {
                        if (clsTransactions.Transfer(client1.
                            AccountNumber, client2.AccountNumber,
                            Amount))
                        {
                            MessageBox.Show("Transfer done successfully");
                            clsTransactions.AddNewTransaction(frmLoginScreen.
                               clsCurrentUser.currentUser.UserID, Amount,
                               client1.ClientID, client2.ClientID, 3,
                               DateTime.Now);
                        }
                        else
                        {
                            MessageBox.Show("Transfer failed");
                            return;
                        }

                    }


                }
                else
                {
                    MessageBox.Show("There is not enough " +
                        "amount to trasnfer from" + 
                        client1.AccountNumber + " to " + 
                        client1.AccountNumber);
                    return;
                }
            }
        }

         
        

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtAccNum1_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValues();

        }

        private void txtAccNum2_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValues();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValues();
        }



        private void txtAccNum1_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAccNum1.Text))
            {
                string AccountNumber = txtAccNum1.Text;
                client1 = clsClient.Find(AccountNumber);
                if (client1 == null)
                {
                    MessageBox.Show("Account Number not found");
                    txtAccNum1.Text = null;
                }
                else
                    ShowClientCard();
            }

        }

        private void txtAccNum2_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtAccNum2.Text))
            {
                string AccountNumber = txtAccNum2.Text;
                client2 = clsClient.Find(AccountNumber);
                if(client2 == null)
                {
                    MessageBox.Show("Account Number not found");
                    txtAccNum2.Text = null;
                }
                
            }
        }

        private void txtAccNum1_TextChanged_1(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValues();
        }
    }

       
    }

