using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.DAL;
using ManageBook.Modle;

namespace ManageBook.BLL
{
    public class BLLNoArriveBook
    {
        private DALNoArriveBook dalno = new DALNoArriveBook();
        public List<NoArriveBook> GetAllInfo(int index, string txt)
        {
            return dalno.GetAllInfo(index,txt);
        }
        public void UpdateBookStock(string txt)
        {
            dalno.UpdateBookStock(txt);
        }
    }
}
