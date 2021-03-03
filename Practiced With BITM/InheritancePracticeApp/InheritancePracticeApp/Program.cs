using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
        
            SavingAccount sv1 = new SavingAccount("SA-103", "Nayem", 2);
            BankAccount b2 =sv1;
            SavingAccount sv2 = (SavingAccount)b2;
            Console.WriteLine(sv2.InterestRate);

            //BankAccount b3 = new BankAccount("","");
            //SavingAccount sv3 = (SavingAccount)b3;
            












            //List<BankAccount> bankAccounts = new List<BankAccount>();
            //bankAccounts.Add(b1);
            //bankAccounts.Add(sv1);
            //bankAccounts.Add(sv2);
            //bankAccounts.Add(b2);



            //foreach (BankAccount bankAccount in bankAccounts)
            //{
            //    Console.WriteLine(bankAccount.CustomerName);
            //}


















            //smpleAccount.



            //BankAccount account = new BankAccount("","");
            //Console.WriteLine(sv.CustomerName);
            //Console.WriteLine(sv.AccountNumber);
            //Console.WriteLine(sv.InterestRate);
            //sv.CustomerName = "Jumman Ahmed";
            //sv.AccountNumber = "sv-101";
            //Console.WriteLine(sv.Deposit(2000));
            //Console.WriteLine(sv.Withdraw(200000));
            //Console.WriteLine(sv.Balance);        

           















            Console.WriteLine("---------------------");

            //CheckingAccount ck = new CheckingAccount();
            //ck.CustomerName = "Ruhul Kuddus";
            //ck.AccountNumber = "CK-101";
            //Console.WriteLine(ck.Deposit(2000));
            //Console.WriteLine(ck.Withdraw(1000));
            //Console.WriteLine(ck.Withdraw(1000));
            //Console.WriteLine(ck.Withdraw(1000));
            //Console.WriteLine(ck.Balance);

            
        }
    }
}
