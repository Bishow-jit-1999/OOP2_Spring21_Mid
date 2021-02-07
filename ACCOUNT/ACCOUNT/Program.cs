using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCOUNT
{
    class Account 
    {
            private String accName;
            private String id;
            private int balance;
            
        public Account()
        {

        }
        public Account(String accName,String id,int balance)
        {
            this.accName = accName;
            this.id = id;
            this.balance = balance;

        }

        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Account name :" + accName);
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Deposited amount :" + amount);
            Console.WriteLine("Balance has been updated and the new balance is:"+balance);
        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Account name :"+accName);
            Console.WriteLine("ID:"+id);
            Console.WriteLine("Withdrawn amount :"+ amount);
            Console.WriteLine("Balance has been updated and the new balance is:"+balance);
        }


        static void Main(string[] args)
        {
            Course cur = new Course("Java", "CSE3201", 3);
            cur.ShowCourseInfo();
            Account acc = new Account("Bishowjit", "18-38250-2", 150000);
            acc.Deposit(50000);
            acc.Withdraw(10000);

            
        }
    }
}
