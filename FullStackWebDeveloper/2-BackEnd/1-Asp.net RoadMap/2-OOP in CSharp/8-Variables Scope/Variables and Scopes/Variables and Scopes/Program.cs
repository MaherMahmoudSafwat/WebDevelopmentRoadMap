using System.Runtime.CompilerServices;

namespace Variables_and_Scopes
{
    //int x =10;Not Allowed.
    internal class Program
    {
        public string name = "Maher";
        //Class Level Scope.
        public static int Counter = 1;
        static void Main(string[] args)
        {
            //Console.WriteLine(name);Not allowed because you can't call a Non-static member inside a static method. 
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Program.Counter);
            PrintName();
            //Method Level Scope.
            int Z = 5;
            Console.WriteLine(Z);
            int Counter = 5;
            Console.WriteLine(Counter);//It will prints 5 because it is taking the closest variable to it. 
            Console.WriteLine(Program.Counter);//To call the membewr variable in which it is in a class level.
            //int y = 5;Not allowed because the y variable in the block level scope will get an error.
            //Block Level Scope.
            if(true)
            {
                int y = 5;
                Console.WriteLine(y);
            }
            //y = 6;Not allowed
            //int y = 5;Not allowed because the y variable in the block level scope will get an error.
            {
                int z = 5;
            }
            //z = 5; Not Allowed Because it is outside te context and the compiler doesn't know what is this.
        }
        static void PrintName()
        {
            Console.WriteLine(Counter);
        }
    }
}
