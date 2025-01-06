namespace ArrayFindings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise
            Console.WriteLine("Enter the size of the array :- ");
            int ArraySize = int.Parse(Console.ReadLine());
            int[] Array1 = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine($"Please enter element {i + 1}");
                Array1[i] = int.Parse(Console.ReadLine());
            }
            PrintMin_MaX_AverageOfTheArray(Array1);
        }
        /// <summary>
        /// Print Minimum , Maximum and Average of the array
        /// </summary>
        /// <param name="array">Enter the array </param>
        static void PrintMin_MaX_AverageOfTheArray(int[] array)
        {
            int Sum = 0, Min = int.MaxValue, Max = 0;
            foreach(int i in array)
            {
                if (Min > i)
                    Min = i;
                if(Max < i)
                    Max = i;
                Sum += i;
            }
            double Average = 0;
            Average = Sum / array.Length;
            Console.WriteLine($"Minmum element in array is {Min}");
            Console.WriteLine("Maximum element in array is " + Max);
            Console.WriteLine($"Average element in array is {Average}");
        }
    }
}
