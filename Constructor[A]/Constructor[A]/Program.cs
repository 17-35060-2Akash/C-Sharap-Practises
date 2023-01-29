using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_A_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account account1 = new Account("Shakib",2000.0);
            //account1.ShowAccountInformation();

            //Account account2 = new Account("Tamim",1500.0);
            //account2.ShowAccountInformation();

            //Account account3 = new Account(1500.0,"Nasir");
            //account3.ShowAccountInformation();

            Account account4 = new Account();
            account4.ShowAccountInformation();
        }
    }
}
