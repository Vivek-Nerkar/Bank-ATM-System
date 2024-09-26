using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Security.Principal;

namespace Bank_ATM
{
    public class BankAccount
    {
        private double balance;
        
        public BankAccount(double intialBalance)
        {
            this.balance = intialBalance;
            
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double amount)
        { 
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine($"\nDeposited Rs.{amount} Successfully! \nNew balance: Rs.{GetBalance()} ");
            }else
             {
                Console.WriteLine("Invalid amount entered");
             }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance = balance - amount;
                Console.WriteLine($"\nWitdrew Rs.{amount} Successfully! \nNew balance: Rs.{GetBalance()}");
            }else
            {
                Console.WriteLine("Invalid amount entered");
            }
            
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nerkar Banking System!");
            Console.WriteLine("Choose an option: ");

            Random random = new Random();
            double balance = Math.Round(random.NextDouble() * (100000-5000), 2);
            BankAccount account = new BankAccount(balance);
            
            
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit\n");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine($"Your Inital balance is: {account.GetBalance()}");
                        break;
                    case "2":
                        Console.WriteLine("Deposit amount: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case "3":

                        Console.WriteLine("Withdraw amount: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using Nerkar banking System");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option, Please try again");
                        break;

                }
            }
        }
    }
    
}