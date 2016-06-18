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
        private BLLGrantBook bllbookbusiness = new BLLGrantBook(); //教材发放明细的业务逻辑类
        private BLLCommon bllcommon = new BLLCommon();  //公共业务逻辑类
        private bool flag = false;  //自定义一个bool类型的变量 在全选/取消中使用
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
            dgvBookStock.AutoGenerateColumns = false;    //禁止自动添加数据
            dgvBookStock.DataSource = bllbookbusiness.GetAllBookStock(0,0); //绑定数据源 第一个0代表要调用的sql语句 第二个0表示的是学院信息ID和班级信息ID
        }
        /// <summary>
        /// 绑定学生信息列表数据的方法
        /// </summary>
        public void dgvStudentAllInfo()
        {
            dgvStudentInfo.AutoGenerateColumns = false; //禁止自动添加数据
            dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(0,0);//绑定数据源 第一个0代表要调用的sql语句 第二个0表示的是学院信息ID和班级信息ID
        }
        /// <summary>
        /// 绑定教材发放明细列表数据的方法
        /// </summary>
        public void dgvGrantBookAllInfo()
        {
            dgvGrantBook.AutoGenerateColumns = false; //禁止自动添加数据
            dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(0,0);//绑定数据源 第一个0代表要调用的sql语句 第二个0表示的是学院信息ID和班级信息ID
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
                dgvBookStock.DataSource= bllbookbusiness.GetAllBookStock(1, collegeID);   //绑定数据源 第一个1代表要调用的sql语句 第二个collegeID表示的是学院信息ID或班级信息ID
                dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(1, collegeID);   //绑定数据源 第一个1代表要调用的sql语句 第二个collegeID表示的是学院信息ID或班级信息ID
                dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(1, collegeID);   //绑定数据源 第一个1代表要调用的sql语句 第二个collegeID表示的是学院信息ID或班级信息ID
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
                dgvBookStock.DataSource = bllbookbusiness.GetAllBookStock(1, collegeID);  //绑定数据源 第一个1代表要调用的sql语句 第二个collegeID表示的是学院信息ID或班级信息ID
                dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(1, collegeID);  //绑定数据源 第一个1代表要调用的sql语句 第二个collegeID表示的是学院信息ID或班级信息ID
                dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(1, collegeID);  //绑定数据源 第一个1代表要调用的sql语句 第二个collegeID表示的是学院信息ID或班级信息ID
            }
            else
            {
                //MessageBox.Show(n.ToString());
                dgvBookStock.DataSource = bllbookbusiness.GetAllBookStock(2, ClassInfoID);  //绑定数据源 第一个1代表要调用的sql语句 第二个ClassInfoID表示的是学院信息ID或班级信息ID
                dgvStudentInfo.DataSource = bllbookbusiness.GetAllStudentInfo(2, ClassInfoID);  //绑定数据源 第一个1代表要调用的sql语句 第二个ClassInfoID表示的是学院信息ID或班级信息ID
                dgvGrantBook.DataSource = bllbookbusiness.GetAllGrantBookInfo(2, ClassInfoID);  //绑定数据源 第一个1代表要调用的sql语句 第二个ClassInfoID表示的是学院信息ID或班级信息ID
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
            if (e.ColumnIndex == 0)           //判断是否点中选择多选框所在的列（列编号与其其位置有关）
            {
                //获取当前行当前列的单元格
                DataGridViewCheckBoxCell cell =(DataGridViewCheckBoxCell)dgvStudentInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null && (bool)cell.Value)    //不为空并且已选中 ()
                {
                    cell.Value = false; //如果单元格的值为真值单击就变成假值
                }
                else
                {
                    cell.Value = true;  //否则单元格的值变成真值
                }
            }
        }
        /// <summary>
        /// 全选按钮单击的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllSelect_Click(object sender, EventArgs e)
        {
            flag = !flag;  //bool类型的flag取反值
            for (int i = 0; i < dgvStudentInfo.Rows.Count; i++) //遍历所有行
            {
                dgvStudentInfo.Rows[i].Cells[0].Value = flag;  //把所有行的值设为flag的值
            }
        }
        /// <summary>
        /// 选择/取消 按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookSelect_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvBookStock.CurrentRow.Cells["教材编号"].Value.ToString());
            if (dgvBookStock.Enabled == false) //单击后判断dgvBookStock是否是被禁用状态
            {
                dgvBookStock.Enabled = true;  //教材库存信息dgvBookStock变成启用状态
                btnAllSelect.Enabled = false;   //全选按钮btnAllSelect变成禁用状态
                btnAddGrantBook.Enabled = false;  //添加教材明细按钮btnAddGrantBook变成禁用状态
            }
            else
            {
                dgvBookStock.Enabled = false;   //教材库存信息dgvBookStock变成禁用状态
                btnAllSelect.Enabled = true;      //全选按钮btnAllSelect变成启用状态
                btnAddGrantBook.Enabled = true;   //添加教材明细按钮btnAddGrantBook变成启用状态
            }
            
        }
        /// <summary>
        /// 添加教材明细按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGrantBook_Click(object sender, EventArgs e)
        {
            int planbookid = Convert.ToInt32(dgvBookStock.CurrentRow.Cells["教材编号"].Value); //获取教材库存信息列表dgvBookStock中当前选中行的 列名为教材编号 的值
            List<int> nums = new List<int>();  //自定义一个int类型的数组
            for (int i = 0; i < dgvStudentInfo.Rows.Count; i++) //遍历学生信息列表dgvStudentInfo的所有行
            {
                try
                {
                    if (Convert.ToBoolean(dgvStudentInfo.Rows[i].Cells["选择"].Value)) //选中学生信息列表dgvStudentInfo中 列名为选择  的值  为真值
                    {
                        //MessageBox.Show(dgvStudentInfo.CurrentRow.Cells["学生信息编号"].Value.ToString());
                        nums.Add(Convert.ToInt32(dgvStudentInfo.Rows[i].Cells["学生信息编号"].Value)); //添加符合条件的 信息列表dgvStudentInfo中 列名为学生信息编号  的值 到数组中
                    }
                }
                catch (Exception)
                {
                    //throw;
                }
            }
            PlanBook book = new PlanBook();  //实例化教材预定实体类
            book.PlanBookID = Convert.ToInt32(dgvBookStock.CurrentRow.Cells["教材编号"].Value);  //为字段赋值
            book.SchoolTermID = Convert.ToInt32(dgvBookStock.CurrentRow.Cells["学期编号"].Value); //为字段赋值
            bllbookbusiness.InsertGrantBook(book, nums.ToArray());  //调用业务逻辑层中的  添加教材发放明细InsertGrantBook()方法
            dgvGrantBookAllInfo();  //重新绑定数据源
        }
        /// <summary>
        /// 右键删除按钮的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            int grantId = Convert.ToInt32(dgvGrantBook.CurrentRow.Cells["教材发放明细编号"].Value); //获取当前选中行的列名为教材发放明细编号的单元格的值
            bllbookbusiness.DeleteGrantBookByGrantID(grantId); //调用业务逻辑层中的 根据教材方法明细编号删除记录DeleteGrantBookByGrantID()的方法
            dgvGrantBookAllInfo();  //重新绑定数据源
        }
    }
}
