using System;

namespace Tumakov_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("12.1");
            BankAccount_12 ac1 = new BankAccount_12(1201200, BankAccount_12.AccountType.Current);
            BankAccount_12 ac2 = new BankAccount_12(21323123, BankAccount_12.AccountType.Savings);
            Console.WriteLine("Работа ToString():");
            Console.WriteLine("Первый аккаунт:");
            Console.WriteLine(ac1.ToString());
            Console.WriteLine("Второй аккаунт:");
            Console.WriteLine(ac2.ToString());
            Console.WriteLine("Проверка ==:");
            if (ac1 == ac2)
            {
                Console.WriteLine("Равны");
            }
            else
            {
                Console.WriteLine("Неравны");
            }

            Console.WriteLine("Проверка !=:");
            if (ac1 != ac2)
            {
                Console.WriteLine("Неравны");
            }
            else
            {
                Console.WriteLine("Равны");
            }

            Console.WriteLine("Проверка Equals:");
            if (ac1.Equals(ac2))
            {
                Console.WriteLine("Равны");
            }
            else
            {
                Console.WriteLine("Неравны");
            }

            Console.WriteLine("12.2");
            RationalNumbers n1 = new RationalNumbers(1, 2);
            RationalNumbers n2 = new RationalNumbers(4, 5);

            Console.WriteLine(n1.ToString() + " + " + n2.ToString() + $" = {n1 + n2}");
            Console.WriteLine(n1.ToString() + " - " + n2.ToString() + $" = {n1 - n2}");
            Console.WriteLine(n1.ToString() + " * " + n2.ToString() + $" = {n1 * n2}");
            Console.WriteLine(n1.ToString() + " / " + n2.ToString() + $" = {n1 / n2}");
            Console.WriteLine(n1.ToString() + " % " + n2.ToString() + $" = {n1 % n2}");
            Console.WriteLine(n1.ToString() + "++ " + $" = {++n1}");
            Console.WriteLine(n2.ToString() + "-- " + $" = {--n2}\n");

            Console.WriteLine(n1.ToString() + " == " + n2.ToString() + $" : {n1 == n2}");
            Console.WriteLine(n1.ToString() + " != " + n2.ToString() + $" : {n1 != n2}");
            Console.WriteLine(n1.ToString() + " > " + n2.ToString() + $" : {n1 > n2}");
            Console.WriteLine(n1.ToString() + " < " + n2.ToString() + $" : {n1 < n2}");
            Console.WriteLine(n1.ToString() + " >= " + n2.ToString() + $" : {n1 >= n2}");
            Console.WriteLine(n1.ToString() + " <= " + n2.ToString() + $" : {n1 <= n2}");

            Console.WriteLine("12.1 DZ");

            ComplexNumber z1 = new ComplexNumber(2, 5);
            ComplexNumber z2 = new ComplexNumber(5, 9);
            Console.WriteLine(z1.ToString() + " + " + z2.ToString() + $" = {z1 + z2}");
            Console.WriteLine(z1.ToString() + " - " + z2.ToString() + $" = {z1 - z2}");
            Console.WriteLine(z1.ToString() + " * " + z2.ToString() + $" = {z1 * z2}\n");

            Console.WriteLine(z1.ToString() + " == " + z2.ToString() + $" => {z1 == z2}");
            Console.WriteLine(z1.ToString() + " != " + z2.ToString() + $" => {z1 != z2}");
            Console.ReadKey();
        }
    }
}
