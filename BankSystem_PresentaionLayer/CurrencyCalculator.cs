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
    public partial class frmCurrencyCalculator : Form
    {
        public frmCurrencyCalculator()
        {
            InitializeComponent();
        }
        void _FillCurrencyCodeInComboBox()
        {
            DataTable dtCurrencyCode = new DataTable();
            dtCurrencyCode = clsCurrencies.ListCurrencies();
            foreach(DataRow row in dtCurrencyCode.Rows)
            {
                cmbCurrencyCode.Items.Add(row["Code"]);
            }
        }
        void _FillCurrencyCodeInComboBox1()
        {
            DataTable dtCurrencyCode = new DataTable();
            dtCurrencyCode = clsCurrencies.ListCurrencies();
            foreach (DataRow row in dtCurrencyCode.Rows)
            {
                cmbCurrencyCode2.Items.Add(row["Code"]);
            }
        }
        private void frmCurrencyCalculator_Load(object sender, EventArgs e)
        {
            _FillCurrencyCodeInComboBox();
            _FillCurrencyCodeInComboBox1();
        }

        private void cmbCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCurrencies currency1 = clsCurrencies.FindByCode(cmbCurrencyCode.Text);
            lbCountry.Text = currency1.Country;
            lbCode.Text = currency1.Code;
            lbRate.Text = currency1.RateToUSD.ToString ();
            lbCurrencyName.Text = currency1.CurrencyName;
        }

        private void cmbCurrencyCode2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCurrencies currency1 = clsCurrencies.FindByCode(cmbCurrencyCode2.Text);
            lbCurrencyName1.Text  = currency1.CurrencyName;
            lbCountry1.Text = currency1.Country;
            lbRate1.Text = currency1.RateToUSD.ToString();
            lbCode1.Text = currency1.Code;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Enter amount please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbResult.Text = (clsCurrencies.ConvertCurrencies(Convert.ToSingle(txtAmount.Text.ToString()), lbCode.Text, lbCode1.Text)).ToString();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

        }
    }
}
