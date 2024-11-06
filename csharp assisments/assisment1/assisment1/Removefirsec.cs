using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment1.Properties
{
    class Removefirsec
    {
       static void Main()
        {
            Console.WriteLine("enter a string to exchange characters");
            string word1 = Console.ReadLine();

            if (word1.Length <= 1)
            {
                Console.WriteLine(word1);
               
            }
            else
            {
                char firch = word1[0];
                char lasch = word1[word1.Length - 1];
                string mid = word1.Substring(1, word1.Length - 2);
                string result = lasch + mid + firch;
                Console.WriteLine(result);
                ;

            }
            Console.Read();

        }
      
    }
}
