using System;

namespace Lab02_ATM
{
    class Program
    {

        public static decimal Balance = 100; //declaring our 
        static void Main(string[] args)
        {
            try
            {
                IO();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Have a nice day!");
            }
        }

        public static void IO()
        {
            string input = "";

            while (input != "x")
            {
                Console.WriteLine(
                    "Welcome to Harborstone ATM. What would you like to do today?\n" +
                    "View Balance: b\n" +
                    "Widraw: w\n" +
                    "Deposit: d\n" +
                    "Exit: x"
                    );
                input = Console.ReadLine();

                switch(input.ToLower())
                {
                    case "b":
                        ViewBalance();
                        break;
                    case "w":
                        Withdraw();
                        break;
                    case "d":
                        Deposit();
                        break;
                    case "x":
                        break;
                    default:
                        Console.WriteLine("Input not found. Please try again with correct input.");
                        break;
                }
            }
        }

        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your current balance is: {Balance}.");

            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadLine();
            Console.Clear();
            return Balance;
        }

        public static decimal Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw today?");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            Balance -= withdrawAmount;
            if (Balance < 0)
            {
                Balance += withdrawAmount;
                Console.WriteLine("Balance cannot go below zero. Please try again.");
                return 0;
            }
            Console.WriteLine($"Your new balance is {Balance}.");

            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadLine();
            Console.Clear();
            return withdrawAmount;
        }

        public static decimal Deposit()
        {
            Console.WriteLine("How much would you like to deposit today?");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            Balance += depositAmount;
            Console.WriteLine($"Your new balance is {Balance}.");

            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadLine();
            Console.Clear();
            return depositAmount;
        }
    }
}
