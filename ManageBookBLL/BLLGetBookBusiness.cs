﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.DAL;
using ManageBook.Modle;

namespace ManageBook.BLL
{
    public class BLLGetBookBusiness
    {
        private DALGetBookBusiness getbookbusiness = new DALGetBookBusiness();
        public List<GetBookBusiness> GetAllGetBook()
        {
            return getbookbusiness.GetAllGetBook();
        }
    }
}
