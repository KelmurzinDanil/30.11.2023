namespace _30._11._2023
{
    internal abstract class FabricBankAccount
    {
        public abstract IBankAccount CreateAccount();
        public abstract IBankAccount CreateAccount(AccountType type);
        public abstract IBankAccount CreateAccount(AccountType type, decimal balance);
    }
}
