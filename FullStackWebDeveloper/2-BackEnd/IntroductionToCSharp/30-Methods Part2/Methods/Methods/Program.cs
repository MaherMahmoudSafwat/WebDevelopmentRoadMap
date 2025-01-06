namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3, 4, 5 };
            CalculateAverage1(Array1);
            Console.WriteLine($"The average of the array is {CalculateAverage2(Array1)}");
            PrintMessage();
            CalculateAverage3(Array1);
            //Named arguments allow you to specify the name of the parameter you are passing the value to.
            /*This is useful when you have a method with multiple parameters and you want to pass a value to a parameter
            that is not the first one.
            */
            //In the following example, we are passing the value of the PrintAverage parameter to the CalculateAverage4 method.
            //We are not passing the value of the PrintSum parameter.
            //The value of the PrintSum parameter will be the default value which is false.
            //The value of the PrintAverage parameter will be true.
            //The value of the PrintAverage parameter will be printed to the console.
            CalculateAverage4(Array1, PrintAverage:true);
            //Method Overloading
            CalculateAverage(Array1);


            PrintMessage2();
            PrintMessage2("Hello World!");

        }
        static void CalculateAverage1(int[] array)//method to calculate average of an array of integers and doesn't return anything (void).
        {
            int sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }
            double average = (double)sum / array.Length;
            Console.WriteLine(average);
        }
        static double CalculateAverage2(int[] array)//method to calculate average of an array of integers and return the average.
        {
            int sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }
            double average = (double)sum / array.Length;
            return average;
        }
        //The Following method is an example of a method that doesn't take any parameters and doesn't return anything.
        static void PrintMessage()
        {
            Console.WriteLine("Hello World!");
        }
        //The following method is an example of a method that takes an array of integers and a boolean parameter and returns the average of the array.
        //Default value of the boolean parameter is false and you dont need to provide and pass it when calling the method.
        static double CalculateAverage3(int[] array, bool PrintSum = false)
        {
            int sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }
            if (PrintSum)
            {
                Console.WriteLine($"The sum of the array is {sum}");
            }
            double average = sum / array.Length;
            return average;
        }
        //PrintAverage:true is an example of named arguments. 
        //Named arguments allow you to specify the name of the parameter you are passing the value to.
        static double CalculateAverage4(int[] array, bool PrintSum = false,bool PrintAverage = false)
        {
            int sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }
            if (PrintSum)
            {
                Console.WriteLine($"The sum of the array is {sum}");
            }
            double average = sum / array.Length;
            if (PrintAverage)
            {
                Console.WriteLine($"The average of the array is {average}");
            }
            return average;
        }
        //Method Overloading
        //Method overloading is a feature that allows a class to have more than one method having the same name,
        //if their argument lists are different.
        static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (var number in array)
            {
                sum += number;
            }
            double average = sum / array.Length;
            return average;
        }
        static double CalculateAverage(int number1, int number2)
        {
            return (number1 + number2) / 2;
        }
        //you can use return with void only if you want to exit the method early.
        static void PrintMessage2(string message = "")
        {
            if (message == string.Empty)
            {
                Console.WriteLine("The message is empty.");
                return;
            }
            Console.WriteLine(message);
        }
    }
}
