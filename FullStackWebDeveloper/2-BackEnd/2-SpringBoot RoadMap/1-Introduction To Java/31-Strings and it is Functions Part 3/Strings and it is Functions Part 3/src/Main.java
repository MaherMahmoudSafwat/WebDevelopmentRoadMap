public class Main {
    public static void main(String[] args)
    {
         //To spilt an array of strings.
        String S1 = "C++ / C / JAVA / C# / PYTHON";
        String [] S2 = S1.split("/");
        for(String i : S2)
        {
            System.out.println(i);
        }
        //To join an array of Strings
        String S3 = String.join(S2,"");
        System.out.println(S3);
        //There is a Character class and it has it is own methods
        Character A = 'A';
        System.out.println(Character.toLowerCase(A));
        //There is a String class and it has it is own Methods
        String B = "B";
        System.out.println(B.indexOf("B"));
        //There is a Integer cxlass and it has it is own methods
        Integer X = 51639;
        System.out.println(Integer.max(X));
        //Every Primitive data type has its own class and it is own method but you write the primitve data type completely and the first charcter of it is capital.
        System.out.println(Double.max(123));
    }
}
