using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.Modle;
using System.Data;
using System.Data.SqlClient;

namespace ManageBook.DAL
{
    public class DALGrantBook
    {
        public List<GetBookBusiness> GetAllGetBook()
        {
            List<GetBookBusiness> list = new List<GetBookBusiness>();
            string sql = "SELECT GetBook.GetBookID, GetBook.GetBookNum, GetBook.Signer, StudentClass.ClassName, PlanBook.BookName, PlanBook.ISBN, PlanBook.Publish, PlanBook.Author,Course.CourseType FROM  GetBook INNER JOIN PlanBook ON GetBook.PlanBookID = PlanBook.PlanBookID INNER JOIN StudentClass ON GetBook.StudentClassID = StudentClass.StudentClassID INNER JOIN CollegeInfo on CollegeInfo.CollegeID=StudentClass.CollegeID INNER JOIN Course ON PlanBook.CourseID = Course.CourseID where 1=1";
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql))
            {
                while (sdr.Read())
                {
                    GetBookBusiness getbook = new GetBookBusiness();
                    getbook.BookName = sdr["BookName"].ToString();
                    getbook.Author = sdr["Author"].ToString();
                    getbook.ClassName = sdr["ClassName"].ToString();
                    getbook.CourseType = sdr["CourseType"].ToString();
                    getbook.GetBookID = Convert.ToInt32(sdr["GetBookID"].ToString());
                    getbook.GetBookNum = Convert.ToInt32(sdr["GetBookNum"].ToString());
                    getbook.ISBN = sdr["ISBN"].ToString();
                    getbook.Publish = sdr["Publish"].ToString();
                    getbook.Signer = sdr["Signer"].ToString();
                    list.Add(getbook);
                }
            }
            return list;
        }
        public List<BookStockBusiness> GetAllBookStock(int m,int n)
        {
            List<BookStockBusiness> list = new List<BookStockBusiness>();
            StringBuilder sql = new StringBuilder("SELECT StudentClass.ClassName, SchoolTerm.TermSimple, Course.CourseType,PlanBook.CourseName, PlanBook.BookName, PlanBook.ISBN as 'ISBN', PlanBook.Author, PlanBook.Publish,PlanBook.BookTotalNum FROM  BookStock INNER JOIN PlanBook ON BookStock.PlanBookID = PlanBook.PlanBookID INNER JOIN SchoolTerm ON PlanBook.SchoolTermID = SchoolTerm.SchoolTermID INNER JOIN StudentClass ON PlanBook.StudentClassID = StudentClass.StudentClassID INNER JOIN CollegeInfo on CollegeInfo.CollegeID=StudentClass.CollegeID INNER JOIN Course ON PlanBook.CourseID = Course.CourseID where 1=1");
          
            if (n == 0) { sql.ToString(); }
            if (m == 1)
            {
                sql.Append(string.Format(" and CollegeInfo.CollegeID ={0}",n));
            }
            if (m == 2)
            {
                sql.Append(string.Format(" and StudentClass.StudentClassID ={0}", n));
            }
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql.ToString()))
            {
                while (sdr.Read())
                {
                    BookStockBusiness book = new BookStockBusiness();
                    book.ClassName = sdr["ClassName"].ToString();
                    book.TermSimple= sdr["TermSimple"].ToString();
                    book.CourseType = sdr["CourseType"].ToString();
                    book.CourseName= sdr["CourseName"].ToString();
                    book.BookName= sdr["BookName"].ToString();
                    book.Author = sdr["Author"].ToString();
                    book.Publish= sdr["Publish"].ToString();
                    book.ISBN= sdr["ISBN"].ToString();
                    book.BookTotalNum = Convert.ToInt32(sdr["BookTotalNum"]);
                    list.Add(book);
                }
            }
             return list;
        }

        public List<StudentInfoBusiness> GetAllStudentInfo()
        {
            List<StudentInfoBusiness> list = new List<StudentInfoBusiness>();
            string sql = "SELECT  StudentInfo.StudentInfoID,StudentInfo.StudentMarket, StudentClass.ClassName, StudentInfo.StudentName, StudentInfo.StudentNumber, StudentInfo.StudentSex, CollegeInfo.CollegeName, GradeInfo.GradeName, MajorInfo.MajorSimple FROM StudentInfo INNER JOIN StudentClass ON StudentInfo.StudentClassID = StudentClass.StudentClassID INNER JOIN  CollegeInfo ON StudentClass.CollegeID = CollegeInfo.CollegeID INNER JOIN  MajorInfo ON StudentClass.MajorInfoID = MajorInfo.MajorInfoID INNER JOIN GradeInfo ON StudentClass.GradeInfoID = GradeInfo.GradeInfoID";
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql))
            {
                while (sdr.Read())
                {
                    StudentInfoBusiness student = new StudentInfoBusiness();
                    student.ClassName = sdr["ClassName"].ToString();
                    student.CollegeName = sdr["CollegeName"].ToString();
                    //student.GradeName = sdr["GradeName"].ToString();
                    student.MajorSimple = sdr["MajorSimple"].ToString();
                    student.StudentInfoID = Convert.ToInt32(sdr["StudentInfoID"]);
                    student.StudentName = sdr["StudentName"].ToString();
                    student.StudentNumber = sdr["StudentNumber"].ToString();
                    student.StudentSex = sdr["StudentSex"].ToString();
                    student.StudentMarket = sdr["StudentMarket"].ToString();
                    list.Add(student);

                }
            }
            return list;
        }
        public List<GrantBookBusiness> GetAllGrantBookInfo()
        {
            List<GrantBookBusiness> list = new List<GrantBookBusiness>();
            string sql = "SELECT  CollegeInfo.CollegeName,Course.CourseType, MajorInfo.MajorSimple, GradeInfo.GradeSimple, SchoolTerm.TermName, StudentInfo.StudentName,StudentInfo.StudentNumber, StudentInfo.StudentSex, StudentClass.ClassName, GrantBook.GetBookNum, PlanBook.CourseName, PlanBook.BookName,PlanBook.CourseName, PlanBook.ISBN, PlanBook.Author, PlanBook.Publish FROM GradeInfo INNER JOIN StudentClass ON GradeInfo.GradeInfoID = StudentClass.GradeInfoID INNER JOIN CollegeInfo ON StudentClass.CollegeID = CollegeInfo.CollegeID INNER JOIN MajorInfo ON StudentClass.MajorInfoID = MajorInfo.MajorInfoID INNER JOIN PlanBook INNER JOIN GrantBook ON PlanBook.PlanBookID = GrantBook.PlanBookID INNER JOIN StudentInfo ON GrantBook.StudentInfoID = StudentInfo.StudentInfoID ON StudentClass.StudentClassID = StudentInfo.StudentClassID INNER JOIN Course on Course.CourseID=PlanBook.CourseID INNER JOIN SchoolTerm ON GrantBook.SchoolTermID = SchoolTerm.SchoolTermID";
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql))
            {
                while (sdr.Read())
                {
                    GrantBookBusiness grant = new GrantBookBusiness();
                    grant.CollegeName = sdr["CollegeName"].ToString();
                    grant.MajorSimple = sdr["MajorSimple"].ToString();
                    grant.GradeSimple = sdr["GradeSimple"].ToString();
                    grant.TermName = sdr["TermName"].ToString();
                    grant.ClassName= sdr["ClassName"].ToString();
                    grant.StudentName = sdr["StudentName"].ToString();
                    grant.StudentNumber = sdr["StudentNumber"].ToString();
                    grant.StudentSex = sdr["StudentSex"].ToString();
                    grant.BookName = sdr["BookName"].ToString();
                    grant.Author = sdr["Author"].ToString();
                    grant.Publish = sdr["Publish"].ToString();
                    grant.ISBN = sdr["ISBN"].ToString();
                    grant.GetBookNum= sdr["GetBookNum"].ToString();
                    grant.CourseName = sdr["CourseName"].ToString();
                    grant.CourseType = sdr["CourseType"].ToString();
                    list.Add(grant);
                    
                }
            }
            return list;
        }


        //方法的结尾
    }
}
