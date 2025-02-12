using Classes_And_Objects;

public class main
{
    public static void Main(string[] args)
    {
        //All classes in csharp extends and inherits from class object indirectly or directly.
        Man man = new Man();
        object obj = new object();
        dynamic x = 0;
        x = "s";
        man.Name = "Maher";
        man.Address = "Faisal";
        man.PhoneNumber = "12345";
        Console.WriteLine(man.Name);
        Man[] men = new Man[3];
        men[0] = new Man();
        men[1] = new Man();
        men[2] = new Man();
        men[0].Name = "Yousef";
        men[1].Name = "Ahmed";
        men[2].Name = "Mostafa";
        foreach(Man Men1 in men)
        {
            Console.WriteLine(Men1.Name);
        }
        men[0] = man;
    }
}