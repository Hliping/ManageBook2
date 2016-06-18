using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.DAL;
using ManageBook.Modle;
using System.Data;

namespace ManageBook.BLL
{
    public class BLLGrantBook
    {
        #region 私有变量
        private DALGrantBook getbookbusiness = new DALGrantBook();
        #endregion

        public List<GetBookBusiness> GetAllGetBook()
        {
            return getbookbusiness.GetAllGetBook();
        }
        /// <summary>
        /// 获取库存信息的方法
        /// </summary>
        /// <param name="TypeID">可以选择sql语句的调用</param>
        /// <param name="ID">ID可以表示学院信息ID   也可以表示班级信息ID</param>
        /// <returns></returns>
        public List<BookStockBusiness> GetAllBookStock(int TypeID, int ID)
        {
            return getbookbusiness.GetAllBookStock(TypeID, ID);
        }
        /// <summary>
        /// 获取学生信息的方法
        /// </summary>
        /// <param name="TypeID">可以选择sql语句的调用</param>
        /// <param name="ID">ID可以表示学院信息ID   也可以表示班级信息ID</param>
        /// <returns></returns>
        public List<StudentInfoBusiness> GetAllStudentInfo(int TypeID, int ID)
        {
            return getbookbusiness.GetAllStudentInfo(TypeID, ID);
        }
        /// <summary>
        /// 获取教材发放明细的方法
        /// </summary>
        /// <param name="TypeID">可以选择sql语句的调用</param>
        /// <param name="ID">ID可以表示学院信息ID   也可以表示班级信息ID</param>
        /// <returns></returns>
        public List<GrantBookBusiness> GetAllGrantBookInfo(int TypeID, int ID)
        {
            return getbookbusiness.GetAllGrantBookInfo(TypeID, ID);
        }
        /// <summary>
        /// 添加发放明细的方法
        /// </summary>
        /// <param name="book">PlanBook实体类</param>
        /// <param name="nums">自定义的一个int类型的数组</param>
        public void InsertGrantBook(PlanBook book, int[] nums)
        {
            getbookbusiness.InsertGrantBook(book, nums);
        }
        /// <summary>
        /// 删除发放明细的方法
        /// </summary>
        /// <param name="grantId">教材发放明细的编号</param>
        public void DeleteGrantBookByGrantID(int grantId)
        {
            getbookbusiness.DeleteGrantBookByGrantID(grantId);
        }
    }
}
