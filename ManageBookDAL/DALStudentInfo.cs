using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using ManageBook.Modle;

namespace ManageBook.DAL
{
    public class DALStudentInfo
    {
        public List<StudentInfoBusiness> GetAllStudentInfo(string Guanjianzi,string txt)
        {
            List<StudentInfoBusiness> list = new List<StudentInfoBusiness>();
            StringBuilder sql = new StringBuilder("SELECT CollegeInfo.CollegeName, MajorInfo.MajorSimple, GradeInfo.GradeName, StudentClass.ClassName, StudentInfo.* FROM StudentInfo INNER JOIN StudentClass ON StudentInfo.StudentClassID = StudentClass.StudentClassID INNER JOIN MajorInfo ON StudentClass.MajorInfoID = MajorInfo.MajorInfoID INNER JOIN GradeInfo ON StudentClass.GradeInfoID = GradeInfo.GradeInfoID INNER JOIN CollegeInfo ON StudentClass.CollegeID = CollegeInfo.CollegeID where 1=1");
            switch (Guanjianzi)
            {
                case "学生姓名":
                    sql.Append(string.Format(" and StudentInfo.StudentName like '{0}'",txt));
                    break;
                case "学生学号":
                    sql.Append(string.Format(" and StudentInfo.StudentNumber like '{0}'", txt));
                    break;
                case "班级名称":
                    sql.Append(string.Format(" and StudentClass.ClassName like '{0}'", txt));
                    break;
                case "专业名称":
                    sql.Append(string.Format(" and MajorInfo.MajorSimple like '{0}'", txt));
                    break;
                case "学院名称":
                    sql.Append(string.Format(" and CollegeInfo.CollegeName like '{0}'", txt));
                    break;
                case "年级名称":
                    sql.Append(string.Format(" and GradeInfo.GradeName like '{0}'", txt));
                    break;
                default:
                    break;

            }
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql.ToString()))
            {
                while (sdr.Read())
                {
                    StudentInfoBusiness studentinfo = new StudentInfoBusiness();
                    studentinfo.StudentName = sdr["StudentName"].ToString();
                    studentinfo.StudentNumber = sdr["StudentNumber"].ToString();
                    studentinfo.StudentMarket = sdr["StudentMarket"].ToString();
                    studentinfo.StudentSex = sdr["StudentSex"].ToString();
                    studentinfo.CollegeName = sdr["CollegeName"].ToString();
                    studentinfo.ClassName = sdr["ClassName"].ToString();
                    studentinfo.GradeName = sdr["GradeName"].ToString();
                    studentinfo.MajorSimple = sdr["MajorSimple"].ToString();
                    studentinfo.StudentClassID = Convert.ToInt32(sdr["StudentClassID"]);
                    studentinfo.StudentInfoID = Convert.ToInt32(sdr["StudentInfoID"]);

                    list.Add(studentinfo);
                }
            }
            return list;
        }

        public void InsertStudentInfo(StudentInfoBusiness studentInfo)
        {
            string sql = "insert into StudentInfo values(@StudentClassID,@StudentName,@StudentNumber,@StudentSex,@StudentMarket)";
            SqlParameter[] parameter = { new SqlParameter("@StudentClassID",studentInfo.StudentClassID),
                                         new SqlParameter("@StudentName",studentInfo.StudentName),
                                         new SqlParameter("@StudentNumber",studentInfo.StudentNumber),
                                         new SqlParameter("@StudentSex",studentInfo.StudentSex),
                                         new SqlParameter("@StudentMarket",studentInfo.StudentMarket)};
            DBHelpers.UpdateInfo(sql, parameter);
        }
    }
}
