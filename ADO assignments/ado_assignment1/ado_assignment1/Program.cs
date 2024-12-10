using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public string Title;
        public DateTime DOB;
        public DateTime DOJ;
        public string City;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
              {
                new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla",Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
                new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla",Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai"},
                new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza",Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh",Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
                new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh",Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
                new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak",Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
                new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan",Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
                new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey",Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
                new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry",Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
                new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah",Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            //1.Display a list of all the employee who have joined before 1 / 1 / 2015
            Console.WriteLine("-----------------------");
            var result1 = employees.Where(a => a.DOJ < new DateTime(2015, 1, 1)).Select(z => z);
            foreach (var x in result1)
            {
                Console.WriteLine($"Employee Id : {x.EmployeeID} , Employee Name : {x.FirstName}{x.LastName} , Title : {x.Title} , DOJ : {x.DOJ.ToShortDateString()} , City : {x.City}");
            }

            //2. Display a list of all the employee whose date of birth is after 1/1/1990
            Console.WriteLine("-----------------------------");
            var result2 = employees.Where(a => a.DOB > new DateTime(1990, 1, 1)).Select(z => z);
            foreach (var x in result2)
            {
                Console.WriteLine($"Employee Id : {x.EmployeeID} , Employee Name : {x.FirstName}{x.LastName} , Title : {x.Title} , DOB : {x.DOB.ToShortDateString()} , City : {x.City}");
            }

            //3. Display a list of all the employee whose designation is Consultant and Associate
            Console.WriteLine("------------------------");
            var result3 = employees.Where(a => a.Title == "Consultant" || a.Title == "Associate").Select(z => z);
            foreach (var x in result3)
            {
                Console.WriteLine($"Employee Id : {x.EmployeeID} , Employee Name : {x.FirstName}{x.LastName} , Title : {x.Title} , City : {x.City}");
            }

            //4. Display total number of employees
            Console.WriteLine("---------------------");
            var result4 = employees.Count();
            Console.WriteLine("Number of Employees : {0} ", result4);

            //5. Display total number of employees belonging to “Chennai”
            Console.WriteLine("-----------------------");
            var result5 = employees.Where(a => a.City == "Chennai").Count();
            Console.WriteLine("Number of Employees : {0} ", result5);

            //6. Display highest employee id from the list

            Console.WriteLine("-----------------------");
            var result6 = employees.Select(a => a.EmployeeID).Max();
            Console.WriteLine("highest employee id : {0} ", result6);

            //7. Display total number of employee who have joined after 1/1/2015
            Console.WriteLine("-----------------------");
            var result7 = employees.Where(a => a.DOJ > new DateTime(2015, 1, 1)).Select(z=> z);
            foreach (var x in result7)
            {
                Console.WriteLine($"Employee Id : {x.EmployeeID} , Employee Name : {x.FirstName}{x.LastName} , Title : {x.Title} , DOJ : {x.DOJ.ToShortDateString()} , City : {x.City}");
            }

            //8. Display total number of employee whose designation is not “Associate”
            Console.WriteLine("---------------------");
            var result8 = employees.Where(a => a.Title != "Associate").Count();
            Console.WriteLine("total number of employee whose designation is not Associate : {0}", result8);

            //9. Display total number of employee based on City
            Console.WriteLine("------------------");
            var result9 = employees.GroupBy(a=> a.City);
            foreach (var x in result9)
            {
                Console.WriteLine($"{x.Key} : {x.Count()}");
            }

            //10. Display total number of employee based on city and title
            Console.WriteLine("---------------------");
            var result10 = employees.GroupBy(a => (a.City, a.Title));
            foreach (var x in result10)
            {
                Console.WriteLine($"{x.Key.City} , {x.Key.Title}: {x.Count()}");
            }

            //11. Display total number of employee who is youngest in the list
            Console.WriteLine("------------------");
            var result11 = employees.OrderBy(a => a.DOB).Last();
            Console.WriteLine("employee who is youngest in the list");
            Console.WriteLine($"Employee Id : {result11.EmployeeID} , Employee Name : {result11.FirstName}{result11.LastName} , Title : {result11.Title} , DOJ : {result11.DOB.ToShortDateString()} , City : {result11.City}");
            Console.Read();
        }
    }
}