using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageBook.Modle
{
    public class GetBookBusiness
    {
        public int GetBookID { get; set; }
        public string Signer { get; set; }
        public int GetBookNum { get; set; }
        public string ClassName { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Publish { get; set; }
        public string Author { get; set; }
        public string CourseType { get; set; }
    }
}
