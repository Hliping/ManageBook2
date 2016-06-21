using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using ManageBook.Modle;

namespace ManageBook.DAL
{
    public class DALStudentExpense
    {
        /// <summary>
        /// 描述：获取所有学生信息
        /// </summary>
        /// <returns></returns>
        public IList<StudentExpense> GetAllStudentExpense()
        {
            IList<StudentExpense> liststudnetExpense = new List<StudentExpense>();
            string sql = "SELECT  CollegeInfo.CollegeName, MajorInfo.MajorName, StudentClass.ClassName, StudentInfo.StudentName, StudentInfo.StudentNumber, StudentInfo.StudentSex, SchoolTerm.TermName, PlanBook.BookName, PlanBook.ISBN, PlanBook.Author, PlanBook.Publish, PlanBook.Price, BookStock.Discount, BookStock.NetPrice, GrantBook.GetBookNum FROM  BookStock INNER JOIN SchoolTerm INNER JOIN GrantBook INNER JOIN StudentInfo INNER JOIN CollegeInfo INNER JOIN StudentClass ON CollegeInfo.CollegeID = StudentClass.CollegeID INNER JOIN  MajorInfo ON StudentClass.MajorInfoID = MajorInfo.MajorInfoID ON StudentInfo.StudentClassID = StudentClass.StudentClassID ON  GrantBook.StudentInfoID = StudentInfo.StudentInfoID ON SchoolTerm.SchoolTermID = GrantBook.SchoolTermID INNER JOIN PlanBook ON GrantBook.PlanBookID = PlanBook.PlanBookID ON BookStock.PlanBookID = PlanBook.PlanBookID";
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql))
            {
                while (sdr.Read())
                {
                    StudentExpense studentExpense = new StudentExpense();
                    studentExpense.ClassName = sdr["ClassName"].ToString();
                    studentExpense.CollegeName = sdr["CollegeName"].ToString();
                    studentExpense.MajorName = sdr["MajorName"].ToString();
                    studentExpense.StudentName = sdr["StudentName"].ToString();
                    studentExpense.StudentNumber = sdr["StudentNumber"].ToString();
                    studentExpense.StudentSex = sdr["StudentSex"].ToString();
                    studentExpense.GetBookNum =Convert.ToInt32(sdr["GetBookNum"]);
                    studentExpense.BookName = sdr["BookName"].ToString();
                    studentExpense.Author = sdr["Author"].ToString();
                    studentExpense.Publish = sdr["Publish"].ToString();
                    studentExpense.Price = float.Parse(sdr["Price"].ToString());
                    studentExpense.TermName = sdr["TermName"].ToString();
                    studentExpense.Discount = float.Parse(sdr["Discount"].ToString());
                    studentExpense.ISBN = sdr["ISBN"].ToString();
                    studentExpense.NetPrice = float.Parse(sdr["NetPrice"].ToString());
                    liststudnetExpense.Add(studentExpense);
                }
            }
            return liststudnetExpense;
        }
        /// <summary>
        /// 通过条件获取学生费用明细
        /// </summary>
        /// <param name="studentexpense">实体类StudentExpense</param>
        /// <returns></returns>
        public IList<StudentExpense> GetAllStudentExpensebyStudentExpense(StudentExpense studentexpense)
        {
            IList<StudentExpense> liststudnetExpense = new List<StudentExpense>();  
            StringBuilder sql = new StringBuilder("SELECT  CollegeInfo.CollegeName, MajorInfo.MajorName, StudentClass.ClassName, StudentInfo.StudentName, StudentInfo.StudentNumber, StudentInfo.StudentSex, SchoolTerm.TermName, PlanBook.BookName, PlanBook.ISBN, PlanBook.Author, PlanBook.Publish, PlanBook.Price, BookStock.Discount, BookStock.NetPrice, GrantBook.GetBookNum FROM  BookStock INNER JOIN SchoolTerm INNER JOIN GrantBook INNER JOIN StudentInfo INNER JOIN CollegeInfo INNER JOIN StudentClass ON CollegeInfo.CollegeID = StudentClass.CollegeID INNER JOIN  MajorInfo ON StudentClass.MajorInfoID = MajorInfo.MajorInfoID ON StudentInfo.StudentClassID = StudentClass.StudentClassID ON  GrantBook.StudentInfoID = StudentInfo.StudentInfoID ON SchoolTerm.SchoolTermID = GrantBook.SchoolTermID INNER JOIN PlanBook ON GrantBook.PlanBookID = PlanBook.PlanBookID ON BookStock.PlanBookID = PlanBook.PlanBookID where 1=1");
            if (studentexpense.CollegeID > 0)   //判断获取的学院编号是否大于0
            {
                sql.Append(string.Format(" and CollegeInfo.CollegeID = {0}",studentexpense.CollegeID)); //增加sql语句的where条件
            }
            if (studentexpense.MajorInfoID > 0)    //判断获取的专业编号是否大于0
            {
                sql.Append(string.Format(" and MajorInfo.MajorInfoID = {0}", studentexpense.MajorInfoID));  //增加sql语句的where条件
            }
            if (studentexpense.StudentClassID > 0)    //判断获取的班级编号是否大于0
            {
                sql.Append(string.Format(" and StudentClass.StudentClassID = {0}", studentexpense.StudentClassID));  //增加sql语句的where条件
            }
            if (studentexpense.SchoolTermID>0)   //判断获取的学年学期编号是否大于0
            {
                sql.Append(string.Format(" and SchoolTerm.SchoolTermID = {0}", studentexpense.SchoolTermID)); //增加sql语句的where条件
            }
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql.ToString()))
            {
                while (sdr.Read())
                {
                    StudentExpense studentExpense = new StudentExpense();
                    studentExpense.ClassName = sdr["ClassName"].ToString();
                    studentExpense.CollegeName = sdr["CollegeName"].ToString();
                    studentExpense.MajorName = sdr["MajorName"].ToString();
                    studentExpense.StudentName = sdr["StudentName"].ToString();
                    studentExpense.StudentNumber = sdr["StudentNumber"].ToString();
                    studentExpense.StudentSex = sdr["StudentSex"].ToString();
                    studentExpense.GetBookNum = Convert.ToInt32(sdr["GetBookNum"]);
                    studentExpense.BookName = sdr["BookName"].ToString();
                    studentExpense.Author = sdr["Author"].ToString();
                    studentExpense.Publish = sdr["Publish"].ToString();
                    studentExpense.Price = float.Parse(sdr["Price"].ToString());
                    studentExpense.TermName = sdr["TermName"].ToString();
                    studentExpense.Discount = float.Parse(sdr["Discount"].ToString());
                    studentExpense.ISBN = sdr["ISBN"].ToString();
                    studentExpense.NetPrice = float.Parse(sdr["NetPrice"].ToString());
                    liststudnetExpense.Add(studentExpense);
                }
            }
            return liststudnetExpense;
        }
    }
}
