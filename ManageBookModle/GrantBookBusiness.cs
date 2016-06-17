using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageBook.Modle
{
    public  class GrantBookBusiness:PlanBook
    {
        /// <summary>
        /// 教材发放明细的业务实体类
        /// </summary>
        public string CollegeName { get; set; } //学院名称
        public string MajorSimple { get; set; } //专业简称
        public string GradeSimple { get; set; } //年级简称
        public string TermName { get; set; }  //学年学期
        public string StudentName { get; set; }//学生姓名
        public string StudentNumber { get; set; }//学生学号
        public string StudentSex { get; set; } //学生性别
        public string ClassName { get; set; }//班级名称
        public string GetBookNum { get; set; }//每个人的领书数量
        public string CourseType { get; set; }//课程类型
    }
}
