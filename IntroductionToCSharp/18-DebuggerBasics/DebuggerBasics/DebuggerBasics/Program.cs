namespace DebuggerBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Debugger Basics
            /*Debugger is a tool that allows you to pause the execution of your program and inspect the values of variables.
            It is very useful when you have a bug in your code and you want to understand what's going on.*/
            //Step by step execution of code using the debugger is called Debugging.
            //Breakpoints are used to pause the execution of your program at a specific line of code.
            /*To use the Breakpoint feature, you can click on the left margin of the code editor next to the line of code 
             *where you want to pause the execution of your program.
             *or you can press F9 to toggle a breakpoint on the current line of code.
             *or you can right click on code and select Breakpoint -> Insert Breakpoint.
             *or you can press Ctrl+F9 to remove all breakpoints from the current file.
             *or you can press Ctrl+Shift+F9 to remove all breakpoints from the solution.
            */
            //Local Windows shows the values of variables in the current scope.
            //To get local Windows , go to Debug -> Windows -> Locals.
            //Watches and Add Watch are used to monitor the value of a specific variable or expression.
            //To add Watch, right click on the variable or expression and select Add Watch.
            //To get Watch Windows, go to Debug -> Windows -> Watch -> Watch 1.
            //Edit and Continue is a feature that allows you to change your code while debugging.
            //Edit and continue helps you to fix bugs quickly and efficiently.
            //To enable Edit and Continue, go to Tools -> Options -> Debugging -> General -> Enable Edit and Continue.
            Console.WriteLine("Please enter a number: ");
            var input = int.Parse(Console.ReadLine());
            int Reminder = input % 2;
            if (Reminder != 0)
            {
                Console.WriteLine("The number is odd");
            }
            else if(input == 0)
            {
                Console.WriteLine("The number is neither even nor odd");
            }
            else
            {
                Console.WriteLine("The number is even");
            }
        }
    }
}
