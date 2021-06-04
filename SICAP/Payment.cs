using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICAP
{
    class Payment
    {
        public int TransactionID { get; set; }
        public string Cashier_Name { get; set; }
        public DateTime Transaction_Date { get; set; }
        public int Amount { get; set; }

        public Payment(int id, string name, DateTime time, int amount)
        {
            TransactionID = id;
            Cashier_Name = name;
            Transaction_Date = time;
            Amount = amount;
        }
    }
}
