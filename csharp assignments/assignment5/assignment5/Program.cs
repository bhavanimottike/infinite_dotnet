using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Books
    {
        private string bookname;
        private string author;

        public Books(string bookname, string authorname)
        {
            bookname = bookname;
            authorname = authorname;


        }
       public void display(string bookname,string authorname)
        {
            Console.WriteLine("the book name is {0}", bookname);
            Console.WriteLine("the author name of book {0} is {1}", bookname, authorname);
        }
    }
    class test
    {
        public static void Main()
        {
            Console.WriteLine("enter book name");
            string bookname = Console.ReadLine();
            Console.WriteLine("enter author name");
            string authorname = Console.ReadLine();
            Books obj = new Books(bookname,authorname);
            obj.display(bookname, authorname);
            Console.Read();

        }
    }
}
