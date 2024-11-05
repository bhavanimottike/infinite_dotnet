using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rev = "";
            Console.WriteLine("enter a word");
            string s = Console.ReadLine();
            Console.WriteLine("Length of word {0}", s.Length);
            char[] str = s.ToCharArray();
            for(int i=str.Length-1;i>-1;i--)
            {
               rev =rev+ str[i];
            }
            Console.WriteLine("reversed word {0}", rev);
            Console.WriteLine("ENTER TWO WORDS NEED TO BE COMPARED");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (string.Equals(a, b))
            {
                Console.WriteLine("GIVEN STRINGS ARE SAME");
            }
            else Console.WriteLine("GIVEN STRINGS ARE NOT SAME");

            Console.Read();

        }
    }
}
