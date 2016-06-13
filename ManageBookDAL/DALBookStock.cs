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
        public DataSet SelectBookStock(int index,string info)
        {
            DataSet ds=new DataSet();
            StringBuilder sql =new StringBuilder("SELECT  PlanBook.BookName as '教材名称', PlanBook.ISBN as 'ISBN码', PlanBook.Author as '作者', PlanBook.Publish as '出版社', PlanBook.Price as '标价',BookStock.NetPrice as '实价',PlanBook.BookTotalNum as '订购数量', BookStock.ArriveQuantity as '库存数量',BookStock.NoArriveQuantity as '未到数量'  FROM  BookStock INNER JOIN PlanBook ON BookStock.PlanBookID = PlanBook.PlanBookID where BookStock.Arrived='true'"); 
            if (index == 1)
            {
                sql.Append(" and PlanBook.BookName like @BookName");
                SqlParameter[] parameter = { new SqlParameter("@BookName", info) };
                ds= DBHelpers.GetAllInfoToDataSet(sql.ToString(),parameter);
            }
            if (index == 2)
            {
                sql.Append(" and PlanBook.ISBN like @ISBN");
                SqlParameter[] parameter = { new SqlParameter("@ISBN",  info ) };
                ds = DBHelpers.GetAllInfoToDataSet(sql.ToString(), parameter);
            }
            if (index == 3)
            {
                sql.Append(" and PlanBook.Author like @Author");
                SqlParameter[] parameter = { new SqlParameter("@Author", info ) };
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
            string sql = "SELECT PlanBook.BookName as '教材名称', PlanBook.ISBN as 'ISBN码', PlanBook.Author as '作者', PlanBook.Publish as '出版社', PlanBook.Price as '标价', PlanBook.BookTotalNum as '订购数量', BookStock.ArriveQuantity as '已到数量',BookStock.NoArriveQuantity as '未到数量' FROM PlanBook INNER JOIN BookStock ON PlanBook.PlanBookID = BookStock.PlanBookID where BookStock.NoArriveQuantity>0";
            return DBHelpers.GetAllInfoToDataSet(sql);
        }
  
        public DataSet BookStock()
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(DBHelpers.Connection);
            string sql = "SELECT PlanBook.PlanBookID as '预订编号', PlanBook.CourseName as '课程名称', PlanBook.BookName as '教材名称', PlanBook.ISBN as 'ISBN码', PlanBook.Author as '作者', PlanBook.Publish as '出版社', PlanBook.Price as '单价', PlanBook.YearMonth as '入库时间',Course.CourseType as '课程类型', BookStock.NetPrice as '实价', BookStock.Discount as '折扣', BookStock.ArriveQuantity as '购买数量',  PlanBook.BookTotalNum as '总价', BookStock.Arrived as '备注' FROM PlanBook INNER JOIN Course ON PlanBook.CourseID = Course.CourseID INNER JOIN BookStock ON PlanBook.PlanBookID = BookStock.PlanBookID";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds);

            return ds;
        }
       
        public IList<BookStock> GetAllBookStock()
        {
            IList<BookStock> listBookStock = new List<BookStock>();
            /*
            string sql = "select * from BookStock";
            using (SqlDataReader reader = DBHelpers.GetAllInfoToDataSet(sql))
            {
                while (reader.Read())
                {
                    BookStock bookStock = new BookStock();
                    bookStock.PlanBookID = int.Parse(reader["PlanBook"].ToString());
                    bookStock.ISBN = reader["ISBN"].ToString();

                    listBookStock.Add(bookStock);
                }
            
            }*/

            return listBookStock;
        }
    }
}
