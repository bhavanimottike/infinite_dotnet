using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_3
{
    class Box
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public Box(int l, int b)
        {
            length = l;
            breadth = b;

        }
        public static  void Addbox(Box b1,Box b2)
        {
            int nlength = b1.length + b2.length;
            int nbreadth = b1.breadth + b2.breadth;
            Console.WriteLine("new length {0} , new breadth {1}", nlength, nbreadth);

        }
       
    }
     class Test
    {
        public static void Main()
        {
            Console.WriteLine("---box1 details--------");
            Console.WriteLine("enter length of box 1");
            int length1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth of box 1");
            int breadth1 = int.Parse(Console.ReadLine());
            Box b1 = new Box(length1,breadth1);
            Console.WriteLine("---box2   details--------");
            Console.WriteLine("enter length of box 2");
            int length2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth of box 2");
            int breadth2 = int.Parse(Console.ReadLine());
            Box b2 = new Box(length2, breadth2);
           

            Console.Read();


        }
    }
}
