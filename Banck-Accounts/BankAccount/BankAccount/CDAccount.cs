//Tsirekidze Mariam
//ID:823460489

using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class CDAccount : SavingsAccount
    {
        private DateTime date;

        //constructor with call base class SavingsAccount constructor
        public CDAccount(string AccountNum, double Rate, double Balance, DateTime Date) 
            : base(AccountNum, Rate, Balance)
        {
            date = Date;
        }

        //default constructor
        public CDAccount() : base()
        {
            date = new DateTime();
        }
        //return string representation of CDAccount object
        public override string ToString() =>
            $"Account Number : {AccountNum} \n" +
            $"Interest Rate: {Rate}\n" +
            $"Balance: ${Balance}\n" +
            $"Date of Maturity: {date}\n";

        
        
    }
}
