using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.Modle;
using System.Data.SqlClient;

namespace ManageBook.DAL
{
    public class DALGetBookBusiness
    {
        public List<GetBookBusiness> GetAllGetBook()
        {
            List<GetBookBusiness> list = new List<GetBookBusiness>();
            string sql = "SELECT GetBook.GetBookID, GetBook.GetBookNum, GetBook.Signer, StudentClass.ClassName, PlanBook.BookName, PlanBook.ISBN, PlanBook.Publish, PlanBook.Author,Course.CourseType FROM  GetBook INNER JOIN PlanBook ON GetBook.PlanBookID = PlanBook.PlanBookID INNER JOIN StudentClass ON GetBook.StudentClassID = StudentClass.StudentClassID INNER JOIN Course ON PlanBook.CourseID = Course.CourseID";
            using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql))
            {
                while (sdr.Read())
                {
                    GetBookBusiness getbook = new GetBookBusiness();
                    
                    getbook.BookName = sdr["BookName"].ToString();
                    getbook.Author= sdr["Author"].ToString();
                    getbook.ClassName = sdr["ClassName"].ToString();
                    getbook.CourseType= sdr["CourseType"].ToString();
                    getbook.GetBookID = Convert.ToInt32(sdr["GetBookID"].ToString());
                    getbook.GetBookNum = Convert.ToInt32(sdr["GetBookNum"].ToString());
                    getbook.ISBN = sdr["ISBN"].ToString();
                    getbook.Publish = sdr["Publish"].ToString();
                    getbook.Signer= sdr["Signer"].ToString();
                    list.Add(getbook);
                }
            }
            return list;
        }
    }
}
