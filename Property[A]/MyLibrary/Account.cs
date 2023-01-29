using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Account
    {
        private int accountNumber;
        private string accountName, email;
        private double balance;

        public void SetAccountName(string accountName)
        {
            this.accountName = accountName;
        }

        public string GetAccountName()
        {
            return this.accountName;
        }

        //Property
            //1.Property
            //2.Automatic/Auto-implemented property

        //Read-only/Write-only property
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        //Auto-implemented property

        public int PhoneNumber
        {
            set;
            get;
        }
    }
}
