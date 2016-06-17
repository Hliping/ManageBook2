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
        private DALGrantBook getbookbusiness = new DALGrantBook();
        public List<GetBookBusiness> GetAllGetBook()
        {
            return getbookbusiness.GetAllGetBook();
        }
        public List<BookStockBusiness> GetAllBookStock(int m,int n)
        {
            return getbookbusiness.GetAllBookStock(m,n);
        }
        public List<StudentInfoBusiness> GetAllStudentInfo()
        {
            return getbookbusiness.GetAllStudentInfo();
        }
        public List<GrantBookBusiness> GetAllGrantBookInfo()
        {
            return getbookbusiness.GetAllGrantBookInfo();
        }
    }
}
