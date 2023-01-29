using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_A_
{
    enum Week:sbyte
    {
        Sunday=1,
        Monday,
        Tuesday,
        Wednesday=-5,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name of the day:"+Week.Friday+"\tValue of the day:"+(sbyte)Week.Friday);
            //Console.WriteLine((sbyte)Week.Monday);
            Week w = Week.Saturday;
            Console.WriteLine((sbyte)w);
            
        }
    }
}
