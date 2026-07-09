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
    public partial class frmAddEditClient : Form
    {
        public frmAddEditClient()
        {
            InitializeComponent();
        }

        public enum enMode
        {
            AddNew=0,
            Update=1
        }
       public enMode Mode;
        void CheckAllTextBoxesHaveValue()
        {
            btnSave.Enabled = !string.IsNullOrWhiteSpace(txtAccountNumber.Text) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                !string.IsNullOrWhiteSpace(txtAccountBalance.Text) &&
                !string.IsNullOrWhiteSpace(txtPinCode.Text);
        }
        private void frmAddEditClient_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            
                btnFind.Visible = false;
            if (Mode == enMode.Update)
                btnFind.Visible = true;
            btnSave.Enabled = false;
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                e.Cancel = true;
                txtAccountNumber.Focus();
                errorProvider1.SetError(txtAccountNumber, "Account Number must have value");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccountNumber, "");
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "First Name must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Last Name must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "Email must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "Phone must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
            }
        }

        private void txtPinCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                e.Cancel = true;
                txtPinCode.Focus();
                errorProvider1.SetError(txtPinCode, "PinCode must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPinCode, "");
            }
        }

        private void txtAccountBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountBalance.Text))
            {
                e.Cancel = true;
                txtAccountBalance.Focus();
                errorProvider1.SetError(txtAccountBalance, "Account Balacne must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccountBalance, "");
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string AccountNumber = txtAccountNumber.Text;
            clsClient client1 = clsClient.Find(AccountNumber);
            if (client1 != null)
            {
                txtFirstName.Text = client1.FirstName;
                txtLastName.Text = client1.LastName;
                txtEmail.Text = client1.Email;
                txtPhone.Text = client1.Phone;
                txtPinCode.Text = client1.PinCode.ToString();
                txtAccountBalance.Text = client1.AccountBalance.ToString();

            }
            else
                MessageBox.Show("Client not found", "", MessageBoxButtons.OK);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string AccountNumber = txtAccountNumber.Text;
            clsClient client1;
            if (Mode == enMode.AddNew)
            {
                if (clsClient.IsClientExists(AccountNumber))
                {
                    MessageBox.Show("Client is already exists choose another one", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                client1 = new clsClient();
            }
            else
            {
                 client1 = clsClient.Find(AccountNumber);
            }
            client1.AccountNumber = txtAccountNumber.Text;
            client1.FirstName = txtFirstName.Text;
            client1.LastName = txtLastName.Text;
            client1.Email = txtEmail.Text;
            client1.Phone = txtPhone.Text;
            client1.PinCode =Convert.ToInt16( txtPinCode.Text);
            client1.AccountBalance = Convert.ToSingle(txtAccountBalance.Text);

            if (client1.Save())
            
                MessageBox.Show("Client save successfully", "", MessageBoxButtons.OK);
            
            else
                MessageBox.Show("Client not save");
            
        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtAccountBalance_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtAccountBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
