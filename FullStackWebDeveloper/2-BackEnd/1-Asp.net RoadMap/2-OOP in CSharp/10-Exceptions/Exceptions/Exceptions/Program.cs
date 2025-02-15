namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.WriteLine("Hello, World!");Compile time error Runtime.
            //All Exceptions in C# inherits from a class called Exception. 
            //The try can has one or more catch but it must has a catch or finally or both of them.
            try
            {
                int x = int.Parse("Test Error Code");
                Console.WriteLine(Divide(10, 2));
                Console.WriteLine(Divide(5, 0));
                Console.WriteLine(Divide(15, 3));
            }
            //The catch statement is where it handles the Exception error.
            catch (DivideByZeroException ex)//Paramerters of catch are optionally you can have a catch without Parameters but it must be at the end.
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.HelpLink);
            }
            catch
            {
                Console.WriteLine("Catch Error Exception");
            }
            //The finally block is an optional block that will be exceuted whether the try is executed or catch is executed. 
            finally
            {
                Console.WriteLine("This is a finally block");
            }
            Console.WriteLine("Hello C#.");


            Console.WriteLine("Please enter a five string character.");
            string z = Console.ReadLine();
            if(z.Length < 5)
            {
                throw new Exception("Length must be greater than five characters.");
            }
        }
        static int Divide(int Number1, int Divisor) 
        {
            return Number1 / Divisor;
        }
    }
}
