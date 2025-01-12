import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        Scanner Input = new Scanner(System.in);
        System.out.println("Please enter grades of students to print it is average or press -1 to exit");
        int Grade = 0, Sum=0, Counter = 0;
        float Average = 0f;
        while(Counter < 6 && Grade != -1)
        {
            System.out.printf("Please enter the grade of student no.%d \n",Counter+1);
            Grade = Input.nextInt();
            if(Grade != -1)
                Sum+=Grade;
            Counter++;
        }
        if(Grade == -1)
        {
            Counter--;
        }
        Average = (float)Sum/(float)Counter;
        System.out.printf("The Average Grades of the %d Students you have entered is %f",Counter,Average);
    }
}
