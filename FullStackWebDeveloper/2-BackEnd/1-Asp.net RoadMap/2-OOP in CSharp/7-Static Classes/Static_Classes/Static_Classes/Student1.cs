using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    //Non-static class can have static members or methods.
    //Static class must all of it is members and methjods become static.
    //Any static methods use only static variables but Non-static methods can have static members. 
    class Student1
    {
        //Access Modifiers are not allowed with static keyword in Constructors signature declaration. 
        //Static constructor is only called one time in the propgram.
        static Student1()
        {
            Console.WriteLine("Hello World!");
        }
        public static string Name = "Maher";
        public string Address = "Faisal";
        public void PrintName()
        {
            Console.WriteLine("Hello Maher");
        }
        //Static members or methods can be called directly by class without making any object from it.
        //static is in class level not object level.
        public static void PrintYpourSpecification()
        {
            Console.WriteLine("Software Engineering and Back-end Developer with C#");
        }
        public void CallName1()
        {
            Console.WriteLine(Name);//This is Allowed
        }
        public static void CallName2()
        {
            //Console.WriteLine(Address);This is not allowed.
        }
    }
    public static class Student2
    {
        public static int Counter = 0;
        static Student2()
        {
            Console.WriteLine("Constructor is called.");
        }
        public static string Name()
        {
            Counter++;
            return "Hello World";
        }
        /* public string Address()
          {
              return "Faisal";
          }
        *///This is not allowed.
    }
}
