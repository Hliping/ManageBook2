using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageBook.Modle
{
    public class NoArriveBook:PlanBook
    {
        public int StockBookID { get; set; }
        public int ArriveQuantity { get; set; }
        public int NoArriveQuantity { get; set; }
    }
}
