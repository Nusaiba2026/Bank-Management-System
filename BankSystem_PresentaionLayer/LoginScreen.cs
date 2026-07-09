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
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        string UserName;
        string Password;
        int UserID;
        public static class clsCurrentUser {
            public static clsUser currentUser { set; get; }
            public static DateTime LoginDate { set; get; }
        }
        void CheckAllTextBoxesHaveValue()
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text);
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserName = txtUserName.Text;
            Password = txtPassword.Text;
            if(clsUser .IsUserExists(UserName))
            {
                clsCurrentUser.currentUser = clsUser.Find(UserName);
                if(txtPassword .Text== clsCurrentUser.currentUser.Password.ToString())
                {
                    clsCurrentUser.currentUser = clsUser.Find(UserName);
                    
                
                    int userID = clsCurrentUser.currentUser.UserID;
                    
                    
                    clsLogins login = new clsLogins();
                    login.AddNewLogin(userID);
                    this.Hide();
                    frmHome frm = new frmHome();
                    frm.ShowDialog();
                    this.Close();
                  

                }
                else
                {
                    MessageBox.Show("Invalid UserName/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid UserName/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckAllTextBoxesHaveValue();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
