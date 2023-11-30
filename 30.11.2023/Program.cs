using System;

namespace _30._11._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11.1");
            BankAccount_A_Fabric bankAccount_A_Fabric = new BankAccount_A_Fabric();
            IBankAccount bank1 = bankAccount_A_Fabric.CreateAccount(AccountType.Saving, 1000000);
            IBankAccount bank2 = bankAccount_A_Fabric.CreateAccount(AccountType.Current);
            Console.WriteLine($"Номер аккаунта - {bank1.NumberAccount}  Баланс - {bank1.Balance} , Тип - {bank1.AccountType}.");
            Console.WriteLine($"Номер аккаунта - {bank2.NumberAccount}  Баланс - {bank2.Balance} , Тип - {bank2.AccountType}.");

            Console.WriteLine("12.1");
            BrickBuild brick = new BrickBuild();
            Console.WriteLine(Creator.CreateBuild(100, 10, 60, 1, brick));
            Console.WriteLine();
            PanelBuild panel = new PanelBuild();
            Console.WriteLine(Creator.CreateBuild(80, 20, 60, 2, panel));

            Creator.CloseBuild(1);
            Console.WriteLine("\nПосле удаления из хеш таблицы здания:\n");
            Creator.PrintHashtable();

            Console.ReadKey();
        }
    }
}
