using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment5
{
    class filecreation
    {
        static void Main()
        {
            fileadd file = new fileadd();
            file.WriteData();
            Console.Read();
        }
    }
    class fileadd
    {
        public void WriteData()
        {
            FileStream objf = new FileStream("newfirstfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter stw= new StreamWriter(objf);
            Console.WriteLine("Enter a array length :");
            int l = Convert.ToInt32(Console.ReadLine());
            string[] arraystr = new string[l];
            for(int i=0;i<l;i++)
            {
                Console.WriteLine("Enter the {0} element", i + 1);
                arraystr[i] = Console.ReadLine();
            }
            foreach(var text in arraystr)
            {
                stw.WriteLine(text);
            }
            

            stw.Flush();
            stw.Close();
            objf.Close();
        }
    }
}
