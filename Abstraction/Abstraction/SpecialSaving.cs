using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class SpecialSaving:Account
    {
        public  double OpeningBalance { get; }
        public SpecialSaving() { }
         
        public SpecialSaving(string accName, string accNo, double balance,double openingbalance):base(accName, accNo,balance)
        {
            openingbalance = OpeningBalance;
        }
        public override void Deposit(double amount)
        {
            Balance = OpeningBalance + amount;
        }
        public override void Withdraw(double amount)
        {
            if (Balance -amount= 20 * OpeningBalance / 100)
            {
                Balance - amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            
            }
        }
        public override void Transfer(Account a, double amount)
        {


        }  
    }
}
