namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1D array
            int[] arr1 = new int[3] { 1, 2, 3 };
            // 2D array
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6} };
            // 3D array
            int[,,] arr3 = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            //1D Jagged Array 
            // Jagged array is an array of arrays where each element is an array itself.
            // Jagged array can be of any dimensions.
            // Jagged array can have different number of elements in each row and column and array.
            int[][] Numbers1 = new int [3][];
            Numbers1[0] = new int[2] { 1, 2 };
            Numbers1[1] = new int[1] { 3,};
            Numbers1[2] = new int[3] { 6, 7, 8};
            // Jagged array can be initialized as follows
            int[][] Numbers2 = new int[3][]
            {
                new int[2] { 1, 2 },
                new int[1] { 3 },
                new int[3] { 6, 7, 8 }
            };
            //int[][] Numbers3 = new int[3][] { { 1, 2 }, { 3 }, { 4, 5, 6 } }; Not allowed in C# 7.0 and later versions of C#. 
            //Accessing elements of jagged array
            Console.WriteLine($"Numbers1[0][0] is :- {Numbers1[0][0]}"); // Output: 1
            Numbers1[0][0] = 4;// Modifying element of jagged array
            Console.WriteLine($"Numbers1[0][0] After Modification is :- {Numbers1[0][0]}"); // Output: 4

            // Iterating through jagged array
            for (int i=0;i < Numbers1.Length; i++)
            {
                for (int j = 0; j < Numbers1[i].Length; j++)
                {
                    Console.WriteLine($"Numbers1[{i}][{j}] is :- {Numbers1[i][j]}");
                }
            }



            // Jagged Multidimensional Array
            // Jagged Multidimensional Array is an array of arrays where each element is an array itself.
            // Jagged Multidimensional Array can be of any dimensions.
            // Jagged Multidimensional Array can have different number of elements in each row and column and array.
            int[][,] Numbers3 = new int[2][,];
            Numbers3[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Numbers3[1] = new int[1, 3] { { 5, 6, 7 } };
            // Jagged Multidimensional Array can be initialized as follows
            int[][,] Numbers4 = new int[2][,]
            {
                new int[2, 2] { { 1, 2 }, { 3, 4 } },
                new int[1, 3] { { 5, 6, 7 } }
            };
            //Accessing elements of jagged multidimensional array
            Console.WriteLine($"Numbers3[0][0,0] is :- {Numbers3[0][0, 0]}"); // Output: 1
            Numbers3[0][0, 0] = 4;// Modifying element of jagged multidimensional array
            Console.WriteLine($"Numbers3[0][0,0] After Modification is :- {Numbers3[0][0, 0]}"); // Output: 4
            // Iterating through jagged multidimensional array
            for (int i = 0; i < Numbers3.Length; i++)
            {
                for (int j = 0; j < Numbers3[i].GetLength(0); j++)
                {
                    for (int k = 0; k < Numbers3[i].GetLength(1); k++)
                    {
                        Console.WriteLine($"Numbers3[{i}][{j},{k}] is :- {Numbers3[i][j, k]}");
                    }
                }
            }

        }
    }
}
