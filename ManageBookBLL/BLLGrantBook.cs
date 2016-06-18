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
        public List<BookStockBusiness> GetAllBookStock(int TypeID, int ID)
        {
            return getbookbusiness.GetAllBookStock(TypeID,ID);
        }
        public List<StudentInfoBusiness> GetAllStudentInfo(int TypeID, int ID)
        {
            return getbookbusiness.GetAllStudentInfo(TypeID, ID);
        }
        public List<GrantBookBusiness> GetAllGrantBookInfo(int TypeID, int ID)
        {
            return getbookbusiness.GetAllGrantBookInfo(TypeID, ID);
        }
    }
}
