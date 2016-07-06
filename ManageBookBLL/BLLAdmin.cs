using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.Modle;
using ManageBook.DAL;

namespace ManageBook.BLL
{
    public class BLLAdmin
    {
        private DALAdmin daladmin = new DALAdmin();
        public bool GetAllAdmin(Admin admin)
        {
            return daladmin.GetAllAdmin(admin);
        }
    }
}
