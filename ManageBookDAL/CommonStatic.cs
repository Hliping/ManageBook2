using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ManageBook.DAL
{
    public class CommonStatic
    {
        public static DataTable dt = new DataTable();  //定义一个静态数据表用来接收Excel数据

        public static int recordNum; //定义一个静态变量来保存Excel中的有多少条记录
    }
}
