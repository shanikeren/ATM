using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class Costumer
    {
        public string CreditNumber { get; set; }
        public string CostumerName { get; set; }
        public List<Transaction> Transactions { get; set; }    
        public int Pin { get; set; }
        public double Balance { get; set; }

        public Costumer(string creditNumber, string costumerName, int pin, double balance)
        {
            CreditNumber = creditNumber;
            CostumerName = costumerName;
            Pin = pin;
            Balance = balance;
            Transactions = new List<Transaction>();
        }
        
        public bool VerifyPin(int pin)
        {
            if(pin == Pin) { return true; }
            return false;
        }

        public bool Withdraw(double amount)
        {
            if(amount > Balance) { return false; }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public bool AddTransaction(Transaction t)
        {
            if(TranAvailabale() && t.Amount < 1000 && Withdraw(t.Amount))
            {
                Transactions.Add(t);
                return true;
            }
            return false;
        }

        private bool TranAvailabale()
        {
            int count = 0;
            foreach(Transaction transaction in Transactions)
            {
                if(transaction.Date == DateTime.Today)
                {
                    count++;
                }
            }

            if (count < 10) { return true; }
            return false;
        }
    }
}
