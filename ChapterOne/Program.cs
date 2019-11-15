using System;

namespace ChapterOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int balance, depositeAmt, withdrawAmt;
            int choice = 0, pin = 0;
            Console.WriteLine("Enter your ledger balance");
            balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you PIN number");
            pin = int.Parse(Console.ReadLine());

            if (pin == 1234)
            {
                Console.WriteLine("Invalid PIN");
                Console.ReadKey(false);
                return;
            }
        }
    }
}