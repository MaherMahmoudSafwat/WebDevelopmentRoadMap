namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Array Basics
            //Array is a collection of similar data types stored in a contiguous memory location.
            //Array is a reference type, so you need to use the new keyword to create an array.
            //The size of an array is fixed after it is created.
            //The length of an array is the total number of elements in the array.
            //The index of an array is a zero-based integer that represents the position of an element in the array.
            //The index of the first element is 0, and the index of the last element is Length - 1.
            //You can use the Length property to get the length of an array.
            int [] numbers = { 1, 4, 2, 3, 5 };
            numbers[0] = 10;
            Console.WriteLine($"numbers[0] :- {numbers[0]}");
            // int [5] numbers2 = {1, 2, 3, 4, 5 }; //This will not work
            // int numbers [5] = {1,2,3,4,5}; This will not work
            // int numbers [] = {1,2,3,4,5}; This will not work
            //----------------------------------------------
            //Array sort method sorts the elements of an array in ascending order.
            Array.Sort(numbers);
            Console.WriteLine($"numbers[0] after sorting the array is :- {numbers[0]}");
            //Array reverse method reverses the elements of an array.
            Array.Reverse(numbers);
            Console.WriteLine($"numbers[0] after reversing the array is :- {numbers[0]}");
            Console.WriteLine($"numbers[1] after reversing the array is :- {numbers[1]}");
            Console.WriteLine($"numbers[2] after reversing the array is :- {numbers[2]}");
            Console.WriteLine($"numbers[3] after reversing the array is :- {numbers[3]}");
            Console.WriteLine($"numbers[4] after reversing the array is :- {numbers[4]}");
            //----------------------------------------------

            int[] numbers2 = { };
            numbers2 = numbers;
            Console.WriteLine($"numbers2[0] after copying numbers 1 element in numbers 2 is {numbers2[0]}");
            Console.WriteLine($"numbers2[1] after copying numbers 1 element in numbers 2 is {numbers2[1]}");
            Console.WriteLine($"numbers2[2] after copying numbers 1 element in numbers 2 is {numbers2[2]}");
            Console.WriteLine($"numbers2[3] after copying numbers 1 element in numbers 2 is {numbers2[3]}");
            Console.WriteLine($"numbers2[4] after copying numbers 1 element in numbers 2 is {numbers2[4]}");
            //----------------------------------------------

            int[] numbers3 = { };
            //Array.Copy method copies the elements of one array to another array.
            //Array.Copy(numbers,numbers3,numbers.Length); //This will not work
            // Console.WriteLine($"numbers3[0] after copying numbers 1 element in numbers 3 is {numbers3[0]}"); //This will not work
            int[] numbers4 = new int[5]; // initialize the array with 5 elements with default value 0.
            //int[] numbers5 = new int[]; //This will not work as you need to specify the size of the array.
            Array.Copy(numbers, numbers4, numbers.Length);
            Console.WriteLine($"numbers4[0] after copying numbers 1 element in numbers 4 is {numbers4[0]}");
            Console.WriteLine($"numbers4[1] after copying numbers 1 element in numbers 4 is {numbers4[1]}");
            Console.WriteLine($"numbers4[2] after copying numbers 1 element in numbers 4 is {numbers4[2]}");
            Console.WriteLine($"numbers4[3] after copying numbers 1 element in numbers 4 is {numbers4[3]}");
            Console.WriteLine($"numbers4[4] after copying numbers 1 element in numbers 4 is {numbers4[4]}");
            //----------------------------------------------

            //Array.Clear method sets a range of elements in an array to zero.
            Array.Clear(numbers4,0, 1);
            Console.WriteLine($"numbers4[0] after clearing the array is {numbers4[0]}");
            Console.WriteLine($"numbers4[1] after clearing the array is {numbers4[1]}");

            int[] Array1 = new int[5];//initialize the array with 5 elements with default value 0.
            int[] Array2 = new int[5] { 1, 2, 3, 4, 5 };//initialize the array with 5 elements.

            //To get Length of an array use Length property.
            Console.WriteLine($"Length of Array1 is {Array1.Length}");
            //GetLength method is used to get the length of a specific dimension of an array.
            Console.WriteLine($"Length of Array2 is {Array2.GetLength(0)}");
            //Console.WriteLine($"Length of Array2 is {Array2.GetLength(1)}"); //This will not work as Array2 is a single dimension array.
        }
    }
}
