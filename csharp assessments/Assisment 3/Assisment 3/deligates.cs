using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_3
{
    class deligate
    {

        public delegate int CalculatorDelegate(int x, int y);
        public static void Main()
        {
            Console.WriteLine("Welcome to the Delegate");
            while (true)
            {
                Console.WriteLine("\nChoose an operation:"); Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();
                if (choice == "4")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());
                CalculatorDelegate calcDelegate;
                switch (choice)
                {
                    case "1":
                        calcDelegate = Add;
                        break;
                    case "2":
                        calcDelegate = Subtract;
                        break;
                    case "3":
                        calcDelegate = Multiply;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }
                int result = calcDelegate(num1, num2);
                Console.WriteLine($"The result is: {result}");
            }
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;

        }
        public static int Multiply(int x, int y)
        {
            return x * y;

        }

    }
}
