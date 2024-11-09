using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class scholarship
    {
        double fee;
        double marks;
        double scholarship_amount;
        public void merit()
        {
            Console.WriteLine("enter fees");
            fee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks");
            marks = Convert.ToInt32(Console.ReadLine());
            if( marks <=80 &&  marks>=70)
            {
                scholarship_amount = fee * ((double)20 / 100);
                Console.WriteLine(scholarship_amount);


            }
            if(marks>=80 && marks <= 90)
            {
                scholarship_amount = fee * ((double)30 / 100);
                Console.WriteLine(scholarship_amount);

            }
            if (marks > 90)
            {
                scholarship_amount = fee * ((double)50 / 100);
                Console.WriteLine(scholarship_amount);

            }

        }
    }
    class driver
    {
        public static void Main()
        {
            scholarship obj = new scholarship();
            obj.merit();
            Console.Read();
        }


    }
}
