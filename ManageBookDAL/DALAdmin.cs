using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.Modle;
using System.Data.SqlClient;

namespace ManageBook.DAL
{
    public class DALAdmin
    {
        public bool GetAllAdmin(Admin admin) 
        {
            bool flag = false;
            string pwd = string.Empty;
            string sql = "select * from Admin where LoginID=@LoginID";
            SqlParameter parament = new SqlParameter("@LoginID",admin.LoginID);
            try
            {
                using (SqlDataReader sdr = DBHelpers.GetAllInfo(sql, parament))
                {
                    while (sdr.Read())
                    {
                        pwd = sdr["LoginPwd"].ToString();
                    }
                }
                if (pwd == admin.LoginPwd)
                {
                    flag = true;
                }
            }
            catch (Exception)
            {

                //throw;
            }
            return flag;
        }
    }
}
