namespace ControlFlow_IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement is used to execute a block of code if a specified condition is true
            Console.WriteLine("Please enter a number: ");
            int Number = int.Parse(Console.ReadLine());
            int Reminder = Number % 2;
            if (Reminder == 1)
            {
                Console.WriteLine("The number is odd");
            }
            else if (Number == 0)
            {
                Console.WriteLine("The number is neither even nor odd");
            }
            else
            {
                Console.WriteLine("The number is even");
            }
            //you can have if only without else
            //but you can't have else without if
            /*The first control statement conditon is true, the code block will be executed, 
              and the rest of the control statements will be skipped*/
        }
    }
}
