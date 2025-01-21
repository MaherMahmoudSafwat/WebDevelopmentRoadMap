import java.util.Scanner;

public class Main {
    static char PlayerChoice;
    static char [] Games = {'-','-','-','-','-','-','-','-','-'};
    static Scanner Input = new Scanner(System.in);
    static TicTacToe XO_Game;
    public static String UtilityMethod(int NumberOfTabs)
    {
        String Tabs = "";
        for(int i = 0; i < NumberOfTabs; i++)
        {
            Tabs += "\t";
        }
        return Tabs;
    }
    public static void main(String[] args)
    {
        System.out.println(UtilityMethod(9) + "Welcome to tic tac toe Game.");
        MainMenuChooseYourRule();
        int WhoStartFirst = (int)(Math.random()*2);
    }
    public static void MainMenuChooseYourRule()
    {
        System.out.print("Please enter your Rule X/O ? :- ");
        do
        {
            PlayerChoice = Input.next().charAt(0);
            XO_Game = new TicTacToe(PlayerChoice);
            if(!XO_Game.GetIsValidCharacter())
            {
                System.out.print("Invalid Choice Please choose your Rule X/O ? :- ");
            }
        }while(!XO_Game.GetIsValidCharacter());
        WhoStartsFirst();
    }
    public static void WhoStartsFirst()
    {
        int WhoStartFirst = (int)(Math.random()*2);
        if(WhoStartFirst==0)
        {
            ComputerStartsFirst();
        }
        else
        {
            PlayerStartsFirst();
        }
    }
    public static void DetermineWhoIsFinalWinner(char C)
    {
        if(C=='Z')
        {
            System.out.println("Game is Over and it is all Draw :-|.");
        }
        else if(C == PlayerChoice)
        {
            System.out.println("Congratulations you have won :-).");
        }
        else
        {
            System.out.println("Sorry you lost :-(.");
        }
    }
    public static void PlayerStartsFirst()
    {
        XO_Game.DrawGame(Games);
        int Index = 0;
        char Winner = 'Z';
        while(true)
        {
            System.out.println("Your Round");
            boolean IsValid = true;
            do
            {
                System.out.print("Please enter the index to fill your rule field X/O ? :-");
                Index = Input.nextInt();
                IsValid = IsValidIndex(Index);
                if(IsValid)
                {
                    System.out.println("your are not allowed to fill index here, it is already filled.");
                }
            }while(IsValid);
            XO_Game.PlayerRound(Games,Index);
            XO_Game.DrawGame(Games);
            Winner = XO_Game.WhoIsWinner(Games);
            if(Winner != 'Z')
                break;
            if(XO_Game.GetIsFull())
                break;
            System.out.println("Computer's Round");
            XO_Game.ComputerRound(Games);
            XO_Game.DrawGame(Games);
            Winner = XO_Game.WhoIsWinner(Games);
            if(Winner != 'Z')
                break;
            if(XO_Game.GetIsFull())
                break;
        }
        DetermineWhoIsFinalWinner(Winner);
    }
    public static void ComputerStartsFirst()
    {
        int Index = 0;
        char Winner = 'Z';
        while(true)
        {
            System.out.println("Computer's Round");
            XO_Game.ComputerRound(Games);
            XO_Game.DrawGame(Games);
            Winner = XO_Game.WhoIsWinner(Games);
            if(Winner != 'Z')
                break;
            if(XO_Game.GetIsFull())
                break;
            boolean IsValid = true;
            System.out.println("Your Round");
            do
            {
                System.out.print("Please enter the index to fill your rule field X/O ? :-");
                Index = Input.nextInt();
                IsValid = IsValidIndex(Index);
                if(IsValid)
                {
                    System.out.println("your are not allowed to fill index here, it is already filled.");
                }
            }while(IsValid);
            XO_Game.PlayerRound(Games,Index);
            XO_Game.DrawGame(Games);
            Winner = XO_Game.WhoIsWinner(Games);
            if(Winner != 'Z')
                break;
            if(XO_Game.GetIsFull())
                break;
        }
        DetermineWhoIsFinalWinner(Winner);
    }
    public static boolean IsValidIndex (int Index)
    {
        return Games[Index] != '-';
    }
}