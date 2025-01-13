import java.util.Scanner;

public class Main {
    static Scanner Input = new Scanner(System.in);
    public static void main(String[] args)
    {
        System.out.println("Please enter the Size of the array.");
        int Size = Input.nextInt();
        int [] Lists = new int [Size];
        FillAnArrayList(Lists);
        PrintArrayList(Lists);
        int IsFound = -1;
        System.out.println("Please enter the target you want to search for it.");
        int Target = Input.nextInt();
        IsFound = SearchForAnTarget(Lists,Target);
        if(IsFound >= 0)
        {
            System.out.println("The element target is found at index " + IsFound);
        }
        else
        {
            System.out.println("The element target is not found. ");
        }
    }
    public static void FillAnArrayList(int [] List)
    {
        for(int i = 0; i < List.length; i++)
        {
            System.out.println("Please enter the Element Number no. " + (i+1));
            List[i] = Input.nextInt();
        }
    }
    public static void PrintArrayList(int [] Lists)
    {
        for(int i = 0; i < Lists.length; i++)
        {
            System.out.println(Lists[i]);
        }
    }
    public static int SearchForAnTarget(int [] Lists, int Target)
    {
        for(int i = 0; i < Lists.length; i++)
        {
            if(Lists[i] == Target)
                return i;
        }
        return -1;
    }
}