using System.Collections;

namespace _30._11._2023
{
    internal class BankAccount_A_Fabric : FabricBankAccount
    {
        private int accountNumber;
        private decimal balance;
        private AccountType type;
        private Hashtable hashtable = new Hashtable(); //хеш-таблица 
        public BankAccount_A_Fabric(decimal balance, AccountType type)
        {
            this.balance = balance;
            this.type = type;
        }
        public BankAccount_A_Fabric(decimal balance)
        {
            this.balance = balance;
        }
        public BankAccount_A_Fabric(AccountType type)
        {
            this.type = type;
        }
        public BankAccount_A_Fabric() { }
        public override IBankAccount CreateAccount(AccountType type) // Метод создания аккаунта
        {
            GenerationNomberAccount();
            BankAccount_A account = new BankAccount_A(accountNumber, type);
            hashtable.Add(accountNumber, account);
            return account;
        }
        public override IBankAccount CreateAccount(AccountType type, decimal balance) // Его перегрузка
        {
            GenerationNomberAccount();
            BankAccount_A account = new BankAccount_A(accountNumber, type, balance);
            hashtable.Add(accountNumber, account);
            return account;
        }
        public override IBankAccount CreateAccount() // Его перегрузка
        {
            GenerationNomberAccount();
            BankAccount_A account = new BankAccount_A(accountNumber);
            hashtable.Add(accountNumber, account);
            return account;
        }
        public void CloseAccount(int accountNumber) // Метод удаления аккаунта из хеш-таблицы
        {
            hashtable.Remove(accountNumber);
        }
        public void GenerationNomberAccount() // Метод генерации номера
        {
            accountNumber++;
        }
    }
}
