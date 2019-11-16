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
            while (choice != 4)
            {
                Console.WriteLine("************************** Welcome to Banking App ****************************\n");
                Console.WriteLine("1. Check Balance:\n");
                Console.WriteLine("2. Withdraw Cash:\n");
                Console.WriteLine("3. Deposit Cash:\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("************************** Choose and option ****************************\n");

                choice = int.Parse(Console.ReadLine());

                switch (choice) {
                    case 1:
                        Console.WriteLine("\nYour balance is £ {0}", balance);
                        break;

                    case 2:
                        Console.WriteLine("\nEnter the amount you want to withdraw?");
                        withdrawAmt = int.Parse(Console.ReadLine());
                        if (withdrawAmt % 100 != 0)
                        {
                            Console.WriteLine("\nDenominations available 100, 500, 2000.  Your amount count not be processed.");
                        }
                        else if (withdrawAmt > balance)
                        {
                            Console.WriteLine("/n Insufficiant funds");
                        }
                        else
                        {
                            balance = balance - withdrawAmt;
                            Console.WriteLine("\n\nYour transaction has been processed");
                            Console.WriteLine("\nYour balance is £{0}", balance);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter the amount you wish to deposit?" );
                        depositeAmt = int.Parse(Console.ReadLine());
                        balance = balance + depositeAmt;
                        Console.WriteLine("\nYour deposit has been processed.");
                        Console.WriteLine("\nYour balance is £{0}",balance);
                        break;
                    case 4:
                        Console.WriteLine("\nThank you for using Bazza bank.");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}