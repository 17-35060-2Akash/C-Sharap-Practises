using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class SavingsAccount:Account
    {
        public SavingsAccount()
        {
            this.accountName = "def";//public
            this.address = "Kuratoli";//protected internal
            this.voterId = 10001;//internal
            this.email = "something@anything.com";//protected

        }
    }
}
