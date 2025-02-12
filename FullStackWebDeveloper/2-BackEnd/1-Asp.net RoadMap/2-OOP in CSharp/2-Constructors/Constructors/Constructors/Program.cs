using Constructors;

public class main
{
    public static void Main(string[] args)
    {
        /*
         -The 'new Man("Maher")' creates a new 'Man' object in heap memory, 
         - and 'man1' stores a reference (memory address) to that object. 
         - The 'man1' variable itself is stored on the stack, but it points to 
         - the actual object in the heap. The object is managed by the garbage collector 
         - and will be cleaned up when no longer referenced.
        */ 
        Man man1 = new Man("Maher");
        Console.WriteLine(man1.Name);
    }
}