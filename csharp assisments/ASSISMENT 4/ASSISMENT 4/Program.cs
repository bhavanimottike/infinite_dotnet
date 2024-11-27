
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_4
{
    public class Employee_details
    {
        public int Employ_Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public string Title { get; set; }
        public string city { get; set; }

    }
    class Program
    {
        static void Main()
        {
            List<Employee_details> emp = new List<Employee_details>
            {
                new Employee_details{Employ_Id=1001,FName= "Malcolm", LName= "Daruwalla", Title= "Manager", city="Mumbai"},
                new Employee_details{Employ_Id=1002,FName= "Asdin", LName= "Dhalla", Title= "AsstManager",city="Mumbai"},
                new Employee_details{ Employ_Id=1003, FName= "Madhavi", LName= "Oza", Title= "Consultant",city="Pune"},
                new Employee_details{ Employ_Id=1004, FName= "Saba", LName= "Shaikh", Title= "SE", city="Pune"},
                new Employee_details{Employ_Id=1005,FName= "Nazia", LName= "Shaikh", Title= "SE", city="Mumbai"},
                new Employee_details{Employ_Id=1006,FName= "Amit", LName= "Pathak", Title= "Consultant",city="Chennai"},
                new Employee_details{Employ_Id=1007,FName= "Vijay", LName= "Natarajan", Title= "Consultant",city="Mumbai"},
                new Employee_details{Employ_Id=1008,FName= "Rahul", LName= "Dubey", Title= "Associate", city="Chennai"},
                new Employee_details{Employ_Id=1009,FName= "Suresh", LName= "Mistry", Title= "Associate",city="Chennai"},
                new Employee_details{Employ_Id=1010,FName= "Sumit", LName= "Shah", Title= "Manager",city="Pune"}
                };
            
            foreach (var x in emp)
            {
                Console.WriteLine($"Employee Id : {x.Employ_Id} , Employee FirstName : {x.FName},Employee LastName : {x.LName} ,Title : {x.Title},Employee City : {x.city}");
            }
            
            var ans1 = emp.Where(e1 => e1.city.ToLower() != "mumbai");
            Console.WriteLine("---------------------------------");
            foreach (var a in ans1)
            {
                Console.WriteLine($"Employee Id : {a.Employ_Id} , Employee FirstName : {a.FName},Employee LastName : {a.LName} ,Title : {a.Title},Employee City : {a.city}");
            }
            
         
            var ans2 = emp.Where(e2 => e2.Title.ToLower() == "asstmanager");
            Console.WriteLine("---------------------------------");
            foreach (var x in ans2)
            {
                Console.WriteLine($"Employee Id : {x.Employ_Id} , Employee FirstName : {x.FName},Employee LastName : {x.LName} ,Title : {x.Title},Employee City : {x.city}");
            }

           

            var ans3= emp.Where(e3 => e3.LName.StartsWith("S"));
            Console.WriteLine("---------------------------------");
            foreach (var x in ans3)
            {
                Console.WriteLine($"Employee Id : {x.Employ_Id} , Employee FirstName : {x.FName},Employee LastName : {x.LName} ,Title : {x.Title},Employee City : {x.city}");
            }
            Console.Read();
        }
    }
}
