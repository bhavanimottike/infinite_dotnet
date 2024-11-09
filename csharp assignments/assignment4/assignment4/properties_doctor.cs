using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    //  Create a Class called Doctor with RegnNo, Name, Feescharged as Private members.Create properties to give values and also to display the same.
    class properties_doctor
    {
        
        private int RegnNO;
        private string name;
        private int feescharged;

        public int regnNo
        {
            get
            {
                return RegnNO;
            }
            set
            {
                RegnNO = value;
            }


        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int feecharged
        {
            get
            {

                return feescharged;
            }
            set
            {
                feescharged = value;
            }

        }
     
    }
    class driveproperties
    {
        public static void Main()
        {
            Console.WriteLine("enter regno ");
            int regnNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name ");
            string Name = Console.ReadLine();
            Console.WriteLine("enter fees charged");
            int feecharged=Convert.ToInt32(Console.ReadLine());

            properties_doctor obj1 = new properties_doctor();
            obj1.regnNo = regnNO;
            obj1.Name= Name;
            obj1.feecharged = feecharged;
            Console.WriteLine("regno is {0}",obj1.regnNo);
            Console.WriteLine("name of doctor {0}",obj1.Name);
            Console.WriteLine("fees charged {0}",obj1.feecharged);
            Console.Read();
        }
    }



}
