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
            cmbBookStock1();   //

         dgvBookStock.DataSource = bllBookStock.SelectBookStock().Tables[0];
        }

        private void cmbBookStock1()
        {

            

            IList<BookStock> listBookStock = bllBookStock.GetAllBookStock();
            listBookStock.Insert(0, new BookStock { PlanBookID = 0, ISBN = "--请选择--" });
            cmbBookStock.DisplayMember = "PlanBookID";
            cmbBookStock.ValueMember = "ISBN";
            cmbBookStock.DataSource = listBookStock;

        }

        private void cmbBookStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int PlanBookID = cmbBookStock.SelectedIndex;
            
        }
    }
}
