public class Main {
    public static void main(String[] args) {
        //To create an array of characters there are many ways and methods.
        //First Method
        char[] A1 = {'M', 'a', 'h', 'e', 'r'};
        System.out.println(A1);
        //Second Method
        String A2 = "Maher";
        String A3 = "Maher";
        System.out.println(A2);
        //Third Method
        String A4 = new String("Maher");
        System.out.println(A4);

        String A5 = new String("Maher");

        System.out.println(A1 + A2 + A3 + A4 + A5);//Don't use Characters With another Strings as it will print Garbage and Ascii code
        // `==` checks if two references point to the **same object** in memory (reference comparison).
        // For String literals (e.g., "Maher"), `==` may return true because they refer to the same object in the string pool.
        System.out.println(A2 == A3);  // true, because both refer to the same string in the pool.

        // `equals()` compares the **content** (value) of two objects, not their references.
        // It is used to check if two objects have the same value, even if they are different objects in memory.
        System.out.println(A4.equals(A5));  // true, because both have the same content ("Maher").

        // `==` with `new String()` will return false because the references are different objects in memory.
        System.out.println(A4 == A5);  // false, because A4 and A5 are different objects, even though they have the same content.

        // Use `equals()` or 'matches()' for comparing the **content** of objects like Strings.
        System.out.println(A2.equals(A4));
        System.out.println(A4.equals(A5));
        System.out.println(A2.matches(A4));
        System.out.println(A4.matches(A5));

        // In Java, String is **immutable**, meaning that once a String object is created, its content cannot be changed.
        // Any operation that seems to modify a String actually creates a new String object, leaving the original unchanged.

        // Example:
        String A6 = "Hello";
        // If you try to change A1, a new String object is created:
        A6 = A6 + " World";  // A new String "Hello World" is created, A1 now points to that new String.
        // The original "Hello" string is not modified; it remains in memory (if not garbage collected).

        System.out.println(A6);  // Outputs: "Hello World"

        // Why is String immutable?
        // 1. **Security**: Immutable objects are safe to share across different parts of a program without worrying about accidental changes.
        // 2. **Performance**: Java uses a **String pool** for string literals, where identical strings are reused. If Strings were mutable, this sharing would not be possible without synchronization.
        // 3. **Hashing**: Strings are widely used as keys in HashMaps, and their immutability ensures that the hashcode is consistent throughout the object's lifetime, which is important for HashMap operations.

        // When you "edit" a String (e.g., using concatenation), you are actually creating a new String object rather than modifying the original.
    }
}