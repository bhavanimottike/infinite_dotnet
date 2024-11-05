using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class  Account
    {
        protected int accountno;
        protected string Customername;
        protected string Accounttype;
        protected string Transaction_type;
        protected int amount;
         protected int Balance;

         public Account(int Accno, int balance,string cusname,string acctype)
        {
            accountno = Accno;
            Customername = cusname;
            Accounttype = acctype;
            Balance = balance;


        }


    }
    class Check_balancestatus : Account
    {
        public Check_balancestatus(int Accno, int balance, string cusname, string acctype)
            :base(Accno,balance,cusname,acctype)
        {

        }
        

        public void withdrawl(int amount)
        {
            Balance = Balance - amount;

        }
        public void deposit(int amount)
        {
            Balance = Balance +amount;


        }
         public void Check_Balance(string transaction_type,int amount)
        {
            if(transaction_type== "W"|| transaction_type == "w")
            {
                withdrawl(amount);
            }
            else if(transaction_type=="d" || transaction_type =="D")
             {
                deposit(amount);
            }
        }

        public void disp_data()
        {
            Console.WriteLine($"Account No of customer  {accountno}");
            Console.WriteLine($"Customer name of customer  {Customername}");
            Console.WriteLine($"Account type  {Accounttype}");
            Console.WriteLine($"Blance after transaction  {Balance}");

        }
    }
     class check_status

    {
        public static void Main()
        {
            Console.WriteLine("ENTER ACCOUNT NO");
            int Accno = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER BALANCE");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER CUSTOMER NAME");
            string cusname = Console.ReadLine();
            Console.WriteLine("ENTER ACCOUNT TYPE");
            string acctype = Console.ReadLine();
            Check_balancestatus obj = new Check_balancestatus(Accno, balance, cusname, acctype);
            Console.WriteLine("Enter the transaction type : ");
            string trans_type = Console.ReadLine();
            Console.WriteLine("Enter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            obj.Check_Balance(trans_type,amount);
            obj.disp_data();
            Console.Read();
        }
    }

        
}
    
       