using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisment_3
{
    class filetextappend
    {
        public static void chech_file()
        {
            Console.WriteLine("ENTER FILE NAME");
            String filePath = Console.ReadLine();
                FileStream objf = new FileStream("newfile1.txt", FileMode.Append, FileAccess.Write);
                StreamWriter stw = new StreamWriter(objf);
                Console.WriteLine("Enter data :");
               string data = Console.ReadLine();
                
               stw.WriteLine(data);
                


                stw.Flush();
                stw.Close();
                objf.Close();
            }
        public static void Main(string[] args)
        {
            filetextappend.chech_file();
            Console.Read();
        }
    }
}

       
  