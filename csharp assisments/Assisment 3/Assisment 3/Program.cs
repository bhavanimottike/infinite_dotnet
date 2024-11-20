using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_3
{
    class cricketmatch
    {
        public void Points_calulation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];
            int sum = 0;
            Console.WriteLine($"enter the score for {no_of_matches} matches : ");
            for(int i =0;i< no_of_matches;i++)
            {
                Console.WriteLine($"match {i + 1} scre");
                scores[i] = int.Parse(Console.ReadLine());
                sum  =sum + scores[i];
            }

            double ave = (double)sum / no_of_matches;
            Console.WriteLine("-------MATCH DETAILS-----");
            Console.WriteLine($"total no of matches played : {no_of_matches}");
            Console.WriteLine($"total score (sum of scores) : {sum}");
            Console.WriteLine($"AVERAGE SCORE OF THE TEAM :{ave} ");
            

        }
        class programe
        {
            public static void Main()
            {

                filetextappend.chech_file();
                Console.WriteLine("enter no of matches played");
               int no_of_matches = int.Parse(Console.ReadLine());
                cricketmatch obj = new cricketmatch();
                obj.Points_calulation(no_of_matches);
                
                Console.Read();
            }
        }


    }
}
