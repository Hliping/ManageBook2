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
    public partial class FrmStudentInfoMoney : Form
    {
        #region 私有变量
        BLLStudentExpense bllStudentExpense = new BLLStudentExpense();
        BLLCommon bllCommon = new BLLCommon();
        #endregion

        public FrmStudentInfoMoney()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmStudentInfoMoney_Load(object sender, EventArgs e)
        {
            CmbCollegeInfo();  //获取绑定学院下拉框信息的方法
            CmbSchoolTermInfo();  //获取绑定学年学期信息的方法
            dgvStudentDetail.AutoGenerateColumns = false; //禁止自动添加数据
            dgvStudentDetail.DataSource = bllStudentExpense.GetAllStudentExpense(); //邦定列表的数据源
        }
        /// <summary>
        /// 学院下拉框信息改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCollege_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(cmbCollege.SelectedValue);
            cmbGetAllMajor(n);
            getcmbInfo();  // 自定义的查询学生费用明细的空方法
        }
        /// <summary>
        /// 专业下拉框信息改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMajor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int MajorInfoID = Convert.ToInt32(cmbMajor.SelectedValue);
            cmbGetAllClassInfobyMajorId(MajorInfoID);
            getcmbInfo();  // 自定义的查询学生费用明细的空方法
        }
        /// <summary>
        /// 班级下拉框信息改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStudentClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getcmbInfo();  // 自定义的查询学生费用明细的空方法
        }
        /// <summary>
        /// 学年学期下拉框信息改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSchoolTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getcmbInfo();  // 自定义的查询学生费用明细的空方法
        }
        /// <summary>
        /// 绑定学年学期下拉框的方法
        /// </summary>
        private void CmbSchoolTermInfo()
        {
            List<SchoolTerm> studentclass = bllCommon.GetAllSchoolTerm();
            studentclass.Insert(0, new SchoolTerm { TermName = "——请选择学年——", SchoolTermID = 0 });
            cmbSchoolTerm.DisplayMember = "TermName";  //绑定下拉框要显示的字段
            cmbSchoolTerm.ValueMember = "SchoolTermID";  //绑定下拉框的值字段
            cmbSchoolTerm.DataSource = studentclass;   //绑定下拉框的数据源
        }
        /// <summary>
        /// 绑定学院下拉框的方法
        /// </summary>
        private void CmbCollegeInfo()
        {
            List<CollegeInfo> collegeinfo = bllCommon.GetAllCollegeInfo();
            collegeinfo.Insert(0, new CollegeInfo { CollegeID = 0, CollegeName = "——请选择学院——" });
            cmbCollege.DisplayMember = "CollegeName";  //绑定下拉框要显示的字段
            cmbCollege.ValueMember = "CollegeID";  //绑定下拉框的值字段
            cmbCollege.DataSource = collegeinfo;  //绑定下拉框的数据源
        }
        /// <summary>
        /// 自定义的以学院编号获取专业信息的空方法
        /// </summary>
        /// <param name="collegeID">学院编号</param>
        private void cmbGetAllMajor(int collegeID)
        {
            List<MajorInfo> majorInfo = bllCommon.GetAllMajorInfo(collegeID); 
            majorInfo.Insert(0, new MajorInfo { MajorSimple = "——请选择专业——", MajorInfoID = 0 });
            cmbMajor.DisplayMember = "MajorSimple"; //绑定下拉框要显示的字段
            cmbMajor.ValueMember = "MajorInfoID";  //绑定下拉框的值字段
            cmbMajor.DataSource = majorInfo;   //绑定下拉框的数据源
        }
        /// <summary>
        /// 自定义的以专业编号获取班级信息的空方法
        /// </summary>
        /// <param name="majorInfoID">专业编号</param>
        private void cmbGetAllClassInfobyMajorId(int majorInfoID) //以专业编号和年级信息获取年级的方法
        {
            List<StudentClass> studentInfo = bllCommon.GetAllStudentClassbyMajorId(majorInfoID);
            studentInfo.Insert(0, new StudentClass { ClassName = "——请选择班级——", StudentClassID = 0 });
            cmbStudentClass.DisplayMember = "ClassName";  //绑定下拉框要显示的字段
            cmbStudentClass.ValueMember = "StudentClassID";  //绑定下拉框的值字段
            cmbStudentClass.DataSource = studentInfo;   //绑定下拉框的数据源
        }
        /// <summary>
        /// 自定义的查询学生费用明细的空方法
        /// </summary>
        private void getcmbInfo()
        {
            StudentExpense studentexpense = new StudentExpense();
            try
            {
                studentexpense.CollegeID = Convert.ToInt32(cmbCollege.SelectedValue); //获取学院编号
                studentexpense.MajorInfoID = Convert.ToInt32(cmbMajor.SelectedValue); //获取专业编号
                studentexpense.StudentClassID = Convert.ToInt32(cmbStudentClass.SelectedValue);  //获取班级编号
                studentexpense.SchoolTermID = Convert.ToInt32(cmbSchoolTerm.SelectedValue);  //获取学年学期编号
                dgvStudentDetail.DataSource= bllStudentExpense.GetAllStudentExpensebyStudentExpense(studentexpense);  //为列表重新绑定数据源
            } 
            catch (Exception)
            {

                //throw;
            }
        }
        /// <summary>
        /// 导出信息到Excel的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcel_Click(object sender, EventArgs e)
        {
            data(dgvStudentDetail, true);
        }
        /// <summary>
        /// 自定义的导出信息到Excel的方法
        /// </summary>
        /// <param name="dgv">代表要导出的数据表</param>
        /// <param name="flag">判断值</param>
        /// <returns></returns>
        private bool data(DataGridView dgv, bool flag)
        {
            if (dgv.Rows.Count == 0)
            {
                return false;
            }
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); //实例化Excel表格
            excel.Application.Workbooks.Add(true);
            excel.Visible = flag;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                }
            }
            return true;
        }
    }
}
