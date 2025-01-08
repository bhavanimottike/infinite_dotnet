using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment1
{
    class Largestno
    {
        static void Main()
        {
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ENTER  NO TO BE COMPARED");
                arr[i] = int.Parse(Console.ReadLine());

            }
            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(max <arr[i])
                {
                    max= arr[i];
                }
            }
            Console.WriteLine(max);
            Console.Read();



        }
    }
}
