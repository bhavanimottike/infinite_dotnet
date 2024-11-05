using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Student
    {
      protected  int RollNo;
        protected string Stud_Name;
        protected string Class;
        protected string semester;
        protected string Branch;
        protected int[] Marks = new int[5];

        public Student(int rollno, string name, string cls, string SEM, string branch)
        {
            RollNo = rollno;
            Stud_Name = name;
            Class = cls;
            semester = SEM;
            Branch = branch;
        }
    }

    class Score : Student
    {
        public Score(int rollno, string name, string cls, string SEM, string branch)
            : base(rollno, name, cls, SEM, branch)
        {

        }
        public void get_marks()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter  sub {0} marks", i + 1);
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void display()
        {
            int sum = 0;
            float ave = 0;
            foreach (int item in Marks)
            {

                sum = sum + item;
            }
            ave = sum / 5;
            Console.WriteLine("average of marks : {0}", ave);
            bool res = true;
            for (int i = 0; i < 5; i++)
            {
                if (Marks[i] < 35)
                {
                    Console.WriteLine("Failed in sub{0}", i + 1);
                     res = false;
                    
                }
                
            }
         if(ave < 50 || res==false)
           {
                Console.WriteLine("FAILED");
                
            }
          else if(ave>50 && res==true)
            {
                Console.WriteLine("PASSED");
            }
        }




    }
    class test
    {
        public static void Main()
        {
            Console.WriteLine("ENTER ROLLNO");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER NAME");
            string name = Console.ReadLine();
            Console.WriteLine("ENTER CLASS");
            string cls = Console.ReadLine();
            Console.WriteLine("ENTER SEMESTER");
            string SEM = Console.ReadLine();
            Console.WriteLine("ENTER BRANCH");
            string branch = Console.ReadLine();
            Score obj1 = new Score(rollno, name, cls, SEM, branch);
            obj1.get_marks();
            obj1.display();
            Console.Read();

        }
    }

    }
