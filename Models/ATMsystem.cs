using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class ATMsystem
    {
        public List<Costumer> Costumers;
        public Costumer CurrCostumer;
        public ATMsystem()
        {
            Costumers = new List<Costumer>();
            Costumers.Add(new Costumer("1234123412341234", "Shani", 5678, 7850));
            Costumers.Add(new Costumer("1234567812345678", "Ido", 1111, 20546));
            Costumers.Add(new Costumer("5678567856785678", "Inbar", 1234, 6200));
            Costumers.Add(new Costumer("4321432143214321", "Roee", 4444, 3450));
        }
        public bool IsExist(string number)
        {
            foreach (Costumer costumer in Costumers)
            {
                if (costumer.CreditNumber.Equals(number))
                {
                    CurrCostumer = costumer;
                    return true;
                }
            }

            return false;
        }
    }
}
