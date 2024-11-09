using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class insufficient_balance : ApplicationException
    {
        public insufficient_balance(string msg) : base(msg) { }

    }

    class bank_account
    {
        int balance = 5000;
        int amount;
        char transaction_type;
        public bank_account(int amount_up, char transac_type)
        {
             this.amount = amount_up;
            this.transaction_type = transac_type;
        }
           
        public  void balance_check()
        {
            if (transaction_type == 'w' || transaction_type == 'W')
            {
                withdraw();

            }
            else if(transaction_type == 'd' || transaction_type == 'D')
            {
                deposit();

            }





        }
            

        public  void deposit()
        {
            balance = balance + amount;
            Console.WriteLine(balance);


        }
        public  void withdraw()
        {
            try
            {
                if (amount > balance)
                {
                    throw new insufficient_balance(" insufficent balance");
                }
                else if(amount <balance)
                {
                    balance = balance - amount;
                    Console.WriteLine(balance);
                }

            }
            catch (insufficient_balance ap)
            {
                Console.WriteLine("Error:"+ap.Message);

            }
        }



        class driver
        {
            public static void Main()

            {
                Console.WriteLine("enter transaction type withdraw= W, deposit= D");
                char transc_type = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("enter amount");
                int amount_up = Convert.ToInt32(Console.ReadLine());
                bank_account obj = new bank_account(amount_up, transc_type);
                obj.balance_check();
                Console.Read();
            }
        }




    }
}