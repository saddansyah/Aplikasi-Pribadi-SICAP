﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICAP
{
    public class Payment
    {
        public string ItemName { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
        public string Total { get; set; }

        public Payment(string itemName, string price, string qty, string total)
        {
            ItemName = itemName;
            Price = price;
            Qty = qty;
            Total = total;
        }

        public Payment()
        {
        }
    }
}
