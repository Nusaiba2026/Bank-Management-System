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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        enum enMode
        {
            AddNew = 0,
            Update = 1
        }
        enMode Mode;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            if ((frmLoginScreen.clsCurrentUser .currentUser .Permission  & 1) > 0)
            {
                frmShowClients frm = new frmShowClients();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Access denide ,Contact your admin", "");
         


        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if((frmLoginScreen.clsCurrentUser.currentUser.Permission & 2) > 0)
            {
                frmShowUsers frm = new frmShowUsers();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Access denide ,Contact your admin", "");


        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if((frmLoginScreen.clsCurrentUser.currentUser.Permission & 4) > 0)
            {
                frmShowTotalBalances frm = new frmShowTotalBalances();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Access denide ,Contact your admin", "");


        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            if((frmLoginScreen.clsCurrentUser.currentUser.Permission & 8)>0)
            {
                frmShowCurrencies frm = new frmShowCurrencies();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Access denide ,Contact your admin", "");


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
