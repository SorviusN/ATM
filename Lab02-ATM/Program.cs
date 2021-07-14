using System;

namespace Lab02_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void InitiateProgram()
        {
            Decimal balance = 0;
            string input = "";

            while (input != "x")
            {
                Console.WriteLine(
                    "Welcome to Harborstone. What would you like to do today?\n" +
                    "");
                switch(input.ToLower())
                    {
                        case "a":
                            break;
                        default:
                            Console.WriteLine("Input not found. Please try again with correct input.");
                            break;
                    }

            }
        }
    }
}
