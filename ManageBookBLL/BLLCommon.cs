using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ManageBook.DAL;
using ManageBook.Modle;

namespace ManageBook.BLL
{
    /// <summary>
    /// 类名：BLLCommon公共业务逻辑层
    /// 功能：公共数据类DALCommon的业务逻辑层
    /// 内容详细：包括增添、删除、修改、查询等等方法
    /// </summary>
    public class BLLCommon
    {
        private DALCommon common = new DALCommon();
        /// <summary>
        /// 获取学院信息的方法
        /// </summary>
        /// <returns></returns>
        public List<CollegeInfo> GetAllCollegeInfo()
        {
            return common.GetAllCollegeInfo();
        }
        /// <summary>
        /// 以学院编号获取专业信息的方法
        /// </summary>
        /// <param name="collegeID">学院编号</param>
        /// <returns></returns>
        public List<MajorInfo> GetAllMajorInfo(int collegeID)
        {
            return common.GetAllMajorInfo(collegeID);
        }
        /// <summary>
        /// 以学院编号获取班级信息的方法
        /// </summary>
        /// <param name="collegeID">学院编号</param>
        /// <returns></returns>
        public List<StudentClass> GetAllStudentClass(int collegeID) 
        {
            return common.GetAllStudentClass(collegeID);
        }
        /// <summary>
        /// 以专业编号获取班级信息的方法
        /// </summary>
        /// <param name="MajorID">专业编号</param>
        /// <returns></returns>
        public List<StudentClass> GetAllStudentClassbyMajorId(int MajorInfoID)
        {
            return common.GetAllStudentClassbyMajorId(MajorInfoID);
        }
        /// <summary>
        /// 以专业编号和年级编号获取班级信息的方法
        /// </summary>
        /// <param name="majorInfoID">专业编号</param>
        /// <param name="gradeInfoID">年级编号</param>
        /// <returns></returns>
        public List<StudentClass> GetAllStudentClass(int majorInfoID, int gradeInfoID)
        {
            return common.GetAllStudentClass(majorInfoID, gradeInfoID);
        }
        /// <summary>
        /// 获取学年学期的方法
        /// </summary>
        /// <returns></returns>
        public List<SchoolTerm> GetAllSchoolTerm() //获取学年学期的方法
        {
            return common.GetAllSchoolTerm();
        }
        /// <summary>
        /// 获取教材类型的方法
        /// </summary>
        /// <returns></returns>
        public List<Course> GetAllCourse() 
        {
            return common.GetAllCourse();
        }

        /// <summary>
        /// 以班级名称获取专业信息和学院信息的方法
        /// </summary>
        /// <param name="ClassName">班级名称</param>
        /// <returns></returns>
        public StudentClass GetAllCollegeInfo_Class(string ClassName) 
        {
            return common.GetAllCollegeInfo_Class(ClassName);
        }
        /// <summary>
        /// 获取年级信息的方法
        /// </summary>
        /// <returns></returns>
        public List<GradeInfo> GetAllGradeInfo()//获取年级信息的方法
        {
            return common.GetAllGradeInfo();
        }
    }
}
