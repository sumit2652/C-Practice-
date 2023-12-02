using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = calculate();
            Console.WriteLine($"This is the result for adding: {result}");
            Console.Read();
        }

        public static int calculate()
        {
            Console.WriteLine("Please enter the first number");
            string num1input = Console.ReadLine();
            Console.WriteLine("Please enter secound number");
            string num2input = Console.ReadLine();

            int num1 = int.Parse(num1input);
            int num2 = int.Parse(num2input);

            int result = num1 + num2;
            return result;
        }
    }
}