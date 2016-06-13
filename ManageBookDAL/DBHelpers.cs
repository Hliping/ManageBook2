using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ManageBook.DAL
{
    public class DBHelpers
    {
        public static readonly string Connection = ConfigurationManager.ConnectionStrings["Data.Sourse.Connection"].ConnectionString.ToString();

        public static SqlDataReader GetAllInfo(string sql)  //返回值为SqlDataReader对象的查询方法
        {
            SqlConnection conn = new SqlConnection(DBHelpers.Connection);
            conn.Open();
            SqlCommand scm = new SqlCommand(sql, conn);
            SqlDataReader sdr = scm.ExecuteReader();
            return sdr;
        }
        public static SqlDataReader GetAllInfo(string sql, params SqlParameter[] parameter)  //重载方法GetAllInfo（）
        {
            SqlConnection conn = new SqlConnection(DBHelpers.Connection);
            conn.Open();
            SqlCommand scm = new SqlCommand(sql, conn);
            scm.Parameters.AddRange(parameter);
            SqlDataReader sdr = scm.ExecuteReader();
            return sdr;
        }
        public static void UpdateInfo(string sql, params SqlParameter[] parameter) 
        {
            try
            {
                SqlConnection conn = new SqlConnection(DBHelpers.Connection);
                conn.Open();
                SqlCommand scm = new SqlCommand(sql, conn);
                scm.Parameters.AddRange(parameter);
                scm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
                //throw;
            }
        }
        public static void UpdateInfo(string sql, SqlParameter parameter)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DBHelpers.Connection);
                conn.Open();
                SqlCommand scm = new SqlCommand(sql, conn);
                scm.Parameters.Add(parameter);
                scm.ExecuteNonQuery();
            }
            catch (Exception)
            {

                //throw;
            }
        }
        public static DataSet GetAllInfoToDataSet(string sql) 
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(DBHelpers.Connection);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds);
            return ds;
        }
        public static DataSet GetAllInfoToDataSet(string sql,params SqlParameter[] parameter)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(DBHelpers.Connection);
            SqlCommand scm = new SqlCommand(sql, conn);
            scm.Parameters.AddRange(parameter);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = scm;
            sda.Fill(ds);
            return ds;
        }
    }
}
