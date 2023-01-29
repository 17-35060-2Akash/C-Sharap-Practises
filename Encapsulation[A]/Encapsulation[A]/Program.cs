using MyLibrary;
namespace Encapsulation_A_
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP Priciples
            //1. Encapsulation
            //2. Inheritance
            //3. Polymorphism
            //4. Abstraction

            //Object Members
            //1. Attributes-Fields,Properties
            //2. Operations-Methods

            //Encapsulation
            //Access Modifiers for types
            //1.public
            //2.internal

            //Access Modifiers for members
            /*
            1.public 
            2.private
            3.protected
            4.internal
            5.protected internal
            */

            //Context-access
            //1. within class-public,private,protected,internal,protected internal
            //2. outside of the class but from same assembly-public,internal,protected internal
            //3. outside of the class but from different assembly-public
            //4. from child/sub/derived class-public,protected,internal(child->same assembly),
                                                             //protected internal

            Account a = new Account();
            a.accountName = "abc";//public
        }
    }
}
