namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dry Principle - Don't Repeat Yourself
            //Methods are used to avoid repeating code in multiple places in the program.
            //Methods are used to organize code into logical blocks.
            //Methods are used to make code easier to read and understand.
            //Methods are used to make code easier to maintain.
            //Methods are used to make code reusable.
            int[] Arr1 = { 1, 2, 3, 4, 5 };
            //int Sum = 0;
            //foreach (int i in Arr1)
            //{
            //    Sum += i;
            //}
            //double Average = Sum / Arr1.Length;
            //Console.WriteLine($"Average is {Average}");
            CalculateAverage(Arr1);
            //You can change the size of the array and the code will still work.
            Arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CalculateAverage(Arr1);
            //Sum = 0;
            //foreach (int i in Arr1)
            //{
            //    Sum += i;
            //}
            //Average = Sum / Arr1.Length;
            //Console.WriteLine($"Average is {Average}");
            //This doesn't make any sense and doesn't follow the DRY principle.

        }
        static void CalculateAverage(int[] Arr)//Signature of the method.
        {
            int Sum = 0;
            foreach (int i in Arr)
            {
                Sum += i;
            }
            double Average = Sum / Arr.Length;
            Console.WriteLine($"Average is {Average}");
        }
    }
}
