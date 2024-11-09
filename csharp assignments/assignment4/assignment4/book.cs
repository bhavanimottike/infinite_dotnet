using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class book
    {
         private string Book_Name;
         private string  Author_Name;
        public book(string book_name, string author_name)
        {
            book_name = book_name;
            author_name = author_name;


        }
       





        public void display(string book_name, string author_name)
        {
            Console.WriteLine("BOOK NAME:  {0} ",book_name);
            Console.WriteLine("AUTHOR NAME  {0} ",author_name);
        }
    }
        
        
    
    class bookdriver
    {
        public static void Main()
        {
            Console.WriteLine("ENTER BOOK NAME");
            Console.WriteLine("ENTER AUTHOR NAME");
            string book_name = Console.ReadLine();
            string author_name = Console.ReadLine();
            book obj2 = new book(book_name, author_name);
            obj2.display(book_name,author_name);
            Console.Read();
            
            
        }

    }
}
