using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ManageBook.DAL
{
    public class DALExcel
    {
        public DataSet ExcelToDataSet(string openFile)
        {
            string ext = System.IO.Path.GetExtension(openFile); //获取文件的类型名（扩展名）
            string strConn = string.Empty;
            if (ext == "xls")                                 //根据文件的类型选择对应的链接字符串，xls 为 OLEDB.4.0；xlsx为OLEDB.12.0
            {
                strConn = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source ={0}; Extended Properties = Excel 8.0", openFile);
            }
            else
            {
                strConn = string.Format("Provider=Microsoft.Ace.OLEDB.12.0; Data Source ={0}; Extended Properties = Excel 12.0", openFile);
            }
            OleDbDataAdapter oda = null;          //实例化OLEDB 适配器对象
            DataSet ds = null;                    //定义数据集对象用于保存结果
            using (OleDbConnection conn = new OleDbConnection(strConn))  //创建OleDb链接对象
            {
                conn.Open();                                          //打开链接
                string sql = "select * from [sheet1$]";              //定义查询SQL语句,此处要求Excel有名为Sheet1的工作表，否则将出现异常
                using (oda = new OleDbDataAdapter(sql, conn))        //通过配适器执行查询并返回结果
                {
                    ds = new DataSet();                                   //实例化数据集
                    oda.Fill(ds, "table1");                               //配适器并查询结果  填充 到数据集中
                }
            }
            return ds;
        }

        public bool DataTableToSqlTable(string[] srcColumns,string[] dscColumns,DataTable dt,string TableName)
        {
            bool flag = false;
            using (SqlConnection conn = new SqlConnection(DBHelpers.Connection))
            {
                using (SqlBulkCopy sqlcopy = new SqlBulkCopy(DBHelpers.Connection, SqlBulkCopyOptions.UseInternalTransaction))
                {
                    sqlcopy.DestinationTableName = TableName;  
                    sqlcopy.BulkCopyTimeout = 300;
                    for (int i = 0; i < srcColumns.Length; i++)
                    {
                        sqlcopy.ColumnMappings.Add(srcColumns[i], dscColumns[i]);
                    }
                    try
                    {
                        sqlcopy.WriteToServer(dt);
                        string sql = "insert into StudentInfo SELECT  StudentClass.StudentClassID, TemporaryStudentInfo.StudentName, TemporaryStudentInfo.StudentNumber, TemporaryStudentInfo.StudentSex, TemporaryStudentInfo.StudentMarket FROM  TemporaryStudentInfo INNER JOIN StudentClass ON TemporaryStudentInfo.StudentClassName = StudentClass.ClassName left join StudentInfo on TemporaryStudentInfo.StudentNumber=StudentInfo.StudentNumber where StudentInfo.StudentNumber is null";
                        string sql1 = "truncate table TemporaryStudentInfo";
                        SqlCommand scm = new SqlCommand(sql,conn);
                        SqlCommand cmd = new SqlCommand(sql1, conn);
                        conn.Open();
                        CommonStatic.recordNum = scm.ExecuteNonQuery();
                        if (CommonStatic.recordNum > 0)
                        {
                            flag = true;
                        }
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return flag;
        }
    }
}
