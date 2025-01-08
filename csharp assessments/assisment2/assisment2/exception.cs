using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment2
{
    class NegativeNumException : ApplicationException
    {
        public NegativeNumException(string msg): base(msg)
        {

        }




  
    }
    class  Tester
    {
        static void checkno(int number)
        {
            if(number<0)
            {
                throw new ArgumentException("the number is negative");
            }

        }
        static void Main()
        {
            try
            {
                Console.WriteLine("enter a number");
                int number = int.Parse(Console.ReadLine());
                checkno(number);

                Console.WriteLine(" number is positive");
            }
            catch (ArgumentException neg)
            {
                Console.WriteLine("number entered is negative and {0}", neg.Message);
            }
            Console.Read();
        }
    }

}

