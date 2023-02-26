using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class Transaction
    {
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public Transaction(int amount)
        {
            Amount = amount;
            Date = DateTime.Today;
        }
    }
}
