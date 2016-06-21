using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ManageBook.DAL;
using ManageBook.Modle;
namespace ManageBook.BLL
{
    public class BLLStudentExpense
    {
        DALStudentExpense dalStudentExpense = new DALStudentExpense();
        /// <summary>
        /// 获取所有的学生费用明细
        /// </summary>
        /// <returns></returns>
        public IList<StudentExpense> GetAllStudentExpense()
        {
            return dalStudentExpense.GetAllStudentExpense();
        }
        /// <summary>
        /// 根据条件获取学生费用明细
        /// 功能：主要用来查询学生费用明细表
        /// </summary>
        /// <param name="studentexpense">查询的条件</param>
        /// <returns></returns>
        public IList<StudentExpense> GetAllStudentExpensebyStudentExpense(StudentExpense studentexpense)
        {
            return dalStudentExpense.GetAllStudentExpensebyStudentExpense(studentexpense);
        }
    }
}
