using System;
namespace Encapsulaton
{
    public class Bank
    {
        private int Balance = 0;
        private string Password;
        private List<string> logs = new List<string>();

        public Bank(int balance , string Walletpw)
        {
            Balance = balance;
            Password = Walletpw;
        }

        private void logTransactions(string log)
        {
            logs.Add(log);
        }

        public void Deposit(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("no negitive value");
            }
            Balance += amount;
            logTransactions($"Amount {amount} is deposited");
        }
        public void Withdraw(int amount ,string pw)
        {
            if(pw != Password)
            {
                logTransactions("wrong pw");
            }
            if(amount <= 0)
            {
                throw new ArgumentException("value should be greater then zero");
            }
            if(Balance - amount <= 0)
            {
                logTransactions("Insufficient funds");

            }
            logTransactions($"{amount} is withdrawn , leftover balance is {Balance - amount} ");
            Balance -= amount;
        }
        public int Getbalance()
        {
            return Balance;
        }

        public List<string> Getlogs()
        {
            return new List<string>(logs);
        }

    }

    class Program
    {
        public static void Main()
        {
            Bank B = new(10, "Secure123");


            B.Deposit(5);
            B.Deposit(5);
            B.Deposit(5);
            int balance = B.Getbalance();


            B.Withdraw(5, "Secu");
            B.Withdraw(5, "Secure123");
            B.Withdraw(5, "Secure123");

            Console.WriteLine($"Your Balance is {balance}");
            List<string> logs =  B.Getlogs();

          
            foreach(string log in logs)
            {
                Console.WriteLine(log);
            }
             int balancelast = B.Getbalance();
            Console.WriteLine(balancelast);

        }
    }
}