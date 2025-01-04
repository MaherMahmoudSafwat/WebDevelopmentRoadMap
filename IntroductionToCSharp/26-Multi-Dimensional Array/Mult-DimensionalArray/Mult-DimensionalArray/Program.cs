namespace Multi_DimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MultiDimensionalArray is an array of arrays.
            // It is used to store data in a tabular format.
            // It is also known as a matrix.
            // It is a collection of rows and columns.
            // It is a rectangular array.
            // It is a collection of one-dimensional arrays.
            // It is a collection of n-dimensional arrays.
            //2D array declaration
            int[,] Array1 = { { 1, 2, 3, }, { 4, 5, 6 } };//2D array First Method
            int[,] Array2 = new int[2, 3];//2D array Second Method
            int[,] Array3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };//2D array Third Method
            int[,] Array4 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };//2D array Fourth Method
            //2D array elements are accessed using the row and column index.
            int[,] Array5 = new int[2, 3]
                {
                    {1, 2, 3 },//Row 0
                    {4, 5, 6 }//Row 1
                    //Column 0 1 4
                    //Column 1 2 5
                    //Column 2 3 6
                };
            //Accessing 2D array elements
            Console.WriteLine($"Array[0,0]:- {Array1[0, 0]}");//Output: 1
            Console.WriteLine($"Array[0,1]:- {Array1[0, 1]}");//Output: 2
            Console.WriteLine($"Array[0,2]:- {Array1[0, 2]}");//Output: 3
            Console.WriteLine($"Array[1,0]:- {Array1[1, 0]}");//Output: 4
            Console.WriteLine($"Array[1,1]:- {Array1[1, 1]}");//Output: 5
            Console.WriteLine($"Array[1,2]:- {Array1[1, 2]}");//Output: 6
            //Modifying 2D array elements
            Array1[0, 0] = 10;//I can access and modify the value of the 2D array element directly.
            Console.WriteLine($"Array[0,0] After Modification:- {Array1[0, 0]}");//Output: 10
            //Iterating 2D array elements
            //GetLLength() method is used to get the length of the specified dimension of the array.
            for (int i = 0; i < Array1.GetLength(0); i++)//GetLength(0) is used to get the length of the first dimension of the array.
            {
                Console.WriteLine($"Row {i}");
                for (int j = 0; j < Array1.GetLength(1); j++)//GetLength(1) is used to get the length of the second dimension of the array.
                {
                    Console.Write($"Array[{i},{j}]:- {Array1[i, j]} ");
                }
                Console.WriteLine();
            }
            //Array.Length property is used to get the total number of elements in all dimensions of the array.
            Console.WriteLine($"The total number of elements in the 2D array:- {Array1.Length}");//Output: 6
            //Array.Rank property is used to get the number of dimensions in the array.
            Console.WriteLine($"The Total number of dimensions in the 2D array:- {Array1.Rank}");//Output: 2
            //Array.GetLength() method is used to get the length of the specified dimension of the array.
            Console.WriteLine($"The Total number of rows in the 2D array:- {Array1.GetLength(0)}");//Output: 2
            Console.WriteLine($"The Total number of columns in the 2D array:- {Array1.GetLength(1)}");//Output: 3


            //3D array declaration
            int[,,] Array6 = new int[3, 3, 3]
            { 
                {   {1, 2, 3 }, 
                    {4, 5, 6}, 
                    { 7, 8, 9} 
                }, 
                { 
                    {10, 11, 12 }, 
                    {13, 14, 15 }, 
                    {16, 17, 18 } 
                }
                , 
                { 
                    {19, 20, 21 }, 
                    {22, 23, 24 }, 
                    {25, 26, 27 } 
                } 
            };
            //Accessing 3D array elements
            Console.WriteLine($"Array[0,0,0]:- {Array6[0, 0, 0]}");//Output: 1
            Console.WriteLine($"Array[0,0,1]:- {Array6[0, 0, 1]}");//Output: 2
            Console.WriteLine($"Array[0,0,2]:- {Array6[0, 0, 2]}");//Output: 3
            Console.WriteLine($"Array[0,1,0]:- {Array6[0, 1, 0]}");//Output: 4
            Console.WriteLine($"Array[0,1,1]:- {Array6[0, 1, 1]}");//Output: 5
            Console.WriteLine($"Array[0,1,2]:- {Array6[0, 1, 2]}");//Output: 6
            Console.WriteLine($"Array[0,2,0]:- {Array6[0, 2, 0]}");//Output: 7
            Console.WriteLine($"Array[0,2,1]:- {Array6[0, 2, 1]}");//Output: 8
            Console.WriteLine($"Array[0,2,2]:- {Array6[0, 2, 2]}");//Output: 9
            Console.WriteLine($"Array[1,0,0]:- {Array6[1, 0, 0]}");//Output: 10
            Console.WriteLine($"Array[1,0,1]:- {Array6[1, 0, 1]}");//Output: 11
            Console.WriteLine($"Array[1,0,2]:- {Array6[1, 0, 2]}");//Output: 12
            Console.WriteLine($"Array[1,1,0]:- {Array6[1, 1, 0]}");//Output: 13
            Console.WriteLine($"Array[1,1,1]:- {Array6[1, 1, 1]}");//Output: 14
            Console.WriteLine($"Array[1,1,2]:- {Array6[1, 1, 2]}");//Output: 15
            Console.WriteLine($"Array[1,2,0]:- {Array6[1, 2, 0]}");//Output: 16
            Console.WriteLine($"Array[1,2,1]:- {Array6[1, 2, 1]}");//Output: 17
            Console.WriteLine($"Array[1,2,2]:- {Array6[1, 2, 2]}");//Output: 18
            Console.WriteLine($"Array[2,0,0]:- {Array6[2, 0, 0]}");//Output: 19
            Console.WriteLine($"Array[2,0,1]:- {Array6[2, 0, 1]}");//Output: 20
            Console.WriteLine($"Array[2,0,2]:- {Array6[2, 0, 2]}");//Output: 21
            Console.WriteLine($"Array[2,1,0]:- {Array6[2, 1, 0]}");//Output: 22
            Console.WriteLine($"Array[2,1,1]:- {Array6[2, 1, 1]}");//Output: 23
            Console.WriteLine($"Array[2,1,2]:- {Array6[2, 1, 2]}");//Output: 24
            Console.WriteLine($"Array[2,2,0]:- {Array6[2, 2, 0]}");//Output: 25
            Console.WriteLine($"Array[2,2,1]:- {Array6[2, 2, 1]}");//Output: 26
            Console.WriteLine($"Array[2,2,2]:- {Array6[2, 2, 2]}");//Output: 27
            //Modifying 3D array elements
            Array6[0, 0, 0] = 100;//I can access and modify the value of the 3D array element directly.
            Console.WriteLine($"Array[0,0,0] After Modification:- {Array6[0, 0, 0]}");//Output: 100
            //Iterating 3D array elements
            for (int i = 0; i < Array6.GetLength(0); i++)//GetLength(0) is used to get the length of the first dimension of the array.
            {
                Console.WriteLine($"Dimension {i}");
                for (int j = 0; j < Array6.GetLength(1); j++)//GetLength(1) is used to get the length of the second dimension of the array.
                {
                    Console.WriteLine($"Row {j}");
                    for (int k = 0; k < Array6.GetLength(2); k++)//GetLength(2) is used to get the length of the third dimension of the array.
                    {
                        Console.Write($"Array[{i},{j},{k}]:- {Array6[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            //Array.Length property is used to get the total number of elements in all dimensions of the array.
            Console.WriteLine($"The total number of elements in the 3D array:- {Array6.Length}");//Output: 27
            //Array.Rank property is used to get the number of dimensions in the array.
            Console.WriteLine($"The Total number of dimensions in the 3D array:- {Array6.Rank}");//Output: 3
            //Array.GetLength() method is used to get the length of the specified dimension of the array.
            Console.WriteLine($"The Total number of dimensions in the 3D array:- {Array6.GetLength(0)}");//Output: 3
            Console.WriteLine($"The Total number of rows in the 3D array:- {Array6.GetLength(1)}");//Output: 3
            Console.WriteLine($"The Total number of columns in the 3D array:- {Array6.GetLength(2)}");//Output: 3

        }
    }
}
