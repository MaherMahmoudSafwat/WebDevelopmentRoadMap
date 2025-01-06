namespace Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comments are used to add explanations, notes, or annotations to your code without affecting its execution.
            //comments are not implemented by the compiler.
            //Single Comment can have only one line.
            int[] Numbers = { 1, 2, 3, 4, 5 };//Comment
            //Multi-Line Comment
            /*
             You can write in more than one line comment
            */

            // The todo: list is used to list the tasks you have to do you can get it from view ---> TaskList
            // todo: CalculateAverage
            CalculateAverage(Numbers);

        }
        /*
        XML documentation in C# is a way to create structured comments in your code that can generate external documentation files. 
        These comments provide detailed descriptions of methods, classes, properties, and more. They also enhance IntelliSense 
        in Visual Studio, showing helpful tooltips while coding.
        */
        //The following is XML Documentation:-
        //XML
        /// <summary>
        /// Calculate Average of numbers in array
        /// </summary>
        /// <param name="nums">The array the function it takes</param>
        static void CalculateAverage(int[] nums)
        {
            int Sum = 0;
            foreach(int num in nums)
            {
                Sum += num;
            }
            double Average = 0;
            Average = Sum / nums.Length;
            Console.WriteLine($"Average is {Average} ");
        }
    }
}
