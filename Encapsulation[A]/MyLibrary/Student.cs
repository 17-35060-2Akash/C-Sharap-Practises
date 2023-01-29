using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Student
    {
        public Student()
        {
            Account a = new Account();
            a.accountName = "def";//public
            a.address = "Kuratoli";//protected internal
            a.voterId = 10001;//internal
        }
    }
}
