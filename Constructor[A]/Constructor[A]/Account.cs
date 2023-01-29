using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_A_
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private static int count = 1;
        //Constructor
        //1.Parameterless/Empty
        //2.Parameterized/Value

        //public Account()
        //{
        //    accountNumber = count;
        //    count++;
        //}

        public Account(string accountName, double balance)
        {
            this.accountName = accountName;
            this.balance = balance;
        }
        public Account(double balance, string accountName) : this(accountName, balance)
        {
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}",
                               this.accountNumber,this.accountName,this.balance);
        }

        ~Account()
        {
            this.balance = 0;
        }

    }

}
