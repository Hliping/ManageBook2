using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ManageBook.BLL;
using ManageBook.DAL;
using ManageBook.Modle;

namespace ManageBook
{
    public partial class FrmNoArriveBook : Form
    {
        public FrmNoArriveBook()
        {
            InitializeComponent();
        }
        private BLLOrder bllo = new BLLOrder();
        private BLLBookStock bllbs = new BLLBookStock();
        private BLLNoArriveBook bllno = new BLLNoArriveBook();
        private frmAddBook2 frm=new frmAddBook2();

        private void FrmNoArriveBook_Load(object sender, EventArgs e)
        {
            dgvNoArrive.AutoGenerateColumns = false;
            dgvNoArrive.DataSource = bllno.GetAllInfo(0, null);
            
        }

        private void cmbInformation_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cmbInformation.SelectedIndex == 0)
            {
                dgvNoArrive.DataSource = bllno.GetAllInfo(0, null);
                txtDelect.Text = null;
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            int index = cmbInformation.SelectedIndex;
            dgvNoArrive.DataSource = bllno.GetAllInfo(index,txtDelect.Text);
        }

        private void tsmiAddBook_Click(object sender, EventArgs e)
        {
            comm();
            if (frm.IsDisposed)
            {
                frm = new frmAddBook2();
            }
            frm.Show();
            frm.TopMost = true;
            frm.TopMost = false;
        }

        private void comm()
        {
            //MessageBox.Show(dgvNoArrive.CurrentRow.Cells[0].Value.ToString());
            CommonStatic.BookStockID = Convert.ToInt32(dgvNoArrive.CurrentRow.Cells["库存编号"].Value);
            CommonStatic.txtBookName = dgvNoArrive.CurrentRow.Cells["教材名称"].Value.ToString();
            CommonStatic.txtISBN = dgvNoArrive.CurrentRow.Cells["ISBN码"].Value.ToString();
            CommonStatic.txtAuthor = dgvNoArrive.CurrentRow.Cells["作者"].Value.ToString();
            CommonStatic.txtPublish = dgvNoArrive.CurrentRow.Cells["出版社"].Value.ToString();
            CommonStatic.txtPrice = float.Parse(dgvNoArrive.CurrentRow.Cells["价格"].Value.ToString());
            CommonStatic.txtNum = Convert.ToInt32(dgvNoArrive.CurrentRow.Cells["订购数量"].Value);
            CommonStatic.txtNoArrive = Convert.ToInt32(dgvNoArrive.CurrentRow.Cells["未到数量"].Value);
        }
    }
}
