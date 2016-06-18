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
        #region 私有变量
        private BLLGrantBook bllbookbusiness = new BLLGrantBook();
        private BLLCommon bllcommon = new BLLCommon();
        private bool flag = false;
        #endregion
        private void FrmGrantBook_Load(object sender, EventArgs e)
        {
            dgvBookStockAllInfo();//绑定库存列表数据的方法
            dgvStudentAllInfo();// 绑定学生信息列表数据的方法
            dgvGrantBookAllInfo();// 绑定教材发放明细列表数据的方法
            cmbCollegeInfo();// 绑定下拉列表学院的数据方法
        }
        /// <summary>
        /// 绑定库存列表数据的方法
        /// </summary>
        public void dgvBookStockAllInfo() 
        {
            dgvBookStock.AutoGenerateColumns = false;
            dgvBookStock.DataSource = bllbookbusiness.GetAllBookStock(0,0);
        }
        /// <summary>
        /// 绑定学生信息列表数据的方法
        /// </summary>
        public void dgvStudentAllInfo()
        {
            dgvStudentInfo.AutoGenerateColumns = false;
            dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(0,0);
        }
        /// <summary>
        /// 绑定教材发放明细列表数据的方法
        /// </summary>
        public void dgvGrantBookAllInfo()
        {
            dgvGrantBook.AutoGenerateColumns = false;
            dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(0,0);
        }
        /// <summary>
        /// 绑定下拉列表学院的数据方法
        /// </summary>
        public void cmbCollegeInfo()
        {
            List<CollegeInfo> collegeinfo = bllcommon.GetAllCollegeInfo();         //调用GetAllCollegeInfo()方法获取学院信息并赋值给数组
            collegeinfo.Insert(0, new CollegeInfo { CollegeName = "——请选择学院——", CollegeID = 0 }); //添加一条记录
            cmbCollege.DisplayMember = "CollegeName";  //绑定显示的字段
            cmbCollege.ValueMember = "CollegeID";  //绑定下拉框的值成员
            cmbCollege.DataSource = collegeinfo;   //绑定下拉框的数据源
        }
        /// <summary>
        /// 学院下拉框值改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCollege_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int collegeID = Convert.ToInt32(cmbCollege.SelectedValue); //当下拉框选了值并且下拉框关闭后 获取学院编号collegeID
            cmbstudentclass(collegeID);       //以学院编号collegeID调用方法cmbstudentclass（）
            if (collegeID == 0)
            {
                dgvBookStockAllInfo();//绑定库存列表数据的方法
                dgvStudentAllInfo();// 绑定学生信息列表数据的方法
                dgvGrantBookAllInfo();// 绑定教材发放明细列表数据的方法
            }
            else
            {
                //MessageBox.Show(n.ToString());
                dgvBookStock.DataSource= bllbookbusiness.GetAllBookStock(1, collegeID);
                dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(1, collegeID);
                dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(1, collegeID);
            }
            //cmbStudentClass.DataSource = common.GetAllStudentClass(collegeID);
            //cmbStudentClass.ValueMember = "StudentClassID";
            //cmbStudentClass.DisplayMember = "ClassName";
        }
        /// <summary>
        /// 班级下拉框值改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStudentClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int collegeID = Convert.ToInt32(cmbCollege.SelectedValue);
            int ClassInfoID = Convert.ToInt32(cmbStudentClass.SelectedValue); //当下拉框选了值并且下拉框关闭后 获取学院编号collegeID
            if (ClassInfoID == 0)
            {
                dgvBookStock.DataSource = bllbookbusiness.GetAllBookStock(1, collegeID);
                dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(1, collegeID);
                dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(1, collegeID);
            }
            else
            {
                //MessageBox.Show(n.ToString());
                dgvBookStock.DataSource = bllbookbusiness.GetAllBookStock(2, ClassInfoID);
                dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(2, ClassInfoID);
                dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(2, ClassInfoID);
            }
        }
        private void cmbstudentclass(int collegeID)
        {
            List<StudentClass> studentclass = bllcommon.GetAllStudentClass(collegeID); //调用GetAllStudentClass()方法获取班级信息并赋值给数组
            studentclass.Insert(0, new StudentClass { ClassName = "——请选择班级——", StudentClassID = 0 }); //添加一条记录
            cmbStudentClass.DisplayMember = "ClassName";//绑定显示的字段
            cmbStudentClass.ValueMember = "StudentClassID";//绑定下拉框的值成员
            cmbStudentClass.DataSource = studentclass;//绑定下拉框的数据源
        }
        /// <summary>
        /// 复选框按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)                     //判断是否点中选择多选框所在的列（列编号与其其位置有关）
            {
                //获取当前行当前列的单元格
                DataGridViewCheckBoxCell cell =(DataGridViewCheckBoxCell)dgvStudentInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null && (bool)cell.Value)    //不为空并且已选中 ()
                {
                    cell.Value = false;
                }
                else
                {
                    cell.Value = true;
                }
            }
        }
        /// <summary>
        /// 全选按钮单击的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            flag = !flag;
            for (int i = 0; i < dgvStudentInfo.Rows.Count; i++)
            {
                dgvStudentInfo.Rows[i].Cells[0].Value = flag;
            }
        }


    }
}
