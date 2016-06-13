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

        public DataSet BookStock()
        {
            return dalbs.BookStock();
        
        }
        public IList<BookStock> GetAllBookStock()
        {
            return dalbs.GetAllBookStock();
        }
    }
}
