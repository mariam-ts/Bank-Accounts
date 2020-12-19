//Tsirekidze Mariam
//ID:823460489
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class SavingsAccount
    {
        public string AccountNum { get; set; }  // properties
        public double Rate { get; set; }
        public double Balance { get; set; }

        public SavingsAccount(string accountNum, double rate, double balance) //constructor
        {
            AccountNum = accountNum;
            Rate = rate;
            Balance = balance;
        }
       
        public SavingsAccount() //default constructor
        {
            AccountNum = null;
            Rate = 0.0;
            Balance = 0.0;
        }
        public void deposite(double depos) //increase balance function
        {
            Balance = Balance + depos;
        }
        public void withdrow(double withdr) //decrease balance function
        {
            if(withdr>Balance)
            {
                Console.WriteLine("You don't have enough money on the account, try less amount\n");
            }
            else
            {
                Balance = Balance - withdr;
            }
            
        }
    }
}
