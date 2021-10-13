using System;
using System.Globalization;

namespace LessonOopAccountOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("####### PROGRAM BANK ACCOUNT #######");
            Console.WriteLine();

            Account account = new Account();

            account.OpenAccount(account.NumAccount, account.NameHolder, account.InitialDeposit, account.InitialAmount, account.Balance);

            Console.WriteLine();

            Console.WriteLine("Account data:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter the deposit amount : ");
            double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(deposit);
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Enter the value for the withdrawn: ");
            double withdrawn = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdrawn(withdrawn);
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);
        }
    }
}
