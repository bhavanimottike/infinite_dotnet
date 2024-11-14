using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class readfile
    {
        public void ReadDatainfile()
        {
            FileStream objfs = new FileStream("newfirstfile.txt", FileMode.Open, FileAccess.Read);

            StreamReader strmr = new StreamReader(objfs);


            string str2 = strmr.ReadLine();
            int count = 0;

            while (str2 != null)
            {
                Console.WriteLine("{0} ", str2);
                str2 = strmr.ReadLine();
                count++;
            }

            Console.WriteLine("number of lines in string: {0}", count);


            strmr.Close();
            objfs.Close();


        }
        static void Main()
        {
            readfile file = new readfile();
            file.ReadDatainfile();
            Console.Read();
        }
    }
}
