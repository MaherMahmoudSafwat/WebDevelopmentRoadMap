import javax.swing.plaf.basic.BasicInternalFrameTitlePane;
import java.util.Scanner;

public class Main {
    public static String GetNewWord(String s, int Index)
    {
        String NewWord="";
        if(Index==0)
        {
            NewWord += Character.toUpperCase(s.charAt(Index));
            return NewWord;
        }
        else
        {
            for(int i=0; i<=Index; i++)
            {
                if(i==0)
                {
                    NewWord += Character.toUpperCase(s.charAt(Index));
                    continue;
                }
                NewWord+=Character.toLowerCase(s.charAt(Index));
            }
        }
        return NewWord;
    }
    public static String accum(String s)
    {
        String NewWord = "";
        for(int i = 0; i<s.length(); i++)
        {
            if(i==(s.length()-1))
            {
                NewWord+=GetNewWord(s,i);
                continue;
            }
            else
            {
                NewWord+=GetNewWord(s,i);
                NewWord+='-';
            }
        }
        return NewWord;
    }
    public static void main(String[] args)
    {
        System.out.println(accum("cwAt"));
    }
}