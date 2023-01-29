using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_vs_Instance_A_
{
    class Sample
    {
        public int instanceVariable;//non-static members
        public static int classVariable;//static members

        public void InstanceMethod()
        {
            instanceVariable = 70;
            classVariable = 80;
        }
        public static void ClassMethod()
        {
            classVariable = 80;
            Sample s = new Sample();
            s.instanceVariable = 70;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.instanceVariable = 7;
            s.InstanceMethod();

            Sample.classVariable = 8;
            Sample.ClassMethod();
        }
    }
}
