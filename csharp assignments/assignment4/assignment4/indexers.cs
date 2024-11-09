using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class indexers
    {
        int book_id;
        string book_name;
        public indexers(int book_id, string book_name)
        {
            this.book_id = book_id;
            this.book_name = book_name;
        }
        public void display()
        {
            Console.WriteLine(book_id + " book id of book " + book_name);
        }
    }
    class book_shelf
    {
        indexers[] bobj = new indexers[5];
        public indexers this[int pos]
        {
            get
            {
                return bobj[pos];
            }
            set
            {
                { bobj[pos] = value; }

            }
        }
    }
    class indexdriver
    {
        public static void Main()
        {
            book_shelf objec2 =new book_shelf();
            for (int i =0;i<5;i++)
            {
                Console.WriteLine("enter book id",i+1);
                int book_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter book name",i+1);
                string book_name = Console.ReadLine();
                objec2[i] = new indexers(book_id, book_name);
               
                

                
            }
            for(int i=0;i<5;i++)
            {
                objec2[i].display();
            }
            Console.Read();
        }
    }
}
