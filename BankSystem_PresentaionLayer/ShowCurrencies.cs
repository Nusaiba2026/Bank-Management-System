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
    public partial class frmShowCurrencies : Form
    {
        public frmShowCurrencies()
        {
            InitializeComponent();
        }
        void _RefreshCurrencyList()
        {
            BindingSource bsCurrencyList = new BindingSource();
            bsCurrencyList.DataSource = clsCurrencies.ListCurrencies();
            dgvCurrencyList.DataSource = bsCurrencyList;
        }

        private void frmShowCurrencies_Load(object sender, EventArgs e)
        {
            _RefreshCurrencyList();
            showAllCurrenciesToolStripMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(rbSearchByCountry.Checked)
            {
                BindingSource bsCurrencyList = new BindingSource();
                bsCurrencyList.DataSource = clsCurrencies.ListCurrencies();
                bsCurrencyList.Filter = "Country like '%" + txtSearch.Text + "%'";
                dgvCurrencyList.DataSource = bsCurrencyList;
            }
            if(rbSearchByCode.Checked)
            {
                BindingSource bsCurrencyList = new BindingSource();
                bsCurrencyList.DataSource = clsCurrencies.ListCurrencies();
                bsCurrencyList.Filter = "Code like '%" + txtSearch.Text + "%'";
                dgvCurrencyList.DataSource = bsCurrencyList;
            }
        }

        private void currencyCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrencyCalculator frm = new frmCurrencyCalculator();
            frm.ShowDialog();
        }

        private void updateRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateRate frm = new frmUpdateRate();
            frm.ShowDialog();
        }
    }
}
