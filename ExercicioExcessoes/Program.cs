using System;
using System.Globalization;
using ExercicioExcessoes.Entities;
using ExercicioExcessoes.Entities.Exceptions;

namespace ExercicioExcessoes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();
            
                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
                Console.Write("Withdraw Limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, 0.0, withdrawlimit);
                acc.Deposit(initialBalance);

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (AccountException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}