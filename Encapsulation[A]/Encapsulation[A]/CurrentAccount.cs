using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_A_
{
    class CurrentAccount:Account
    {
        public CurrentAccount()
        {
            this.accountName = "def";//public
            this.address = "Kuratoli";//protected internal
            this.email = "something@anything.com";//protected
        }
    }
}
