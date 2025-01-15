import java.math.BigDecimal;
import java.math.BigInteger;
import java.util.Scanner;
import java.lang.*;
public class Main {
    public static String Convert(String str)
    {
        StringBuffer sb = new StringBuffer(str);
        for(int i = 0; i <sb.length(); i++)
        {
            if(sb.charAt(i) < 48 || sb.charAt(i) > 57)
            {
                sb.deleteCharAt(i);
                i--;
            }
        }
        return sb.toString();
    }
    public static void main(String[] args) {
        Scanner Input = new Scanner(System.in);
        //! Logical Operator turns True to False and Turn False to True
        boolean X = false;
        System.out.println(!X);
        int x = 3;
        short y = 5;
        byte z = 126;
        //To know the size of a Primitive Data Type use the following.
        System.out.println("The Size of Integers is " + Integer.SIZE);
        System.out.println("The Size of Bytes is " + Byte.SIZE);
        System.out.println("The Size of Shorts is " + Short.SIZE);
        System.out.println("The Size of Longs is " + Long.SIZE);
        System.out.println("The Size of Chars is " + Character.SIZE);
        System.out.println("The Size of Floats is " + Float.SIZE);
        System.out.println("The Size of Doubles is " + Double.SIZE);
        BigInteger Y = new BigInteger("535465768798546354657687984635466879807687980");//Takes a big Numbers
        BigDecimal Z = new BigDecimal("987545345466879878463546767984657687980978576879780");//Takes a big Numbers of Decimals
        System.out.println(Y);
        System.out.println(Z);
        System.out.println(Y.add(BigInteger.valueOf(9)));//Value of is used to convert any Data Type to big integer.

        //To determine the range every primitive data type can handle use  DataType.MIN_Value and DataType.MAX_Value.
        System.out.println("The Minimum Size of Byte is " + Byte.MIN_VALUE + " and Maximum Size is " + Byte.MAX_VALUE);
        System.out.println("The Minimum Size of Short is " + Short.MIN_VALUE + " and Maximum Size is " + Short.MAX_VALUE);
        System.out.println("The Minimum Size of Integer is " + Integer.MIN_VALUE + " and Maximum Size is " + Integer.MAX_VALUE);
        System.out.println("The Minimum Size of Long is " + Long.MIN_VALUE + " and Maximum Size is " + Long.MAX_VALUE);
        System.out.println("The Minimum Size of Character is " + Character.MIN_VALUE + " and Maximum Size is " + Character.MAX_VALUE);
        System.out.println("The Minimum Size of Float is " + Float.MIN_VALUE + " and Maximum Size is " + Float.MAX_VALUE);
        System.out.println("The Minimum Size of Double is " + Double.MIN_VALUE + " and Maximum Size is " + Double.MAX_VALUE);

        //------------------------------------------------------------------------------------------------------------------------

        char C = 'C';
        System.out.println(Character.toUpperCase(C));
        System.out.println(Character.isDigit(C));
        System.out.println(Character.isLetter(C));
        System.out.println(Character.toLowerCase(C));
        System.out.println(Character.isWhitespace(C));


        //========================================================================================================================
        //String is an array of Characters.
        String Team1 = "ABCDE";
        //To Take Input String From User.
        Team1 = Input.nextLine();
        System.out.println(Team1);
        //Concatenation
        String Team2 = "Java";
        String Team3 = Team1 + Team2;
        System.out.println(Team3);
        //To Know and Print the LLength of an String
        System.out.println(Team3.length());
        //Convert all a string into an upper case
        Team3 = Team3.toUpperCase();
        System.out.println(Team3);

        int A = 50;
        //To Convert From Any Data Type to an String
        Team3 = String.valueOf(A);
        System.out.println(Team3);

        //To Convert From String To Integer or Any other DataType
        A = Integer.valueOf(Team3);
        System.out.println(A);

        //Any Conversion from Data Type t o Another you can use DataType You want To Convert To DataType.ValueOf(DataType you want to convert).

        //To Access An Index Element in an a string.
        System.out.println(Team3.charAt(0));

        Team3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //To used reserved keyword to reserve a string use the StringBuffer Class inside Java.
        StringBuffer SB = new StringBuffer(Team3);
        System.out.println(SB.reverse());

        //Spilt Functions in the Strings.
        String Names = "Ahmed,Maher,Omar,Ahmed,Ahmed";
        String[] NamesArray = Names.split(",");
        //Ranged Loop
        for (String Name : NamesArray) {
            System.out.println(Name);
        }
        //To join array into a single one string.
        Names = String.join(",", NamesArray);
        System.out.println(Names);

        // String is Immutable means you can't modify a String once it is created
        String Str1 = "Navin";  // The string literal "Navin" is stored in the String pool, and Str points to it
        // The String is a reference type, where the variable name is a reference (or pointer) to the memory address
        // The actual value ("Navin") is stored in the String pool or heap depending on the JVM implementation
        System.out.println(Str1);

        Str1 = "Maher";  // Now, Str points to the new string literal "Maher", which is stored in the String pool
        // "Navin" is still in the String pool, but Str now points to "Maher"
        // Since Strings are immutable, a new object is created when you assign a new value to Str
        System.out.println(Str1);

        // In this case, "Navin" is still in the String pool but no variable points to it anymore
        // If no other references exist, the "Navin" string could eventually be garbage collected (if it's not used elsewhere)

        String Str2 = Str1;// A string literal "Maher" is stored in the String pool, and Str1 points to it
        // Str2 now references the same string object as Str1 (i.e., "Maher")
        System.out.println(Str2);

        // At this point, both Str1 and Str2 point to the same object in the String pool
        // No new String object is created. Str2 simply references the same object that Str1 points to

        // Both Str1 and Str2 point to the same "Maher" object, which is in the String pool
        // No duplication of the "Maher" str

        String Str3 = new String("Maher");  // Creates a new String object "Maher" in the heap memory
        // Even though "Maher" is a string literal, this statement creates a new String object in memory
        // It does NOT reference the string in the String pool directly, but instead, creates a new object in the heap

        // This new String object "Maher" is distinct from the string in the String pool (if it exists)
        // The reference Str3 now points to this new String object in the heap, not the one in the String pool

        // If "Maher" is already in the String pool, this will still create a new object in the heap
        // and it is different from the one in the String pool, even though the values are identical

        StringBuffer S = new StringBuffer("h");
        // StringBuffer vs StringBuilder

        // 1. StringBuffer:
        // - StringBuffer is a mutable sequence of characters. It allows modifying the string without creating new objects.
        // - StringBuffer is **synchronized**, meaning it is thread-safe and can be used in a multi-threaded environment.
        // - Since it's synchronized, it tends to be **slower** than StringBuilder when performance is a concern in single-threaded applications.

        // Example of StringBuffer:
        StringBuffer sb1 = new StringBuffer("Hello");
        sb1.append(" World");  // Modifies the original object and appends to it.

        // 2. StringBuilder:
        // - StringBuilder is also a mutable sequence of characters, similar to StringBuffer, and it allows efficient string manipulation.
        // - StringBuilder is **not synchronized**, making it **faster** than StringBuffer for single-threaded applications where thread-safety is not a concern.
        // - It should be used when thread-safety is not required, as it provides better performance in most cases.

        // Example of StringBuilder:
        StringBuilder sb2 = new StringBuilder("Hello");
        sb2.append(" World");  // Modifies the original object and appends to it.

        // Key Differences:
        // - **Thread-Safety**: StringBuffer is thread-safe (synchronized), while StringBuilder is not thread-safe.
        // - **Performance**: StringBuilder is faster than StringBuffer in scenarios where thread safety is not needed.
        // - **Use Cases**: Use StringBuffer when thread safety is required (e.g., multi-threaded applications) and use StringBuilder when thread safety is not needed (e.g., single-threaded applications or performance-critical code).

        // In summary:
        // - Use StringBuffer if you need a thread-safe, mutable string buffer.
        // - Use StringBuilder if you do not need synchronization and want better performance.

        //Pattern Checking Using Built-in Function.
        String S1 = "Maher";
        String S2 = "Mher";
        boolean IsFound = S1.contains(S2);
        if (IsFound) {
            System.out.println("Pattern has been found");
        } else
        {
            System.out.println("Pattern has not been found");
        }

        //Pattern Checking Without using built-in Function.
        String Text = "NavinReddy";
        String Pattern = "Red";

        int Count = 0;

        int tlen = Text.length();
        int plen = Pattern.length();
        char c,p;

        for(int i = 0; i <= tlen-plen; i++)
        {
            c = Text.charAt(i);
            p = Pattern.charAt(0);

            if(c==p)
            {
                for(int j=i,k=0; j<i+plen;j++,k++)
                {
                    c = Text.charAt(j);
                    p = Text.charAt(k);
                    if(c==p)
                    {
                        Count++;
                    }
                }
            }
        }
        if(Count == plen)
        {
            System.out.println("Pattern is found");
        }
        else
        {
            System.out.println("Pattern is not found");
        }
        String Str5 = "Maher";
        StringBuilder sbld = new StringBuilder();
        StringBuffer sb = new StringBuffer();
        sbld.append(Str5);
        sb.append(Str5);
        System.out.println(sbld);
        System.out.println(sb);

        //String Code Remove Characters from a string

        String str = "987bv68a667";
        str = Convert(str);
        System.out.println(str);
    }
}
