using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageBook.Modle
{
    public class StudentInfoBusiness:StudentInfo
    {
         public int PlanBookID { get; set; }
        public int CourseID { get; set; }
        public int SchoolTermID { get; set; }
        public string CourseName { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publish { get; set; }
        public float Price { get; set; }
    }
}
