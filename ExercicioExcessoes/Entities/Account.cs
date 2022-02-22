using System;
using System.Globalization;
using ExercicioExcessoes.Entities.Exceptions;

namespace ExercicioExcessoes.Entities
{
    public class Account
    {
        //properties
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }
        //constructors
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        //methods
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("Amount bigger than WithdrawLimit!");
            }
            else if (amount > Balance)
            {
                throw new AccountException("You can't withdraw more money you have in your account!");
            }
            
            Balance -= amount;
            
        }
    }
}