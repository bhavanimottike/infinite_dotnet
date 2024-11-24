using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6


{
    class Employeedetails
    {
        public int employid { get; set; }
        public string employname { get; set; }
        public string employcity { get; set; }
        public double employsalary { get; set; }




        public void employ()
        {
            List<Employeedetails> emplist = new List<Employeedetails>();


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter employ {0}, details", i);
                Console.WriteLine("enter employ id");
                int emploId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter employ name");
                string EmployName = Console.ReadLine();
                Console.WriteLine("enter employ city");
                string city = Console.ReadLine();
                Console.WriteLine("enter employ salary");
                double salary = Convert.ToDouble(Console.ReadLine());


                emplist.Add(new Employeedetails
                {
                    employid = emploId,
                    employname = EmployName,
                    employcity = city,
                    employsalary = salary,





                });
            }
            Console.WriteLine("---------all details----------------");
            foreach (var n in emplist)
            {
                Console.WriteLine("emp id is {0},employ name: {1}, city {2}, salay {3}", n.employid, n.employname, n.employcity, n.employsalary);
            }

            Console.WriteLine("------------salary greater than 45000-----------------");
            var salarygreater = emplist.FindAll(salary  =>salary.employsalary> 45000);
            foreach (var n in salarygreater)
            {
                Console.WriteLine("emp id is {0},employ name: {1}, city {2}, salay {3}", n.employid, n.employname, n.employcity, n.employsalary);
            }
            Console.WriteLine("--------employs from banglore------------------------");
            var empfrombang = emplist.FindAll(name => name.employcity=="banglore");
            foreach (var n in empfrombang)
            {
                Console.WriteLine("emp id is {0},employ name: {1}, city {2}, salay {3}", n.employid, n.employname, n.employcity, n.employsalary);
            }
            Console.WriteLine("-------------------ascending order---------");
            var Ascending = emplist.OrderBy(empname => empname.employname);
            foreach (var n in Ascending)
            {
                Console.WriteLine("emp id is {0},employ name: {1}, city {2}, salay {3}", n.employid, n.employname, n.employcity, n.employsalary);
            }
            Console.Read();
        }
    }





    class employdisplay
    {
        public static void Main()
        {
            Employeedetails obj3 = new Employeedetails();
            obj3.employ();
        }
    }
}
