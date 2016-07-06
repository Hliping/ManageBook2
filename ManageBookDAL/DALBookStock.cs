using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.Modle;
using System.Data;
using System.Data.SqlClient;

namespace ManageBook.DAL
{
    public class DALBookStock
    {
        private DataSet ds;

        public void UpdateBookStock(BookStock bookstock)
        {
            string sql = "Update BookStock set ArriveQuantity=@ArriveQuantity,NoArriveQuantity=@NoArriveQuantity,NetPrice=@NetPrice,Discount=@Discount,Arrived='true' where BookStock.PlanBookID = (select PlanBook.PlanBookID from PlanBook where ISBN=@ISBN)";
            SqlParameter[] parameter = { new SqlParameter("@ArriveQuantity", SqlDbType.Int),
                                         new SqlParameter("@NoArriveQuantity",SqlDbType.Int),
                                         new SqlParameter("@NetPrice",SqlDbType.Float),
                                         new SqlParameter("@Discount",SqlDbType.Float),
                                         new SqlParameter("@ISBN",SqlDbType.VarChar)
                                        };
            parameter[0].Value = bookstock.ArriveQuantity;
            parameter[1].Value = bookstock.NoArriveQuantity;
            parameter[2].Value = bookstock.NetPrice;
            parameter[3].Value = bookstock.Discount;
            parameter[4].Value = bookstock.ISBN;
            string sql1 = "update planbook set isbookstock='true' where isbn=@isb";
            SqlParameter para = new SqlParameter("@isb", bookstock.ISBN);
            DBHelpers.UpdateInfo(sql, parameter);
            DBHelpers.UpdateInfo(sql1, para);

        }

        public DataSet SelectBookStock()
        {
            string sql = "SELECT  PlanBook.BookName as '教材名称', PlanBook.ISBN as 'ISBN码', PlanBook.Author as '作者', PlanBook.Publish as '出版社', PlanBook.Price as '标价',BookStock.NetPrice as '实价',PlanBook.BookTotalNum as '订购数量', BookStock.ArriveQuantity as '库存数量',BookStock.NoArriveQuantity as '未到数量'  FROM  BookStock INNER JOIN PlanBook ON BookStock.PlanBookID = PlanBook.PlanBookID where BookStock.Arrived='true'";
            return DBHelpers.GetAllInfoToDataSet(sql);
        }
        public DataSet SelectBookStock(int index, string info)
        {
            DataSet ds = new DataSet();
            StringBuilder sql = new StringBuilder("SELECT  PlanBook.BookName as '教材名称', PlanBook.ISBN as 'ISBN码', PlanBook.Author as '作者', PlanBook.Publish as '出版社', PlanBook.Price as '标价',BookStock.NetPrice as '实价',PlanBook.BookTotalNum as '订购数量', BookStock.ArriveQuantity as '库存数量',BookStock.NoArriveQuantity as '未到数量'  FROM  BookStock INNER JOIN PlanBook ON BookStock.PlanBookID = PlanBook.PlanBookID where BookStock.Arrived='true'");
            if (index == 1)
            {
                sql.Append(" and PlanBook.BookName like @BookName");
                SqlParameter[] parameter = { new SqlParameter("@BookName", info) };
                ds = DBHelpers.GetAllInfoToDataSet(sql.ToString(), parameter);
            }
            if (index == 2)
            {
                sql.Append(" and PlanBook.ISBN like @ISBN");
                SqlParameter[] parameter = { new SqlParameter("@ISBN", info) };
                ds = DBHelpers.GetAllInfoToDataSet(sql.ToString(), parameter);
            }
            if (index == 3)
            {
                sql.Append(" and PlanBook.Author like @Author");
                SqlParameter[] parameter = { new SqlParameter("@Author", info) };
                ds = DBHelpers.GetAllInfoToDataSet(sql.ToString(), parameter);
            }
            if (index == 4)
            {
                sql.Append(" and PlanBook.Publish like @Publish");
                SqlParameter[] parameter = { new SqlParameter("@Publish", info) };
                ds = DBHelpers.GetAllInfoToDataSet(sql.ToString(), parameter);
            }
            return ds;
        }

        public DataSet NoArriveBook()
        {
            string sql = "SELECT BookStock.BookStockID ,PlanBook.BookName, PlanBook.ISBN, PlanBook.Author, PlanBook.Publish, PlanBook.Price, PlanBook.BookTotalNum, BookStock.ArriveQuantity ,BookStock.NoArriveQuantity  FROM PlanBook INNER JOIN BookStock ON PlanBook.PlanBookID = BookStock.PlanBookID where BookStock.NoArriveQuantity>0";
            return DBHelpers.GetAllInfoToDataSet(sql);

        }



        /// <summary>
        /// 教材库存所有数据查询和按条件查询
        /// </summary>
        /// <param name="index"></param>
        /// <param name="bookStock"></param>
        /// <returns></returns>
        public DataSet GetAllBookStock(int index, string bookStock)
        {
            using (SqlConnection conn = new SqlConnection(DBHelpers.Connection))
            {
                SqlCommand cmd = new SqlCommand();
                StringBuilder sql = new StringBuilder("SELECT  PlanBook.BookName as '教材名称', PlanBook.ISBN as 'ISBN码', PlanBook.Author as '作者', PlanBook.Publish as '出版社', PlanBook.Price as '标价',BookStock.NetPrice as '实价',PlanBook.BookTotalNum as '订购数量', BookStock.ArriveQuantity as '库存数量',BookStock.NoArriveQuantity as '未到数量'  FROM  BookStock INNER JOIN PlanBook ON BookStock.PlanBookID = PlanBook.PlanBookID where BookStock.Arrived='true'");
                cmd.Connection = conn;
                if (index == 0)
                {
                    cmd.CommandText = sql.ToString(); //当index==0时必须指定cmd.CommandText的值，否则cmd.CommandText的值为空的时候系统会出现异常
                }
                if (index == 1)
                {
                    sql.Append(" and BookStock like @BookStock");
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@BookStock", "%" + bookStock + "%");

                }
                if (index == 2)
                {
                    sql.Append(" and ISBN like @ISBN");
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@ISBN", "%" + bookStock + "%");


                }
                if (index == 3)
                {
                    sql.Append(" and Author like @Author");
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Author", "%" + bookStock + "%");

                }
                if (index == 4)
                {
                    sql.Append(" and Publish like @Publish");
                    cmd.CommandText = sql.ToString();
                    cmd.Parameters.AddWithValue("@Publish", "%" + bookStock + "%");

                }
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }

        }
    }
}
