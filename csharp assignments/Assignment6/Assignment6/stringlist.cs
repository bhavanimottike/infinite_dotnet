using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class stringlist
    {
        public void firndlast()
        {
            List<string> words = new List<string> { };
            for(int i =0;i <3;i++)
            {
                Console.WriteLine("enter {0} th element of string",i);
                string b = Console.ReadLine();
                words.Add(b);
            }
            IEnumerable<string> listprinted = from word in words 
                                              where word.StartsWith("a") && word.EndsWith("m")
                                              select word;

            foreach (var n in listprinted)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }
        
    }
    class driver
    {
        public static void Main()
        {
            stringlist obj1 = new stringlist();
            obj1.firndlast();
        }
    }

}
