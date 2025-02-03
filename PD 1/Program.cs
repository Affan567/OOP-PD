//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace BankManagementSystem
//{
//    // Class to represent a Bank Account
//    class BankAccount
//    {
//        public string AccountNumber;
//        public string AccountHolderName;
//        public double Balance;
//        public List<string> Transactions;

//        public BankAccount()
//        {
//            Transactions = new List<string>();
//        }
//    }

//    // Class to manage Admin functionalities
//    class Admin
//    {
//        private List<BankAccount> accounts;
//        private string accountsFilePath = "accounts.txt";
//        private string transactionsFilePath = "transactions.txt";

//        public Admin()
//        {
//            accounts = new List<BankAccount>();
//            LoadAccountsFromFile();
//        }

//        // Load accounts from file
//        private void LoadAccountsFromFile()
//        {
//            if (File.Exists(accountsFilePath))
//            {
//                string[] lines = File.ReadAllLines(accountsFilePath);
//                foreach (string line in lines)
//                {
//                    string[] data = line.Split(',');
//                    BankAccount account = new BankAccount
//                    {
//                        AccountNumber = data[0],
//                        AccountHolderName = data[1],
//                        Balance = double.Parse(data[2])
//                    };
//                    accounts.Add(account);
//                }
//            }
//        }

//        // Save accounts to file
//        private void SaveAccountsToFile()
//        {
//            List<string> lines = new List<string>();
//            foreach (var account in accounts)
//            {
//                lines.Add($"{account.AccountNumber},{account.AccountHolderName},{account.Balance}");
//            }
//            File.WriteAllLines(accountsFilePath, lines);
//        }

//        // Create a new account
//        public void CreateAccount()
//        {
//            Console.WriteLine("Enter Account Number:");
//            string accountNumber = Console.ReadLine();
//            Console.WriteLine("Enter Account Holder Name:");
//            string accountHolderName = Console.ReadLine();
//            Console.WriteLine("Enter Initial Balance:");
//            double balance = double.Parse(Console.ReadLine());

//            BankAccount account = new BankAccount
//            {
//                AccountNumber = accountNumber,
//                AccountHolderName = accountHolderName,
//                Balance = balance
//            };
//            accounts.Add(account);
//            SaveAccountsToFile();
//            Console.WriteLine("Account created successfully!");
//        }

//        // Delete an account
//        public void DeleteAccount()
//        {
//            Console.WriteLine("Enter Account Number to Delete:");
//            string accountNumber = Console.ReadLine();
//            BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);
//            if (account != null)
//            {
//                accounts.Remove(account);
//                SaveAccountsToFile();
//                Console.WriteLine("Account deleted successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Account not found!");
//            }
//        }

//        // Update an account
//        public void UpdateAccount()
//        {
//            Console.WriteLine("Enter Account Number to Update:");
//            string accountNumber = Console.ReadLine();
//            BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);
//            if (account != null)
//            {
//                Console.WriteLine("Enter New Account Holder Name:");
//                account.AccountHolderName = Console.ReadLine();
//                Console.WriteLine("Enter New Balance:");
//                account.Balance = double.Parse(Console.ReadLine());
//                SaveAccountsToFile();
//                Console.WriteLine("Account updated successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Account not found!");
//            }
//        }

//        // View all accounts
//        public void ViewAllAccounts()
//        {
//            if (accounts.Count == 0)
//            {
//                Console.WriteLine("No accounts found!");
//                return;
//            }

//            Console.WriteLine("All Accounts:");
//            foreach (var account in accounts)
//            {
//                Console.WriteLine($"Account Number: {account.AccountNumber}, Holder: {account.AccountHolderName}, Balance: {account.Balance}");
//            }
//        }

//        // View transaction history of an account
//        public void ViewTransactionHistory()
//        {
//            Console.WriteLine("Enter Account Number to View Transactions:");
//            string accountNumber = Console.ReadLine();
//            BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);
//            if (account != null)
//            {
//                if (account.Transactions.Count == 0)
//                {
//                    Console.WriteLine("No transactions found!");
//                    return;
//                }

//                Console.WriteLine($"Transaction History for Account: {account.AccountNumber}");
//                foreach (var transaction in account.Transactions)
//                {
//                    Console.WriteLine(transaction);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Account not found!");
//            }
//        }
//    }

//    // Main Program
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Admin admin = new Admin();
//            int choice;

//            do
//            {
//                Console.WriteLine("\nBank Management System - Admin Menu");
//                Console.WriteLine("1. Create Account");
//                Console.WriteLine("2. Delete Account");
//                Console.WriteLine("3. Update Account");
//                Console.WriteLine("4. View All Accounts");
//                Console.WriteLine("5. View Transaction History");
//                Console.WriteLine("6. Exit");
//                Console.WriteLine("Enter your choice:");
//                choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        admin.CreateAccount();
//                        break;
//                    case 2:
//                        admin.DeleteAccount();
//                        break;
//                    case 3:
//                        admin.UpdateAccount();
//                        break;
//                    case 4:
//                        admin.ViewAllAccounts();
//                        break;
//                    case 5:
//                        admin.ViewTransactionHistory();
//                        break;
//                    case 6:
//                        Console.WriteLine("Exiting...");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice! Please try again.");
//                        break;
//                }
//            } while (choice != 6);
//        }
//    }
//}