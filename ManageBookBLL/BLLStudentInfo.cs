using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ManageBook.DAL;
using ManageBook.Modle;

namespace ManageBook.BLL
{
    public class BLLStudentInfo
    {
        private DALStudentInfo dalstudentInfo = new DALStudentInfo();
        public List<StudentInfoBusiness> GetAllStudentInfo(string Guanjianzi , string txt)
        {
            return dalstudentInfo.GetAllStudentInfo(Guanjianzi, txt);
        }

        public void InsertStudentInfo(StudentInfoBusiness studentInfo)
        {
            dalstudentInfo.InsertStudentInfo(studentInfo);
        }

        //public void DeleteStudentInfo(string studentNumber)
        //{
        //    dalstudentInfo.DeleteStudentInfo(studentNumber);
        //}

        //public DataTable GetAllStudentInfo(int index, string info)
        //{
        //    dt = dalstudentInfo.GetAllStudentInfo(index, info).Tables[0];
        //    return dt;
        //}

    }
}
