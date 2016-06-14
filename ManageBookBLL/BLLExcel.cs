using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using ManageBook.DAL;

namespace ManageBook.BLL
{
    public class BLLExcel
    {
        private DALExcel dalExcel = new DALExcel();
        public DataSet ExcelToDataSet(string openFile)
        {
            return dalExcel.ExcelToDataSet(openFile);
        }

        public bool DataTableToSqlTable(DataTable dt)
        {
            string[] srcColumns = { "学院名称", "专业名称", "学生年级", "学生班别", "学生姓名", "学生性别", "学生学号", "备注", };
            string[] dscColumns = { "CollegeName", "MajorName", "GradeName", "StudentClassName",
                                      "StudentName", "StudentSex", "StudentNumber" ,
                                  "StudentMarket"};
            string TableName = "TemporaryStudentInfo";
            return dalExcel.DataTableToSqlTable(srcColumns, dscColumns, dt, TableName);
        }
    }
}
