using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ManageBook.BLL;
using ManageBook.Modle;

namespace ManageBook
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private BLLAdmin blladmin = new BLLAdmin();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.LoginID = cmblogin.Text.Trim();
            admin.LoginPwd= txtpwd.Text.Trim();
            if (blladmin.GetAllAdmin(admin))
            {
                FrmMain frm = new FrmMain();
                frm.Show();
                this.Hide();
            }
            else 
            {
                txtpwd.Text = "";
                lbltisi.Visible = true;
            }
        }

        private void cmblogin_TextChanged(object sender, EventArgs e)
        {
            lbltisi.Visible = false;
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            lbltisi.Visible = false;
        }
    }
}
