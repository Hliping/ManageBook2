using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageBook.Modle
{
    public class GrantBook
    {
        public int GrantID { get; set; }
        public int PlanBookID { get; set; }
        public int StudentInfoID { get; set; }
        public int SchoolTermID { get; set; }
        public int GetBookNum { get; set; }
        public int ExitBook { get; set; }
    }
}
