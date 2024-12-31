namespace WritingToConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boolean is a data type that can only have two values: true or false
            Boolean Result1 = true, Result2 = false;
            //you can use boolean or bool to declare a boolean variable
            bool Result3 = true;
            Console.WriteLine(Result1);//true
            Console.WriteLine(Result2);//false
            //you can also use boolean operators to compare two boolean values
            //&& is the AND operator, it returns true if both values are true
            //&& is also a short-circuit operator, it will not evaluate the second value if the first value is false
            Result3 = Result1 && Result2;
            Console.WriteLine(Result3);//false
            //& is the AND operator, it returns true if both values are true
            //& is not a short-circuit operator, it will evaluate both values
            Result3 = Result1 & Result2;
            Console.WriteLine(Result3);//false
            //|| is the OR operator, it returns true if one of the values is true
            //|| is also a short-circuit operator, it will not evaluate the second value if the first value is true
            Result3 = Result1 || Result2;
            Console.WriteLine(Result3);//true
            //| is the OR operator, it returns true if one of the values is true
            //| is not a short-circuit operator, it will evaluate both values
            Result3 = Result1 | Result2;
            Console.WriteLine(Result3);//true
            //! is the NOT operator, it returns the opposite of the value
            Result3 = !Result1;
            Console.WriteLine(Result3);//false
            Result3 = !Result2;
            Console.WriteLine(Result3);//true
            //XOR is the exclusive OR operator, it returns true if one of the values is true and the other is false
            Result3 = Result1 ^ Result2;
            Console.WriteLine(Result3);//true
            Result1 = true;
            Result2 = true;
            Result3 = Result1 ^ Result2;
            Console.WriteLine(Result3);//false
            int Total = 900;
            int VipThershold = 1000;
            //Ternary Operator in general is used to check a condition and return a value based on the condition
            bool IsVip = (Total >= VipThershold) ? true:false;
            int Discount = IsVip ? 10 : 0;
            Console.WriteLine(Discount);
        }
    }
}
