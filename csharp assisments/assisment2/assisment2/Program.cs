using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assisment2
{
    abstract class  student
    {
        public string student_name { get; set; }
        public int student_id { get; set; }
        public double grade { get; set; }

        public abstract bool Ispassed(double grade);

    }
    class undergraduate : student
    {
        public override bool Ispassed(double grade)
        {
           return grade > 70.0;
         }
        

     }
    class graduate : student
    {
        public override bool Ispassed(double grade)
        {
            return grade > 80.0;
        }
    }
     class driver
    {
        static void Main()
        {
            undergraduate obj = new undergraduate { student_name = "bhavani", student_id = 12, grade = 75.5 };
            graduate obj1 = new graduate{student_name = "ashwini", student_id = 15, grade = 85.0};
            Console.WriteLine($" {obj.student_name} (undergraduate)- passed {obj.Ispassed(obj.grade)}");
            Console.WriteLine($" {obj1.student_name}(graduate)-passed : {obj1.Ispassed(obj1.grade)}");
            obj.grade = 64.0;
            obj1.grade = 80.0;
            Console.WriteLine($"{obj.student_name}(undergraduate)-{obj.Ispassed(obj.grade)}");
            Console.WriteLine($"{obj1.student_name}(graduate) -  {obj1.Ispassed(obj1.grade)}");
            Console.Read();
        }
    }
}

