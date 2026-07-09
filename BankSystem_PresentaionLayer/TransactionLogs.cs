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
    public partial class frmTransactionLogs : Form 
    {
        public frmTransactionLogs()
        {
            InitializeComponent();
        }
       void RefreshTransactionLogsList()
        {
            BindingSource bsTransactionLogs = new BindingSource();
            bsTransactionLogs.DataSource = clsTransactions.ListTransactions();
            dgvTransactionLogs.DataSource = bsTransactionLogs;
        }
        private void frmTransactionLogs_Load(object sender, EventArgs e)
        {
            RefreshTransactionLogsList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BindingSource bsTransactionLogs = new BindingSource();
            bsTransactionLogs.DataSource = clsTransactions.ListTransactions();
            DateTime TransDate = dtpTransactionDate.Value.Date;
            bsTransactionLogs .Filter = $"TransactionDate>" +
                $"=#{TransDate :yyyy/MM/dd}# and TransactionDate" +
                $"<#{TransDate .AddDays(1):yyyy/MM/dd}#";
            dgvTransactionLogs.DataSource = bsTransactionLogs;


        }
    }
}
