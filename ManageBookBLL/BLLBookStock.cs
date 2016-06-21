using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.DAL;
using ManageBook.Modle;
using System.Data;

namespace ManageBook.BLL
{
    public class BLLBookStock
    {
        private DALBookStock dalbs =new DALBookStock();
        public void UpdateBookStock(BookStock bookstock) 
        {
            dalbs.UpdateBookStock(bookstock);
        }
        public DataSet SelectBookStock()
        {
           return dalbs.SelectBookStock();
        }
        public DataSet SelectBookStock(int n, string info)
        {
            return dalbs.SelectBookStock(n,info);
        }
        public DataSet NoArriveBook()
        {
            return dalbs.NoArriveBook();
        }


        private DataTable dt;
        /// <summary>
        /// 返回类型改成DataTable
        /// </summary>
        /// <param name="index"></param>
        /// <param name="bookStock"></param>
        /// <returns></returns>
        public DataTable GetAllBookStock(int index, string bookStock)
        {
            dt = dalbs.GetAllBookStock(index, bookStock).Tables[0];
            return dt;

        }
    }
}
