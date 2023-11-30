namespace _30._11._2023
{

    internal class BankAccount_A : IBankAccount
    {
        private readonly int accountNumber;
        private readonly decimal balance;
        private readonly AccountType type;

        // Не стал добавлять все те методы, которые мы использовали в прошлых домашках банковского аккаунта (Перевод, очередь, снятие и т.д)
        public BankAccount_A(int accountNumber, AccountType type)
        {
            this.accountNumber = accountNumber;
            this.type = type;
        }
        public BankAccount_A(int accountNumber, AccountType type, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.type = type;
            this.balance = balance;
        }
        public BankAccount_A(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public int NumberAccount => accountNumber;
        public decimal Balance => balance;
        public AccountType AccountType => type;

    }
}
