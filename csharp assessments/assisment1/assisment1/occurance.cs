using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment1.Properties
{
    class occurance
    { 
        static void Main()
        {
            Console.WriteLine("ENTER A STRING");
            string wordcoun= Console.ReadLine();
            Console.WriteLine("ENTER A CHARACTER");
            Char ch = char.Parse(Console.ReadLine());
            int count = 0;
            foreach(char c in wordcoun)
            {
                if (char.ToLower(c) == char.ToLower(ch))
                {
                    count++;

                }
                




            }
            Console.WriteLine(count);
            Console.Read();
        }
    
    }
}
