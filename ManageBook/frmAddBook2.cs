using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ManageBook.DAL;
using ManageBook.BLL;

namespace ManageBook
{
    public partial class frmAddBook2 : Form
    {
        public frmAddBook2()
        {
            InitializeComponent();
        }

        private BLLNoArriveBook bllno = new BLLNoArriveBook();
        
        private void frmAddBook2_Load(object sender, EventArgs e)
        {
            comm();
        }
        private void comm()
        {
             
            txtBookName.Text = CommonStatic.txtBookName;
            txtAuthor.Text = CommonStatic.txtAuthor;
            txtISBN.Text = CommonStatic.txtISBN;
            txtNoArrive.Text = CommonStatic.txtNoArrive.ToString();
            txtNum.Text = CommonStatic.txtNum.ToString();
            txtPublish.Text = CommonStatic.txtPublish;
            txtPrice.Text = CommonStatic.txtPrice.ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtAddNum.Text) > 0)
                {
                    bllno.UpdateBookStock(txtAddNum.Text);
                    
                    this.Close();
                }
            }
            catch (Exception)
            {
                lbltisi.Visible = true;
                //throw;
            }
        }

        private void txtAddNum_TextChanged(object sender, EventArgs e)
        {
            lbltisi.Visible = false;
        }
    }
}
