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
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            
            InitializeComponent();
        }
        private BLLCommon bllCommon = new BLLCommon();
        private BLLStudentInfo bllStudentInfo = new BLLStudentInfo();

        private void FrmStudentInfo_Load(object sender, EventArgs e)
        {
            CmbData(); 
            cmbGetAllGrade();
            dgvQuery.DataSource = bllStudentInfo.GetAllStudentInfo(null,null);
        }
        private void CmbData()  //查询各个表的信息赋值给下拉框
        {
            //cmbCollege.Items.Insert(0, "——请选择学院——"); //添加下拉框第一项的值
            List<CollegeInfo> collegeinfo = bllCommon.GetAllCollegeInfo();         //调用GetAllCollegeInfo()方法获取学院信息并赋值给数组a
            collegeinfo.Insert(0, new CollegeInfo { CollegeName = "——请选择学院——", CollegeID = 0 });
            cmbCollege.DisplayMember = "CollegeName";
            cmbCollege.ValueMember = "CollegeID";
            cmbCollege.DataSource = collegeinfo;
        }

        private void cmbCollege_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(cmbCollege.SelectedValue);
            cmbGetAllMajor(n);
            cmbMajor.Enabled = true;
            cmbGrade.Enabled = false;
            cmbGrade.Text = "——请选择年级——";
            cmbStudentClass.Enabled = false;
            cmbStudentClass.Text = "——请选择班级——";
            //MessageBox.Show(n.ToString());
        }
        private void cmbGetAllMajor(int collegeID)  //以学院编号获取专业的方法
        {
            List<MajorInfo> majorInfo = bllCommon.GetAllMajorInfo(collegeID);
            majorInfo.Insert(0, new MajorInfo { MajorSimple = "——请选择专业——", MajorInfoID = 0 });
            cmbMajor.DisplayMember = "MajorSimple";
            cmbMajor.ValueMember = "MajorInfoID";
            cmbMajor.DataSource = majorInfo;
        }
        private int majorInfoID;
        private void cmbMajor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            majorInfoID = Convert.ToInt32(cmbMajor.SelectedValue);
            //MessageBox.Show(majorInfoID.ToString());
            cmbGrade.Enabled = true;
            cmbGrade.Text = "——请选择年级——";
            cmbStudentClass.Enabled = false;
            cmbStudentClass.Text = "——请选择班级——";
        }
        private void cmbGetAllGrade() //获取年级的方法
        {
            List<GradeInfo> gradeInfo = bllCommon.GetAllGradeInfo();
            gradeInfo.Insert(0, new GradeInfo {   GradeName = "——请选择年级——",  GradeInfoID = 0 });
            cmbGrade.DisplayMember = "GradeName";
            cmbGrade.ValueMember = "GradeInfoID";
            cmbGrade.DataSource = gradeInfo;
        }
        private int gradeInfoID;
        private void cmbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gradeInfoID = Convert.ToInt32(cmbGrade.SelectedValue);
            cmbStudentClass.Enabled = true;
            //MessageBox.Show(gradeInfoID.ToString());
            cmbGetAllClassInfo(majorInfoID, gradeInfoID);
        }
        private void cmbGetAllClassInfo(int majorInfoID,int gradeInfoID) //以专业编号和年级信息获取年级的方法
        {
            List<StudentClass> studentInfo = bllCommon.GetAllStudentClass(majorInfoID, gradeInfoID);
            studentInfo.Insert(0, new StudentClass {  ClassName = "——请选择班级——",   StudentClassID = 0 });
            cmbStudentClass.DisplayMember = "ClassName";
            cmbStudentClass.ValueMember = "StudentClassID";
            cmbStudentClass.DataSource = studentInfo;
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (btnAppend.Text == "添加记录")
            {
                if (txtStudentName.Text.Trim() == "" || txtStudentNumber.Text.Trim() == "") { lbl.Text = "请完整信息的填写"; }
                else
                {
                    bllStudentInfo.InsertStudentInfo(text());
                    dgvQuery.DataSource = bllStudentInfo.GetAllStudentInfo(null, null);
                    txtStudentName.Text = string.Empty;
                    txtStudentNumber.Text = string.Empty;
                    txtStudentMarket.Text = string.Empty;
                    rbtnMan.Checked = true;
                    lbl.Text = "";
                }
            }
            else
            {
                
               // MessageBox.Show(text().StudentInfoID.ToString());
               bllStudentInfo.UpdateStudentInfo(text());
               dgvQuery.DataSource = bllStudentInfo.GetAllStudentInfo(null, null);
                btnAppend.Text = "添加记录";
                CmbData();
                cmbGrade.Text = "——请选择年级——";
                cmbStudentClass.Text = "——请选择班级——";
                cmbMajor.Text = "——请选择专业——";
                cmbCollege.Text = "——请选择学院——";
                txtStudentName.Text = string.Empty;
                txtStudentNumber.Text = string.Empty;
                txtStudentMarket.Text = string.Empty;
                rbtnMan.Checked = true;
                lbl.Text = "";
                cmbGrade.Enabled = false;
                cmbMajor.Enabled = false;
                cmbStudentClass.Enabled = false;
                btnAppend.Enabled = false;
            }
        
        }
        public StudentInfoBusiness text()
        {
            StudentInfoBusiness studentinfo = new StudentInfoBusiness();
            studentinfo.StudentClassID = Convert.ToInt32(cmbStudentClass.SelectedValue);
            studentinfo.StudentName = txtStudentName.Text.Trim();
            studentinfo.StudentNumber = txtStudentNumber.Text.Trim();
            studentinfo.StudentSex = "男";
            if (rbtnWoman.Checked) studentinfo.StudentSex = "女";
            studentinfo.StudentMarket = txtStudentMarket.Text.Trim();
            try
            {
                studentinfo.StudentInfoID = Convert.ToInt32(dgvQuery.CurrentRow.Cells["学生信息编号"].Value);
            }
            catch (Exception)
            {
                //throw;
            }
            return studentinfo;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string txt = cmbCondition.SelectedItem.ToString();
            dgvQuery.DataSource = bllStudentInfo.GetAllStudentInfo(txt, txtCondition.Text);
        }

        private void cmbCondition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCondition.SelectedIndex == 0)
            {
                dgvQuery.DataSource = bllStudentInfo.GetAllStudentInfo(null, null);
                txtCondition.Text = string.Empty;
            }
        }

        private BLLExcel excel = new BLLExcel();
        
        private void btnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            open.Filter = "Excel文档|*.xlsx|03-07 excel文档|*.xls";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                string openFile = open.FileName;
                DataSet ds= excel.ExcelToDataSet(openFile);
                CommonStatic.dt = ds.Tables[0];
                CommonStatic.recordNum = CommonStatic.dt.Rows.Count;
                FrmExcel frm = new FrmExcel();
                frm.Show();
                frm.dgvExcel.DataSource = CommonStatic.dt;
            }
        }

        private void cntxtmsDelete_Click(object sender, EventArgs e)
        {
            string studentNumber = dgvQuery.CurrentRow.Cells["学生信息编号"].Value.ToString();
            bllStudentInfo.DeleteStudentInfo(studentNumber);
            dgvQuery.DataSource = bllStudentInfo.GetAllStudentInfo(null, null);
        }

        private void cntxtmsUpdate_Click(object sender, EventArgs e)
        {
            btnAppend.Text = "确认修改";
            txtStudentName.Text = dgvQuery.CurrentRow.Cells["姓名"].Value.ToString();
            txtStudentNumber.Text = dgvQuery.CurrentRow.Cells["学号"].Value.ToString();
            txtStudentMarket.Text = dgvQuery.CurrentRow.Cells["备注"].Value.ToString();
            if (dgvQuery.CurrentRow.Cells["性别"].Value.ToString() == "男") { rbtnMan.Checked = true; } else { rbtnWoman.Checked = true; }
            CmbData();
            cmbGrade.Enabled = false;
            cmbMajor.Enabled = false;
            cmbStudentClass.Enabled = false;
            btnAppend.Enabled = false;
        }
        private void cmbStudentClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbStudentClass.SelectedValue) > 0) { btnAppend.Enabled = true; }
        }

    }

}

