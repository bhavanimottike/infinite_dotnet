using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class indexers
    {

        private string bookname;
        private string authorname;
        public indexers(string bookname, string authorname)
        {
            this.authorname = authorname;
            this.bookname = bookname;


        }
        public void display()
        {
            Console.WriteLine(authorname + "  is author name of the book  " + bookname);

        }

    }
    class book_shelf
    {
        indexers[] obj = new indexers[5];
        public indexers this[int position]
        {
            get
            {
                return obj[position];

            }
            set
            {
                obj[position] = value;
            }

        }
        class dricer
        {
            public static void Main()
            {
                book_shelf obj1 = new book_shelf();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("enter book name");
                    string bookname = Console.ReadLine();
                    Console.WriteLine("enter author name");
                    string authorname = Console.ReadLine();
                    obj1[i] = new indexers(bookname, authorname);
                }
                for (int i = 0; i < 5; i++)
                {
                    obj1[i].display();
                }
                Console.Read();


            }

        }
    }
}
