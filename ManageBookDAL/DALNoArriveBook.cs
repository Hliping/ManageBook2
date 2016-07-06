using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.Modle;
using System.Data.SqlClient;

namespace ManageBook.DAL
{
    public class DALNoArriveBook
    {
        public List<NoArriveBook> GetAllInfo(int index,string txt) 
        {
            List<NoArriveBook> list = new List<NoArriveBook>();
            StringBuilder sql = new StringBuilder("SELECT BookStock.StockBookID,PlanBook.BookName, PlanBook.ISBN, PlanBook.Author, PlanBook.Publish, PlanBook.Price, PlanBook.BookTotalNum, BookStock.ArriveQuantity ,BookStock.NoArriveQuantity  FROM PlanBook INNER JOIN BookStock ON PlanBook.PlanBookID = BookStock.PlanBookID where BookStock.NoArriveQuantity>0 ");
            if (index == 0)
            {
               sql.ToString(); //当index==0时必须指定cmd.CommandText的值，否则cmd.CommandText的值为空的时候系统会出现异常
            }
            if (index == 1)
            {
                sql.Append(string.Format(" and PlanBook.BookName like {0}",txt));
            }
            if (index == 2)
            {
                sql.Append(string.Format(" and PlanBook.ISBN like {0}", txt));
            }
            if (index == 3)
            {
                sql.Append(string.Format(" and PlanBook.Author like {0}", txt));

            }
            if (index == 4)
            {
                sql.Append(string.Format(" and PlanBook.Publish like {0}", txt));

            }
            using (SqlDataReader sqldata = DBHelpers.GetAllInfo(sql.ToString())) 
            {
                while (sqldata.Read()) 
                {
                    NoArriveBook no = new NoArriveBook();
                    no.BookName = sqldata["BookName"].ToString();
                    no.ISBN = sqldata["ISBN"].ToString();
                    no.Author = sqldata["Author"].ToString();
                    no.Publish = sqldata["Publish"].ToString();
                    no.Price = float.Parse(sqldata["Price"].ToString());
                    no.BookTotalNum = Convert.ToInt32(sqldata["BookTotalNum"]);
                    no.StockBookID = Convert.ToInt32(sqldata["StockBookID"]);
                    no.NoArriveQuantity = Convert.ToInt32(sqldata["NoArriveQuantity"]);
                    no.ArriveQuantity = Convert.ToInt32(sqldata["ArriveQuantity"]);
                    list.Add(no);
                }
            }
            return list;
        }

        /// <summary>
        /// 修改未到教材
        /// </summary>
        /// <param name="txt"></param>
        public void UpdateBookStock(string txt) 
        {
            string sql = string.Format("Update BookStock set ArriveQuantity+={0},NoArriveQuantity-={1} where StockBookID={2}",txt,txt,CommonStatic.BookStockID);
            DBHelpers.UpdateInfo(sql);
        }
    }
}
