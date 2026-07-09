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
    public partial class frmShowTotalBalances : Form
    {
        public frmShowTotalBalances()
        {
            InitializeComponent();
        }
        void RefreshTotalBalancesList()
        {
            BindingSource bsTotalBalances = new BindingSource();
            bsTotalBalances.DataSource = clsClient.ListClients();
            dgvTotalBalances.DataSource = bsTotalBalances;
            
             dgvTotalBalances.Columns["LastName"].Visible = false;
            dgvTotalBalances.Columns["Email"].Visible = false;
            dgvTotalBalances.Columns["Phone"].Visible = false;
            dgvTotalBalances.Columns["PinCode"].Visible = false;
           

        }
        private void frmShowTotalBalances_Load(object sender, EventArgs e)
        {
            RefreshTotalBalancesList();
            showTotalBalancesToolStripMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bsTotalBalances = new BindingSource();
            bsTotalBalances.DataSource = clsClient.ListClients();
            bsTotalBalances.Filter = "AccountNumber like'%" + txtSearch.Text+"%'";
            dgvTotalBalances.DataSource = bsTotalBalances;
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepositWithdrawTransfer frm = new frmDepositWithdrawTransfer();
            frm.Mode = frmDepositWithdrawTransfer.enMode.Deposit;
            frm.ShowDialog();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepositWithdrawTransfer frm = new frmDepositWithdrawTransfer();
            frm.Mode = frmDepositWithdrawTransfer.enMode.Withdraw;
            frm.ShowDialog();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepositWithdrawTransfer frm = new frmDepositWithdrawTransfer();
            frm.Mode = frmDepositWithdrawTransfer.enMode.Transfer;
            frm.ShowDialog();
            RefreshTotalBalancesList();
        }

        private void transactionLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactionLogs frm = new frmTransactionLogs();
            frm.ShowDialog();
        }

    }
}
