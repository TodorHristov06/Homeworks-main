using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp.View
{
    public class ATMView
    {
        public void ShowBalance(double balance)
        {
            Console.WriteLine($"Your balance is: {balance}");
        }

        public double GetAmountToDeposit()
        {
            Console.Write("Enter deposit amount: ");
            return double.Parse(Console.ReadLine());
        }

        public double GetAmountToWithdraw()
        {
            Console.Write("Enter withdraw amount: ");
            return double.Parse(Console.ReadLine());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
