import java.util.ArrayList;

public class Main {
    public static void main(String[] args)
    {
        // ============================
        // Array vs ArrayList Comparison
        // ============================

        // 1. **Array**:
        // - An array is a fixed-size container for elements of the same type.
        // - The size of an array is defined when it's created and cannot be changed.
        // - Arrays can store both primitive types (e.g., int, char) and objects.
        // - Access to elements is fast, as arrays are contiguous in memory.
        // - The size of an array cannot be modified once defined.
        // 2. **ArrayList**:
        // - An ArrayList is a part of the Java Collections Framework and is a dynamic array.
        // - Unlike arrays, ArrayLists can grow or shrink in size dynamically as elements are added/removed.
        // - ArrayLists can only store objects, so primitives must be boxed into wrapper classes (e.g., Integer for int).
        // - ArrayLists offer more functionality than arrays, like adding/removing elements, checking size, etc.
        // - Access to elements may be slightly slower than arrays due to dynamic resizing and extra functionality.
        // ============================
        // Key Differences:
        // ============================

        // 1. **Size**:
        // - Array: The size is fixed at the time of creation and cannot be changed.
        // - ArrayList: The size can change dynamically as elements are added or removed.

        // 2. **Performance**:
        // - Array: Generally better performance since elements are stored in contiguous memory.
        // - ArrayList: Slightly slower due to extra overhead for dynamic resizing and object storage.

        // 3. **Type of Elements**:
        // - Array: Can store both primitive data types (e.g., int, char) and objects.
        // - ArrayList: Can only store objects (wrapper classes like Integer, String, etc.).

        // 4. **Flexibility**:
        // - Array: Fixed size, so less flexible when elements need to be added or removed dynamically.
        // - ArrayList: More flexible, provides built-in methods like add(), remove(), clear(), etc., for dynamic changes.

        // ============================
        // When to Use Each:
        // ============================

        // - **Use Array**:
        //   - When the size is known ahead of time and will not change.
        //   - When storing primitive data types for performance reasons.
        //   - For faster, more memory-efficient data storage when no dynamic resizing is needed.

        // - **Use ArrayList**:
        //   - When the size of the collection may change dynamically.
        //   - When you need to add/remove elements frequently.
        //   - When you need methods like .add(), .remove(), .clear(), etc.
        ArrayList<String>Names = new ArrayList<>();
        Names.add("Ahmed");
        Names.add("Mohamed");
        Names.add("Youssef");
        System.out.println(Names);
        System.out.println(Names.size());

        Names.add(1,"Moustafa");
        System.out.println(Names);
        System.out.println(Names.size());

        Names.set(1,"Kamal");
        System.out.println(Names);
        System.out.println(Names.size());

        Names.remove(1);
        System.out.println(Names);
        System.out.println(Names.size()); 
    }
}