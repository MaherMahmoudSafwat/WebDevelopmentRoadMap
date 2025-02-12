
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Casting :-
            //1-Implicit Casting
            //2-Explicit Casting
            //1. Implicit Casting (Widening) - Automatically done by C# when converting a smaller type to a larger type. No data loss.
            int x = 5;
            double y = x;
            short m = 8;
            // m = x; This is not allowed
            /* 2.Explicit Casting(Narrowing) - Manually done by the programmer when converting a larger type to a smaller type.
            Can cause data loss.*/
            m = (short)x;
            Console.WriteLine(m);
            float A = 5.56789f;
            double X = A;
            A = (float)X;
            int K = 5;
            K = (int)A;
            //Explicit Casting from float to integer can loss data type so here we use Explicit Casting.
            Console.WriteLine(K);
        }
    }