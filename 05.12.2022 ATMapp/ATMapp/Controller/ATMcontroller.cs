using ATMapp.Model;
using ATMapp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp.Controller
{
    public class ATMcontroller
    {
        private ATMmodel model;
        private ATMView view;

        public ATMcontroller()
        {
            model = new ATMmodel();
            view = new ATMView();
        }

        public void Run()
        {
            while (true)
            {
                view.ShowBalance(model.Balance);
                int choice = DisplayMenu();
                switch (choice)
                {
                    case 1:
                        double withdrawAmount = view.GetAmountToWithdraw();
                        if (model.Withdraw(withdrawAmount))
                        {
                            view.ShowMessage("The withdraw was successful.");
                        }
                        else
                        {
                            view.ShowMessage("Insufficient balance or invalid withdrawal amount.");
                        }
                        break;
                    case 2:
                        double depositAmount = view.GetAmountToDeposit();
                        model.Deposit(depositAmount);
                        break;
                    case 3:
                        break;
                    case 4:
                        view.ShowMessage("Thank you for using our ATM");
                        Environment.Exit(0);
                        break;
                    default:
                        view.ShowMessage("Invalid selection. Please choose a number from 1 to 4.");
                        break;
                }
            }
        }

        private int DisplayMenu()
        {
            Console.WriteLine("Choose what to do");
            Console.WriteLine("____________________");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Info");
            Console.WriteLine("4. Quit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 4)
            {
                return choice;
            }
            else
            {
                view.ShowMessage("Invalid selection. Please choose a number from 1 to 4.");
                return DisplayMenu();
            }
        }
    }
}
