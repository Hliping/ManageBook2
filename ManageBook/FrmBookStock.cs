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
    public partial class FrmBookStock : Form
    {
        public FrmBookStock()
        {
            InitializeComponent();
        }
        private BLLBookStock bllBookStock = new BLLBookStock();
        private void FrmBookStock_Load(object sender, EventArgs e)
        {
            dgvBookStockbind();    
        
        }

        private void dgvBookStockbind()
        {
            dgvBookStock.DataSource = bllBookStock.GetAllBookStock(0, null);
            dgvBookStock.Columns[0].Width = 200;
            dgvBookStock.Columns[1].Width = 200;
            dgvBookStock.Columns[2].Width = 100;
            dgvBookStock.Columns[3].Width = 200;
            dgvBookStock.Columns[4].Width = 250;
            dgvBookStock.Columns[5].Width = 94;
        }

        private void cmbBookStock1()
        {

            

        }

        private void cmbBookStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBookStock.SelectedIndex == 0) 
            {

                dgvBookStock.DataSource = bllBookStock.GetAllBookStock(0, null);
                txtBookStock.Text = string.Empty;
            }
            
        }

        private void btnBookStock_Click(object sender, EventArgs e)
        {
            string txt = cmbBookStock.SelectedItem.ToString();
            string str = txtBookStock.Text;
            switch (txt)
            { 
                case "教材名称":
                dgvBookStock.DataSource = bllBookStock.SelectBookStock(1, str).Tables[0];
                break;

                case "ISBN码":
                dgvBookStock.DataSource = bllBookStock.SelectBookStock(2, str).Tables[0];
                break;

                case "作者":
                dgvBookStock.DataSource = bllBookStock.SelectBookStock(3, str).Tables[0];
                break;

                case "出版社":
                dgvBookStock.DataSource = bllBookStock.SelectBookStock(4, str).Tables[0];
                break;
            }
        }
    }
}
