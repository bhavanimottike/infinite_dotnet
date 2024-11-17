using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryforcal
{
    public class Calculate

    {
        public void CalculateConcession()
        {

            Console.WriteLine("enter name for ticket");
            string name = Console.ReadLine();

            Console.WriteLine("enter total fare");
            int total_fare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your age for concession");
            int age = Convert.ToInt32(Console.ReadLine());
            int fare = 0;

            if (age < 5)
            {
                Console.WriteLine(name +" Little Champs - Free Ticket");
            }

            else if (age > 60)
            {
                fare = total_fare -(total_fare*30/100);
                Console.WriteLine("dear "+ name + "the fare is  : " + fare);
            }
            else
            {
                Console.WriteLine("dear "+ name + "  Ticket Booking fare  " + total_fare);
            }




        }
    }
}