using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageBook.Modle
{
    public class GradeInfo
    {
        /// <summary>
        /// 年级信息的实体类
        /// </summary>
        public int GradeInfoID { get; set; } //年级编号
        public string GradeName { get; set; } //年级全称
        public string GradeSimple { get; set; }//年级简称
    }
}
