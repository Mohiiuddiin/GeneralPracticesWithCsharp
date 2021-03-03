using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeApp
{
    class SavingAccount : BankAccount
    {      
        public double InterestRate { get; set; }

        public SavingAccount(string accountNumber, string customerName, double interestRate) : base(accountNumber,customerName)
        {
            InterestRate = interestRate;
            Console.WriteLine("Hello from SavingAccount constructor");            
        }

        public override string Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                return base.Withdraw(amount);
            }
            return "Insufficient Balance";
        }

        public override string TransferAmount(string @from, string to, double amount)
        {
            throw new NotImplementedException();
        }
    }
}
