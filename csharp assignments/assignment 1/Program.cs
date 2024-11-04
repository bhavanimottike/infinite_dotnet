using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public static void CompareNO()
        {
            Console.WriteLine("enter a number");
            int no1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2 nd number");
            int no2 = Convert.ToInt32(Console.ReadLine());
            if (no1 == no2)
                Console.WriteLine("The {0} is equal to {1}", no1, no2);
            else Console.WriteLine("The {0} is not equal to {1}", no1, no2);

        }
        public static void PosiviteNegative()
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("{0} is a positive number",a);
            else if (a == 0)
                Console.WriteLine("{0} is equal to zero", a);
            else Console.WriteLine("{0} is a negative number", a);
        }
        public static void ArithematicOPerations()
        {
            Console.WriteLine("enter a no");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 nd no");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter arithematic operator need to perform ");
            char op = Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case '+':
                    Console.WriteLine(b + c);
                    break;
                case '-':
                    Console.WriteLine(b - c);
                    break;
                case '*':
                    Console.WriteLine(b * c);
                    break;
                case '/':
                    Console.WriteLine(b / c);
                    break;
                default:
                    Console.WriteLine("enter a valid operator");
                    break;

            }

          



        }
        public static void Table()
        {
            Console.WriteLine("enter number for table");
            int t = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < 11) 
            {
                Console.WriteLine("{0} * {1} = {2}",t,i,t*i);
                i = i + 1;           
            }
        }
         

        public static void Compute()
        {
            Console.WriteLine("enter a no");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2 nd no");
            int f = Convert.ToInt32(Console.ReadLine());
            int sum = e + f;
            if (e == f)
                Console.WriteLine(sum * 3);
            else Console.WriteLine(sum);


        }
    }

    class driver
    {
        public static void Main()
        {
            Program.CompareNO();
            Console.WriteLine("checking no positive or negative");
            Program.PosiviteNegative();
            Console.WriteLine("arithematic operations");
            Program.ArithematicOPerations();
            Console.WriteLine("table");
            Program.Table();
            Console.WriteLine("compute");
            Program.Compute();
            Console.Read();
        }
    }
}
