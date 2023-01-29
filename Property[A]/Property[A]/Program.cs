using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
namespace Property_A_
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            //account.SetAccountName("Shakib");
            //Console.WriteLine(account.GetAccountName());
            account.AccountNumber = 1001;
            account.AccountName = "Shakib";
            account.Email = "shakib@gmail.com";
            account.Balance = 2000;
            account.PhoneNumber = 017110000;
            //Console.WriteLine("Account No:"+account.AccountNumber+
            //    "\nAccount Name:"+account.AccountName+
            //    "\nEmail:"+account.Email+
            //    "\nBalance:"+account.Balance);

            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nEmail:{2}\nBalance:{3}\nPhone:{4}",account.AccountNumber,account.AccountName,account.Email,account.Balance,account.PhoneNumber);
        }
    }
}
