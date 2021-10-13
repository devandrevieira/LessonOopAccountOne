using System;
using System.Globalization;

namespace LessonOopAccountOne
{
    class Account
    {
        public int NumAccount { get; private set; }
        public string NameHolder;
        public char InitialDeposit { get; private set; }
        public double InitialAmount { get; private set; }
        public double Balance { get; private set; }

        public Account()
        {
        }

        public Account(int numAccount, string nameHolder, char initialDeposit, double initialAmount, double balance)
        {
            NumAccount = numAccount;
            NameHolder = nameHolder;
            InitialDeposit = initialDeposit;
            InitialAmount = initialAmount;
            Balance = balance;

        }

        public void OpenAccount(int numAccount, string nameHolder, char initialDeposit, double initialAmount, double balance)
        {
            Console.Write("Enter the account number: ");
            NumAccount = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of the holder: ");
            NameHolder = (Console.ReadLine());

            Console.Write("Will there be initial deposit ?: (y/n)? ");
            InitialDeposit = char.Parse(Console.ReadLine());

            if (InitialDeposit == 'y')
            {
                Console.Write("Enter the initial amount: ");
                InitialAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                InitialAmount = 0;
            }

            Balance = InitialAmount;
        }

        public double Deposit(double deposit)
        {
            return Balance += deposit;
        }

        public double Withdrawn(double withdrawn)
        {
            return Balance -= withdrawn + 5.00;
        }

        public override string ToString()
        {
            return "Account Number: " + NumAccount +
                ", Holder: " + NameHolder +
                ", Balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
