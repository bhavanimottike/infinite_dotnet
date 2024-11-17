using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        public void squares()
        {
            List<int> num = new List<int> { };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter {0} element of list", i);
                int a = Convert.ToInt32(Console.ReadLine());
                num.Add(a);

            }
            var squarenum = num.Select(b => b * b).Where(x => x > 20);

            foreach (var item in squarenum)
            {
                Console.Write("{0}   ", item);


            }

            Console.Read();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.squares();
        }
    }
}

