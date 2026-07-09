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
    public partial class frmShowUsers : Form
    {
        public frmShowUsers()
        {
            InitializeComponent();
        }
        void RefreshUserList()
        {
            BindingSource bsUsers = new BindingSource();
            bsUsers.DataSource = clsUser.ListUsers();
            dgvShowUsers.DataSource = bsUsers;
        }
        private void frmShowUsers_Load(object sender, EventArgs e)
        {
            RefreshUserList();
            lbUserCount.Text = dgvShowUsers.Rows.
                Count.ToString() + " Users";
            showUsersListToolStripMenuItem.BackColor = Color.WhiteSmoke;

        }

        private void txtFindUser_TextChanged(object sender, EventArgs e)
        {
            BindingSource bsUsers = new BindingSource();
            bsUsers.DataSource = clsUser.ListUsers();
            bsUsers.Filter = "UserName like '%"+txtFindUser .Text+"%'";
            dgvShowUsers.DataSource = bsUsers;
            lbUserCount.Text = dgvShowUsers.Rows.Count.ToString() + " Users";


        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.Mode = frmAddUpdateUser.enMode.AddNew;
            frm.ShowDialog();
            RefreshUserList();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.Mode = frmAddUpdateUser.enMode.Update;
            frm.ShowDialog();
            RefreshUserList();
        }

        private void loginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogins frm = new frmLogins();
            frm.ShowDialog();
        }
    }
}
