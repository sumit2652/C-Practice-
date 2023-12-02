using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculate();
            Console.WriteLine($"This is the result for adding: {result}");

            int userInputAsInt = TryAndCatch();
            Console.WriteLine($"This is the result for the second calculation: {userInputAsInt}");

            Console.Read();
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string num1input = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            string num2input = Console.ReadLine();

            int num1 = int.Parse(num1input);
            int num2 = int.Parse(num2input);

            int result = num1 + num2;
            return result;
        }

        public static int TryAndCatch()
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userInputAsInt))
            {
                return userInputAsInt;
            }
            else
            {
                Console.WriteLine("Invalid input! Defaulting to 0.");
                return 0;
            }
        }
    }
}
