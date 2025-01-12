import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        Scanner Input = new Scanner(System.in);
        int Number1=0, Number2=0;
        int Choice=1;
        do
        {
            if(Choice >= 1 && Choice <= 3)
            {
                System.out.println("Please enter two numbers");
                Number1 = Input.nextInt();
                Number2 = Input.nextInt();
            }
            System.out.println("Please Chose one of the following : ");
            System.out.println("1.Add the two numbers");
            System.out.println("2.Subtract the two numbers");
            System.out.println("3.Divide the two numbers");
            System.out.println("0.Exit");
            Choice=Input.nextInt();
            switch(Choice)
            {
                case 1 :
                    System.out.println("The addition of the two numbers is " + (Number1 + Number2));
                    break;
                case 2 :
                    System.out.println("The Subtraction of the two numbers is " + (Number1-Number2));
                    break;
                case 3 :
                    System.out.println("The Division of the two numbers is " + (Number1/Number2));
                    break;
                case 0:
                    System.out.println("GoodBye :-) !");
                    break;
                default:
                    System.out.println("Invalid Option Choice");
                    break;
            }
        }while(Choice != 0 );
    }
}