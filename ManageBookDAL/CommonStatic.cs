using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ManageBook.Modle;

namespace ManageBook.DAL
{
    public class CommonStatic
    {
        public static DataTable dt = new DataTable();  //定义一个静态数据表用来接收Excel数据

        public static int recordNum; //定义一个静态变量来保存Excel中的有多少条记录

        #region 未到教材入库使用的静态字段
        public static int BookStockID;
        public static string txtBookName;
        public static string txtISBN;
        public static string txtPublish;
        public static string txtAuthor;
        public static float txtPrice;
        public static int   txtNum;
        public static int txtNoArrive;
        #endregion
        
    }
}
