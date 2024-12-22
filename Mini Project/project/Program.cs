using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{




    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("_________________________");
                Console.WriteLine("*WELCOME TO INDIAN RAIWAY*");
                Console.WriteLine("_________________________");

                Console.WriteLine("Are you a Customer or Admin?");
                Console.WriteLine("PRESS 1 FOR ADMIN");
                Console.WriteLine("PRESS 2 FOR CUSTOMER");
                Console.WriteLine("_________________________");





                int userType = int.Parse(Console.ReadLine()?.ToLower());

                if (userType == 1)
                {
                    Admin.AdminMenu();
                }
                else if (userType == 2)
                {
                    Customer.CustomerMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            
            Console.Read();
        }
    }
}
