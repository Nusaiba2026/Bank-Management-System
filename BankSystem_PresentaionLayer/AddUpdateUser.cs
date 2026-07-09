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
    public partial class frmAddUpdateUser : Form
    {
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }
        void SetPermissions(int Permission)
        {
            if ((Convert.ToInt16(Permission) & 
                Convert.ToInt16(chkManageClients.Tag)) > 0)
                chkManageClients.Checked = true;
            if ((Convert.ToInt16(Permission) &
                Convert.ToInt16(chkManageUsers.Tag)) > 0)
                chkManageUsers.Checked = true;
            if ((Convert.ToInt16(Permission) &
                Convert.ToInt16(chkTransactions.Tag)) > 0)
                chkTransactions.Checked = true;
            if ((Convert.ToInt16(Permission) & 
                Convert.ToInt16(chkCurrencyExchange.Tag)) > 0)
                chkCurrencyExchange.Checked = true;
         
        }
        public enum enMode
        {
            AddNew=0,
            Update=1
        }
        public enMode Mode;
        int CalculatePermissions()
        {
            int Permissions = 0;

            if (chkManageClients.Checked)
                Permissions += Convert.ToInt16(chkManageClients.Tag);
            if (chkManageUsers.Checked)
                Permissions += Convert.ToInt16(chkManageUsers.Tag);
            if (chkTransactions.Checked)
                Permissions += Convert.ToInt16(chkTransactions.Tag);
            if (chkCurrencyExchange.Checked)
                Permissions += Convert.ToInt16(chkCurrencyExchange.Tag);
            return Permissions;
        }
        void CheckAllTextBoxesAndRadioButtonsHaveValueOrChecked()
        {
            btnSave.Enabled = !string.IsNullOrWhiteSpace(txtUserName.Text) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtPhone.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                (rbYes.Checked||rbNo.Checked  );
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                lbFind.Visible = false;
                btnFind.Visible = false;
            }
            if(Mode==enMode.Update)
            {
                lbFind.Visible = true;
                btnFind.Visible = true;
            }
            btnSave.Enabled = false;
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text)){
                e.Cancel = true;
                txtUserName.Focus();
                errorProvider1.SetError(txtUserName, "UserName must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "FirstName must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if(string .IsNullOrWhiteSpace (txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "LastName must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string .IsNullOrWhiteSpace (txtEmail.Text))
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
            if(string.IsNullOrWhiteSpace (txtPhone.Text))
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

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string .IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "Password must have value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            chkManageClients.Checked = true;
            chkManageUsers.Checked = true;
            chkTransactions.Checked = true;
            chkCurrencyExchange.Checked = true;
            CheckAllTextBoxesAndRadioButtonsHaveValueOrChecked();
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            chkManageClients.Checked = false;
            chkManageUsers.Checked = false;
            chkTransactions.Checked = false;
            chkCurrencyExchange.Checked = false;
            CheckAllTextBoxesAndRadioButtonsHaveValueOrChecked();
        }

     
   

        private void chkManageClients_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePermissions();
        }

        private void chkManageUsers_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePermissions();
        }

        private void chkTransactions_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePermissions();
        }

        private void chkCurrencyExchange_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePermissions();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string UserName;
            if(string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Enter User Name");
            }
            else
            {
                UserName = txtUserName.Text;
                int Permissions;
                clsUser User1 = clsUser.Find(UserName);
                if (User1 != null)
                {
                    txtUserName.Text = User1.UserName;
                    txtFirstName.Text = User1.FirstName;
                    txtLastName.Text = User1.LastName;
                    txtEmail.Text = User1.Email;
                    txtPhone.Text = User1.Phone;
                    txtPassword.Text = User1.Password.ToString ();

                    Permissions = User1.Permission;
                    SetPermissions(Permissions);

                }
                else
                    MessageBox.Show("There is no User with UserName: " + UserName);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            clsUser User;
            if (Mode == enMode.AddNew)
            {
                User = new clsUser();
                if(clsUser.IsUserExists (UserName))
                {
                    MessageBox.Show("User Name is already exists");
                    return;
                }
            }
            else
                User = clsUser.Find(UserName);
            User.UserName = txtUserName.Text;
            User.FirstName = txtFirstName.Text;
            User.LastName = txtLastName.Text;
            User.Email = txtEmail.Text;
            User.Phone = txtPhone.Text;
            User.Password = Convert.ToInt16(txtPassword.Text);
            User.Permission = CalculatePermissions();
            if (User.Save())
                MessageBox.Show("User Saved successfully");
            else
                MessageBox.Show("User not save");
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
