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
    public partial class frmShowClients : Form
    {
        public frmShowClients()
        {
            InitializeComponent();
        }
       public  void RefreshClientsList()
        {
            BindingSource bsClients = new BindingSource();
            bsClients.DataSource = clsClient.ListClients();
            dgvShowClients.DataSource = bsClients;
        }
        private void frmShowClients_Load(object sender, EventArgs e)
        {
            RefreshClientsList();
            lbClientsNumber.Text = dgvShowClients.RowCount.ToString()+" Clients";

            showClientsListToolStripMenuItem.BackColor = Color.WhiteSmoke;

        }

        private void txtFindClients_TextChanged(object sender, EventArgs e)
        {

            BindingSource bsClients = new BindingSource();
            bsClients.DataSource = clsClient.ListClients();
            bsClients.Filter = "AccountNumber Like '%" + txtFindClients.Text + "%'";
            dgvShowClients.DataSource = bsClients.DataSource;
            lbClientsNumber.Text = dgvShowClients.RowCount.ToString()+" Clients";


        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient();
            frm.Mode = frmAddEditClient.enMode.AddNew;
            frm.ShowDialog();
            RefreshClientsList();
         

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient();
            frm.Mode = frmAddEditClient.enMode.Update;
            frm.ShowDialog();
            RefreshClientsList();
    

        }

        private void tsmDeleteClient_Click(object sender, EventArgs e)
        {
            
           if( MessageBox .Show ("Are you sure to delete this client?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsClient.DeleteClient(dgvShowClients.CurrentRow.Cells[4].Value.ToString()))
                    MessageBox.Show("Client deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Client not delete", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshClientsList();
            }
        }

        private void showClientsListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
