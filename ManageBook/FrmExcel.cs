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
            //int n = Convert.ToInt32(lblrecord.Text.Substring(4, 2));
            MessageBox.Show(lblrecord.Text.Substring(5, 2));
            if (excel.DataTableToSqlTable(CommonStatic.dt))
            {
                
                
                lbltisi.ForeColor = Color.Green;
                lbltisi.Text = string.Format("写入成功记录{0}条,写入失败记录{1}条", CommonStatic.recordNum);
            }
            else
            {
                lbltisi.ForeColor = Color.Red;
                lbltisi.Text = "全部写入失败";
            }
        }

        private void FrmExcel_Load(object sender, EventArgs e)
        {
            lblrecord.Text =string.Format("表内总共有{0    }条记录",CommonStatic.recordNum);
        }
    }
}
