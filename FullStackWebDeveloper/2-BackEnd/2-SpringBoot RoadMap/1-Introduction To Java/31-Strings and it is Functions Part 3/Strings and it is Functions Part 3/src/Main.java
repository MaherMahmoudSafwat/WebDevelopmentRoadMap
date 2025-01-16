public class Main {
    public static void main(String[] args)
    {
        String S1 = "C++ / Ruby / Java / C# / Python";
        //To Spilt Strings in an array.
        String [] S2 = S1.split("/");
        for (String i : S2)
        {
            System.out.println(i.trim());
        }
        //To join Strings Array in only one String
        String S3 = String.join("",S2);
        System.out.println(S3);
        //Char type has character class that has it is own methods.
        Character A = 'a';
        A = Character.toUpperCase(A);
        System.out.println(A);
        //String data type is a class and it alo has it is own methods.
        String C = String.valueOf(5);
        System.out.println(C);


    }
}