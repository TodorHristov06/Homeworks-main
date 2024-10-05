using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp.Model
{
    public class ATMmodel
    {
        public double Balance { get; private set; }

        public ATMmodel()
        {
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance && amount > 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
