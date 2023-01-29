using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Modifiers_A_
{
    class Sample
    {
        //public static void ReceiverMethod(params int[] array)
        //{
        //    for (int i=0;i<array.Length;i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}

        //public static void ReceiverMethod(int x,string s,params object[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i].GetType().ToString() == "System.Int32")
        //        {
        //            Console.WriteLine("int operation");
        //        }
        //        else
        //        Console.WriteLine(array[i]);
        //    }
        //}

        public static void ReceiverMethod(out int x)
        {
            x = 50;
        }
        //public static void ReceiverMethod(ref int x)
        //{
        //    x = 500;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Parameter modifiers
            //params
            //int a = 10;
            //int b = 20;
            //Sample.ReceiverMethod(a, b);
            //Sample.ReceiverMethod(a, b, 100, 500, 1);
            //Sample.ReceiverMethod();

            //Sample.ReceiverMethod(a, "hello", 3.5);
            //Sample.ReceiverMethod(a, "hello", 3.5,'c',false);

            //ref,out
            int a;
            Sample.ReceiverMethod(out a);
            Console.WriteLine(a);
        }
    }
}
