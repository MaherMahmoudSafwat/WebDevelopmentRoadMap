import javax.swing.plaf.basic.BasicInternalFrameTitlePane;
import java.util.Scanner;

public class Main {
    static Scanner Input = new Scanner(System.in);
    public static String NumberOfTabs(int N1)
    {
        String Tabs = "";
        for(int i = 0; i<N1; i++)
        {
            Tabs+="\t";
        }
        return Tabs;
    }
    public static void main(String[] args)
    {
        System.out.println(NumberOfTabs(15) + "Welcome to hangman game.");
        String GuessA_Word = GameWords(((int)(Math.random()*10))+1);
        HangManGame(GuessA_Word);
    }
    public static boolean IsWordInString(String GuessA_Word,char C)
    {
        for(int i = 0; i<GuessA_Word.length(); i++)
        {
            if(C==GuessA_Word.charAt(i))
                return true;
        }
        return false;
    }
    public static String GameWords(int WordOfIndex)
    {
        String [] ArrayOfWords =
                {
                "banana","elephant","laptop","programming","cat","mouse","lion","vegetable","potato","strawberry","friends"
                };
        return ArrayOfWords[WordOfIndex];
    }
    public static String GameGuessWord(String GuessA_Word)
    {
        int Syntax = ((int)(Math.random()*((GuessA_Word.length()-1)+1)));
        String Word = "";
        for(int i = 0; i<GuessA_Word.length(); i++)
        {
            if(i==Syntax)
            {
                Word+=GuessA_Word.charAt(Syntax);
                continue;
            }
            Word+="_";
        }
        return Word;
    }
    public static String GameGuessWord(String GuessA_Word,String CompleteWord, char Word)
    {
        String NewWord="";
        for(int i = 0; i<GuessA_Word.length(); i++)
        {
            if(Word==GuessA_Word.charAt(i))
            {
                NewWord+=Word;
                continue;
            }
            NewWord+=CompleteWord.charAt(i);
        }
        return NewWord;
    }
    public static void DrawHangManGame(int Counter)
    {
        if(Counter==1)
        {
            System.out.println(" 0 ");
        }
        else if (Counter==2)
        {
            System.out.println(" 0");
            System.out.println("/");
        }
        else if(Counter==3)
        {
            System.out.println("  0 ");
            System.out.println("/ | \\");
        }
        else if (Counter==4)
        {
            System.out.println("  0 ");
            System.out.println("/ | \\");
            System.out.println(" /");
        }
        else if (Counter==5)
        {
            System.out.println("  0 ");
            System.out.println("/ | \\");
            System.out.println(" / \\");
        }
        else if (Counter == 6)
        {
            System.out.println(" | ");
            System.out.println(" | ");
            System.out.println(" | ");
            System.out.println(" |______0");
            System.out.println("      / | \\");
            System.out.println("       / \\");
        }
    }
    public static void HangManGame(String GuessA_Word)
    {
        String CompleteWord = GameGuessWord(GuessA_Word);
        char Word;
        int Count = 0;
        while(Count < 6 )
        {
            System.out.println(CompleteWord);
            System.out.println("Guess the Word");
            Word = Input.nextLine().charAt(0);
            if(!IsWordInString(GuessA_Word,Word))
            {
                System.out.println("Wrong Word :-(");
                Count++;
                DrawHangManGame(Count);
                continue;
            }
            CompleteWord = GameGuessWord(GuessA_Word,CompleteWord,Word);
            if(GuessA_Word.equals(CompleteWord))
            {
                System.out.println(GuessA_Word);
                break;
            }
        }
        if(Count==6)
            System.out.println("Sorry, you Lost :-( !");
        else
            System.out.println("Congratulations, you Won :-) !");
    }
}