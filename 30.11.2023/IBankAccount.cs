namespace _30._11._2023
{
    enum AccountType
    {
        Saving,
        Current
    }
    internal interface IBankAccount
    {
        int NumberAccount { get; }
        decimal Balance { get; }
        AccountType AccountType { get; }


    }
}
