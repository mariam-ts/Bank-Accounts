//Tsirekidze Mariam
//ID:823460489
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            //create list of CDAccounts
            List<CDAccount> listOfAcc = new List<CDAccount>(); 

            //add accounts
            listOfAcc.Add(new CDAccount("TB0000123456", 0.2, 12111.29, new DateTime(2020, 04, 5)));
            listOfAcc.Add(new CDAccount("TB0000123479", 0.3, 692.52, new DateTime(2020, 05, 9)));
            listOfAcc.Add(new CDAccount("TB0000178456", 0.12, 59.61, new DateTime(2022, 11, 23)));
            listOfAcc.Add(new CDAccount("TB0000122556", 0.23, 7560.53, new DateTime(2020, 08, 19)));
            listOfAcc.Add(new CDAccount("TB0000493456", 0.22, 4590.49, new DateTime(2021, 12, 6)));
            listOfAcc.Add(new CDAccount("TB0000151956", 0.16, 851.9, new DateTime(2022, 11, 15)));



            //sort list of accounts by desceding balance
            var filtered =
                from element in listOfAcc
                orderby element.Balance descending
                select element;

            //output the accounts
            foreach(var item in filtered )
            {
                Console.WriteLine(item);
            }

            //check the depostide and withdraw functions if they work
            listOfAcc[1].deposite(1250);
            listOfAcc[5].withdrow(10);

            //sort list of accounts by desceding balance
            var filtered2 =
                from element in listOfAcc
                orderby element.Balance descending
                select element;


            Console.WriteLine("\nAfter operations:\n");
            //output the accounts
            foreach (var item in filtered2)
            {
                Console.WriteLine(item);
            }

            listOfAcc[5].withdrow(10000);



        }
    }
}
