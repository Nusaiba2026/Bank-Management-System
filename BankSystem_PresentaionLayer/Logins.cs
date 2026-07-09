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
    public partial class frmLogins : Form
    {
        public frmLogins()
        {
            InitializeComponent();
        }
        void RefreshLoginsList()
        {
            BindingSource bsLogins = new BindingSource();
            bsLogins.DataSource = clsLogins .ListLogins ();
            dgvLogins.DataSource = bsLogins;
            lbLoginsCount.Text = dgvLogins.RowCount.ToString()+" Logins";
        }
        private void frmLogins_Load(object sender, EventArgs e)
        {
            RefreshLoginsList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BindingSource bsLogins = new BindingSource();
            bsLogins.DataSource = clsLogins.ListLogins();
            DateTime LoginDate = dtpLoginDate.Value.Date;
            bsLogins.Filter = $"DateTime>=#{LoginDate:yyyy/MM/dd}# and DateTime<#{LoginDate.AddDays(1):yyyy/MM/dd}#";
            dgvLogins.DataSource = bsLogins;
            lbLoginsCount.Text = dgvLogins.RowCount.ToString ()+" Logins";
        }
    }
}
