import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        String S1 = "Welcome to JAVa";
        //To make all strings to Lower.
        System.out.println(S1.toLowerCase());
        //To make all string to Upper.
        System.out.println(S1.toUpperCase());
        Scanner Input = new Scanner(System.in);
        //To read the first string only and ignore all the trailing and leading spaces.
        S1=Input.nextLine().trim();
        System.out.println(S1);
        //To replace a character with another in a string
        System.out.println(S1.replace('e','Y'));
        //To replace the first Character only.
        System.out.println(S1.replaceFirst("a","o"));
        //To replace all Strings.
        System.out.println(S1.replaceAll("C# and C++","Java"));
        //To print an index of a character in a string
        System.out.println(S1.indexOf('e'));
        //To print an index of the last index.
        System.out.println(S1.lastIndexOf('e'));
        //To concatenate a string with another string
        System.out.println(S1.concat("Welcome"));
        //To compare two strings
        /*
        0: If the strings are equal (ignoring case).
        A negative integer: If the current string (the one you are calling compareToIgnoreCase() on) is lexicographically less than the other string (ignoring case).
        A positive integer: If the current string is lexicographically greater than the other string (ignoring case).
        */
        System.out.println(S1.compareToIgnoreCase("Ahmed"));
    }
}