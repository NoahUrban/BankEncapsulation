using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount Noah = new BankAccount();

            Noah.GetBalance();

            Console.WriteLine();
            Console.WriteLine("Please enter your deposit amount...");
            Noah.Deposit(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Press any key to see your account balance");
            Console.ReadKey();

            Console.WriteLine();
            Noah.GetBalance();
        }
    }
}
