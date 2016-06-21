using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageBook.Modle
{
    /// <summary>
    /// 学生费用明细实体类
    /// </summary>
    public class StudentExpense:PlanBook
    {
        /// <summary>
        /// 学院名称
        /// </summary>
        public string CollegeName { get; set; }
        /// <summary>
        /// 专业名称
        /// </summary>
        public string MajorName { get; set; }  
        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName { get; set; }
        /// <summary>
        /// 学名学期
        /// </summary>
        public string TermName { get; set; }   
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }  
        /// <summary>
        /// 学生学号
        /// </summary>
        public string StudentNumber { get; set; }  
        /// <summary>
        /// 学生性别
        /// </summary>
        public string StudentSex { get; set; }    
        /// <summary>
        /// 书本折扣
        /// </summary>
        public float Discount { get; set; }     
        /// <summary>
        /// 实际价格
        /// </summary>
        public float NetPrice { get; set; }    
        /// <summary>
        /// 获书数量
        /// </summary>
        public int GetBookNum { get; set; }
    }
}
