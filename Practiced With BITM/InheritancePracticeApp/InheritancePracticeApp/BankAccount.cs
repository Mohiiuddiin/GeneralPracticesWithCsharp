using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeApp
{
    abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }
        public BankAccount(string accountNumber, string customerName) : this()
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;

            Console.WriteLine("Hello from BankAccount constructor");
        }
        public BankAccount()
        {
            Balance = 0;
        }

        //public BankAccount()
        //{
        //    Console.WriteLine("Hello from BankAccount constructor");
        //}

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit Successful";
        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdraw Successful";
        }

        public abstract string TransferAmount(string from, string to, double amount);

    }
}
