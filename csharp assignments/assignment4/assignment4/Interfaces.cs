using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    // Create an Interface IStudent with StudentId and Name as Properties, void ShowDetails() as its method.
    // Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods
    interface Istudent
    {
        int studentId { get; set; }
        
            
        string Studentname { get; set; }

        void Showdetails();
    }
    class Dayscholar : Istudent
    {
        public int studentId { get; set; }
        public string Studentname { get; set; }
         public void Showdetails()
        {
            Console.WriteLine("days scholar student");
            Console.WriteLine("student id {0}", studentId);
            Console.WriteLine("student name {0}", Studentname);
        }
    }
    class resident : Istudent
    {
        public int studentId { get; set; }
        public string Studentname { get; set; }
        public void Showdetails()
        {
            Console.WriteLine("resident student");
            Console.WriteLine("student id {0}", studentId);
            Console.WriteLine("student name {0}", Studentname);
        }



    }
     class interdriver
    {
        public static void Main()
        {
            Istudent obj = new Dayscholar();
            Console.WriteLine("ENTER STUDENT ID");
            int studentId =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER STUDENT NAME");
            string Studentname = Console.ReadLine();
            obj.studentId = studentId;
            obj.Studentname = Studentname;
            obj.Showdetails();

            Istudent obj1 = new resident();
            Console.WriteLine("ENTER STUDENT ID");
            int student_Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER STUDENT NAME");
            string Student_name = Console.ReadLine();
            obj1.studentId = student_Id;
            obj1.Studentname = Student_name;
            obj1.Showdetails();
            Console.Read();



        }
    }
}
