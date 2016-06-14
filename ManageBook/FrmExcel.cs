using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ManageBook.BLL;

namespace ManageBook
{
    public partial class FrmExcel : Form
    {
        public FrmExcel()
        {
            InitializeComponent();
        }

        private BLLExcel excel = new BLLExcel();
        private void btnAddStudentInfo_Click(object sender, EventArgs e)
        {
            if (excel.DataTableToSqlTable(CommonStatic.dt))
            {
                MessageBox.Show("写入成功");
            }
        }
    }
}
