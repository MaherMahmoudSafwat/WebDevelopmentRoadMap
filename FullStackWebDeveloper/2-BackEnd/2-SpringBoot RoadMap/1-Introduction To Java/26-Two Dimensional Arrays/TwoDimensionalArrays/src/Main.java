import java.security.PublicKey;
import java.util.Scanner;

public class Main {
    static Scanner Input = new Scanner(System.in);
    public static void main(String[] args)
    {
        /*//Two Dimensional Array
        int [][] Table1 = new int [2][3];
        int [][] Table2 =
                {
                //Column1 , Column2 , Column3
                {1,2,3},//Row 1
                {4,5,6} //Row 2
                };
        System.out.println(Table1.length);//To print the length of two dimensional array
        System.out.println(Table1[0].length);//To print the length of elements inside the array.
        FillAnArray(Table1);
        PrintAnArray(Table1);
        int Sum = PrintTheSumOfAnElementsOfAnArray(Table1);
        System.out.println("The Sum of the elements inside the array is " + Sum);
        int [][][] Table3 = new int [2][2][2];//Three Dimensional Array
        Table3 = new int [][][]
                {
                        {
                                {1,2},
                                {3,4}
                        }
                        ,
                        {
                                {5,6},
                                {7,8}
                        }
                }; // Array of Size Three Dimensions.*/



        //------------------------------------------
        int [][] JaggedArray1 = new int[2][];//Jagged Array
        JaggedArray1[0] = new int[2];
        JaggedArray1[1] = new int[3];
        int [][][] JaggedArray2 = new int[3][][];//Multi-Dimensional Jagged Array.
        //Access The Index Elements of a Jagged Array
        JaggedArray1[0][0] = 1;//Access an Index of a jagged Array
        JaggedArray1[0][1] = 2;
        JaggedArray1[1][0] = 3;
        JaggedArray1[1][1] = 4;
        JaggedArray1[1][2] = 5;
        PrintJaggedArray(JaggedArray1);
    }
    public static void FillAnArray(int [][] Lists)
    {
        for(int i = 0; i < Lists.length; i++)
        {
            for(int j = 0; j < Lists[i].length; j++)
            {
                System.out.println("Please enter the number in the row " + (i+1) + " and column " + (j+1));
                Lists[i][j] = Input.nextInt();
            }
        }
    }
    public static void PrintAnArray(int [][] Lists)
    {
        for (int i = 0; i < Lists.length; i++)
        {
            for (int j = 0 ;j < Lists[i].length; j++)
            {
                System.out.print(Lists[i][j] + " ");
            }
            System.out.println();
        }
    }
    public static int PrintTheSumOfAnElementsOfAnArray(int [][] Lists)
    {
        int Sum = 0;
        for (int i = 0; i < Lists.length; i++) {
            for (int j = 0; j < Lists[i].length; j++) {
                Sum += Lists[i][j];
            }
        }
        return Sum;
    }
    public  static void PrintJaggedArray(int [][] Lists)
    {
        for(int i = 0 ;i < Lists.length; i++)
        {
            for (int j = 0; j < Lists[i].length; j++)
            {
                System.out.print(Lists[i][j] + " ");
            }
            System.out.println();
        }
    }
}