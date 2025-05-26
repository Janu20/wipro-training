using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    // Transaction class
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; } // Deposit or Withdraw
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"{Date} | {Type} | {Amount}";
        }

        public static Transaction FromString(string line)
        {
            var parts = line.Split('|');
            return new Transaction
            {
                Date = DateTime.Parse(parts[0].Trim()),
                Type = parts[1].Trim(),
                Amount = int.Parse(parts[2].Trim())
            };
        }
    }

    // BankAccount class
    public class BankAccount
    {
        private int balance;
        private List<Transaction> transactions;
        private const string FilePath = "transactions.txt";

        public BankAccount()
        {
            transactions = new List<Transaction>();
            balance = 0;

            LoadTransactions();
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                var transaction = new Transaction { Date = DateTime.Now, Type = "Deposit", Amount = amount };
                transactions.Add(transaction);
                Console.WriteLine($"Deposited: {amount}");
                SaveTransaction(transaction);
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                var transaction = new Transaction { Date = DateTime.Now, Type = "Withdraw", Amount = amount };
                transactions.Add(transaction);
                Console.WriteLine($"Withdrawn: {amount}");
                SaveTransaction(transaction);
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public void DisplaySummary()
        {
            Console.WriteLine("\n--- Transaction History ---");
            foreach (var t in transactions)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine($"Current Balance: {balance}");
        }

        private void SaveTransaction(Transaction t)
        {
            File.AppendAllText(FilePath, t.ToString() + Environment.NewLine);
        }

        private void LoadTransactions()
        {
            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var t = Transaction.FromString(line);
                    transactions.Add(t);
                    balance += (t.Type == "Deposit") ? t.Amount : -t.Amount;
                }
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();

            account.DisplaySummary();

            while (true)
            {
                Console.WriteLine("\nChoose operation:\n1. Deposit\n2. Withdraw\n3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit: ");
                        int deposit = int.Parse(Console.ReadLine());
                        account.Deposit(deposit);
                        break;

                    case "2":
                        Console.Write("Enter amount to withdraw: ");
                        int withdraw = int.Parse(Console.ReadLine());
                        account.Withdraw(withdraw);
                        break;

                    case "3":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
