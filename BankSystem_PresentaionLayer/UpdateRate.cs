using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_PresentaionLayer
{
    public partial class frmUpdateRate : Form 
    {
        public frmUpdateRate()
        {
            InitializeComponent();
        }
        public clsCurrencies currency1;
        void _FillCurrencyCodeInComboBox()
        {
            DataTable dtCurrency = new DataTable();
            dtCurrency = clsCurrencies.ListCurrencies();
            foreach (DataRow row in dtCurrency.Rows)
            {
                cmbCurrencyCode.Items.Add(row["Code"]);
            }
        }
        private void frmUpdateRate_Load(object sender, EventArgs e)
        {
            _FillCurrencyCodeInComboBox();
        }

        private void cmbCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
           currency1 = clsCurrencies.FindByCode(cmbCurrencyCode.Text);
            lbCode.Text = currency1.Code;
            lbCountry.Text = currency1.Country;
            lbRate.Text = currency1.RateToUSD.ToString();
            lbCurrencyName.Text = currency1.CurrencyName;
        }

        private void txtNewRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSaveNewRate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewRate.Text))
            {
                MessageBox.Show("Enter new rate please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(MessageBox.Show ("Are you sure to save new rate?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question )==DialogResult.Yes)
            {
                clsCurrencies.Update(Convert.ToSingle(txtNewRate.Text), currency1.Code);
                MessageBox.Show("New rate updated successfully", "");

            }
            else
            {
                return;
            }
        }
    }
}
