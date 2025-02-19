using Properties;

public class main
{
    public static void Main(string[] args)
    {
        Man man = new Man(13) { Address = "Faisal"};//Object Initializer.
        man.Name = "Maher";
        Console.WriteLine(man.Name);
        man.Name = "Laptop";
        Console.WriteLine(man.Name);
        //man.ID = 1; Not allowed because it is read-only property.
        Console.WriteLine(man.ID);
        //man.Address = "Faisal";You can't assign a value here it is not allowed because it has an init accessor. 
        Console.WriteLine(man.Address);
    }
}
