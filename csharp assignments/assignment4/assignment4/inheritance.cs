using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Employee
    {
       public int Employeeid;
       public string Employeename;
        public int Employeesalary;
        public Employee(int employeeid,string employeename,int employeesalary)
        {
            Employeeid = employeeid;
            Employeename = employeename;
            Employeesalary = employeesalary;


        }
    }
    class parttime_employ : Employee
    {
        public parttime_employ( int employeeid,string employeename,int employeesalary )
            :base( employeeid, employeename, employeesalary)

        {


        }
        public void wages(int employeeid, string employeename, int employeesalary)
        {
            Console.WriteLine("EMPLOYEE IS = {0}", Employeeid);
            Console.WriteLine("EMPLOYEE NAME IS  {0}", Employeename);
            Console.WriteLine("EMPLOYEE SALARY  {0}", Employeesalary);
        }
       
       
    }
    class inheritancedriver
    {
        public static void Main()
        {
            Console.WriteLine("ENTER EMPLOYEE ID");
           int  employeeid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("EMPLOYE NAME");
           string employeename = Console.ReadLine();
            Console.WriteLine("ENTER SALARY");
           int  employeesalary = Convert.ToInt32(Console.ReadLine());

            parttime_employ obj3 = new parttime_employ(employeeid, employeename, employeesalary);
            obj3.wages(employeeid,employeename, employeesalary);
            Console.Read();
        }
    }
}
