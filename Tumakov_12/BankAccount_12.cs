using System;
using System.Collections.Generic;

namespace Tumakov_12
{
    internal class BankAccount_12
    {
        public enum AccountType
        {
            Current,
            Savings
        }

        private int accountNumber;
        private decimal balance;
        private AccountType type;
        private Queue<BankTransaktion> storeTransaktions = new Queue<BankTransaktion>();

        public BankAccount_12(decimal balance, AccountType type)
        {
            GenerationNomberAccount();
            this.balance = balance;
            this.type = type;
        }
        public BankAccount_12(decimal balance)
        {
            GenerationNomberAccount();
            this.balance = balance;
        }
        public BankAccount_12(AccountType type)
        {

            GenerationNomberAccount();
            this.type = type;
        }
        public Queue<BankTransaktion> StoreTransaktion
        {
            get
            {
                return storeTransaktions;
            }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            storeTransaktions.Enqueue(new BankTransaktion(amount));
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                storeTransaktions.Enqueue(new BankTransaktion(amount));
            }
            else
            {
                Console.WriteLine($"Вы не можете столько снять, у вас на счету {balance}");
            }
        }

        public void Transfer(decimal amount, BankAccount_12 destantionAccount)
        {
            if (balance >= amount)
            {
                Withdraw(amount);
                destantionAccount.Deposit(amount);
                storeTransaktions.Enqueue(new BankTransaktion(amount));
            }
            else
            {
                Console.WriteLine($"Вы не можете столько перевести, у вас на счету {balance}");
            }
        }
        public void GenerationNomberAccount()
        {
            this.accountNumber++;
        }

        public static bool operator ==(BankAccount_12 b1, BankAccount_12 b2) => ReferenceEquals(b1, b2); // Переопределение оператора
        public static bool operator !=(BankAccount_12 b1, BankAccount_12 b2) => !(b1 == b2); // Переопределение оператора
        public override int GetHashCode() => base.GetHashCode();
        public override string ToString() => $"Тип - {type}, номер - {accountNumber}, баланс - {balance}";
        public override bool Equals(object obj) // Переопределение метода Equals аналогично оператору ==
        {
            if (obj is BankAccount_12 bank)
            {
                return accountNumber == bank.accountNumber && balance == bank.balance && type == bank.type;
            }
            else
            {
                return false;
            }
        }


    }
}
