namespace ForAndForeachTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create application to reverse Dynamic Array
            Console.WriteLine("Enter the size of the array: ");
            int ArraySize = int.Parse(Console.ReadLine());
            int[] Numbers1 = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine($"Enter the number {i + 1}: ");
                Numbers1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine($"Number {i + 1}: {Numbers1[i]}");
            }
            Console.WriteLine("Reversed Array is : ");
            int[] ReversedArray = new int[ArraySize];
            for (int i = ArraySize - 1; i >= 0; i--)
            {
                ReversedArray[ArraySize - i - 1] = Numbers1[i];
            }
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine($"Reversed Number {i + 1}: {ReversedArray[i]}");
            }
            ////Create Application to calculate average of Dynamic Array
            Console.WriteLine("Enter the size of the array: ");
            int ArraySize2 = int.Parse(Console.ReadLine());
            int[] Numbers2 = new int[ArraySize2];
            for (int i = 0; i < ArraySize2; i++)
            {
                Console.WriteLine($"Enter the number {i + 1}: ");
                Numbers2[i] = int.Parse(Console.ReadLine());
            }
            int Sum = 0;
            foreach(int numbers in Numbers2)
            {
                Sum += numbers;
            }
            double Average = Sum / ArraySize2;
            Console.WriteLine($"Average of the array is: {Average}");
        }
    }
}
