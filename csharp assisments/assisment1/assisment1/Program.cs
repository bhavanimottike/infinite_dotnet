using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a string");
            string word = Console.ReadLine();
            Console.WriteLine("ENTER POSITION");
            int pos = int.Parse(Console.ReadLine());
            if (pos < 0 || pos > word.Length)
            {
                Console.WriteLine("ENTER A VALID POSITION");
            }
            else
            {
                string Resultword = word.Remove(1,pos);
                Console.WriteLine(Resultword);
            }
            Console.ReadLine();

        }
    }
}
