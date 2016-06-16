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
    public partial class FrmGrantBook : Form
    {
        public FrmGrantBook()
        {
            InitializeComponent();
        }
        private BLLGetBookBusiness bllbookbusiness = new BLLGetBookBusiness();
        private void FrmGrantBook_Load(object sender, EventArgs e)
        {
            List<GetBookBusiness> list= bllbookbusiness.GetAllGetBook();
            dgvGetBook.AutoGenerateColumns = false;
            dgvGetBook.DataSource = list;
        }
    }
}
