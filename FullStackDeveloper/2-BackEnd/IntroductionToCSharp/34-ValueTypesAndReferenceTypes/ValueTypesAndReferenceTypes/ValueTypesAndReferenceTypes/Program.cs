namespace ValueTypesAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // Value Type Example
            // -------------------------------
            int a = 10;  // 'a' is a value type (stored in the stack)
            int b = a;   // 'b' gets a COPY of 'a'

            b = 20;  // Changing 'b' does NOT affect 'a'

            Console.WriteLine($"Value Type Example - a: {a}, b: {b}");
            // Output: a: 10, b: 20
            // Key Point: Value types store their data directly in the variable.

            // -------------------------------
            // Reference Type Example
            // -------------------------------
            int[] array1 = { 1, 2, 3 };  // 'array1' is a reference type (stored in the heap)
            int[] array2 = array1;       // 'array2' points to the SAME memory location as 'array1'

            array2[0] = 100;  // Modifying 'array2' affects 'array1' as well

            Console.WriteLine($"Reference Type Example - array1[0]: {array1[0]}, array2[0]: {array2[0]}");
            // Output: array1[0]: 100, array2[0]: 100
            // Key Point: Reference types store a reference (address) to the actual data.

            // -------------------------------
            // Key Differences (Comment Summary)
            // -------------------------------
            // 1. Value Type:
            //    - Directly holds the data.
            //    - Stored in the stack.
            //    - Changing one copy does not affect the original.
            //    - Examples: int, float, bool, struct

            // 2. Reference Type:
            //    - Holds a reference (pointer) to the data.
            //    - Stored in the heap (reference stored in the stack).
            //    - Modifying one reference affects all references.
            //    - Examples: class, array, string, object
            // -------------------------------
            // Value Type Example (Method Call)
            // -------------------------------
            int x = 5;  // 'x' is a value type (stored in the stack)
            DuplicateValue(x);  // Pass 'x' by value (copy of 'x' is passed)

            Console.WriteLine($"After DuplicateValue - x: {x}");
            // Output: x: 5
            // Key Point: 'x' remains unchanged because a COPY of 'x' was modified inside the method.

            // -------------------------------
            // Reference Type Example (Method Call)
            // -------------------------------
            int[] arr = { 1, 2, 3 };  // 'arr' is a reference type (stored in the heap)
            DuplicateArrays(arr);     // Passes a reference to the array, NOT a copy

            Console.WriteLine($"After DuplicateArrays - arr[0]: {arr[0]}");
            // Output: arr[0]: 2
            // Key Point: 'arr' is modified because the method operates on the same memory reference.

            // -------------------------------
            // String Immutability Example
            // -------------------------------

            string Str = "Hello";  // Step 1: 'Str' points to "Hello" in memory (heap)
            Str += " World";       // Step 2: A NEW string "Hello World" is created

            Console.WriteLine(Str);
            // Output: Hello World
            // Key Point: The original "Hello" string is not changed.
            // Instead, 'Str' now points to the new "Hello World" string.

            // -------------------------------
            // What Happens Internally
            // -------------------------------
            // 1. "Hello" is created and stored in memory.
            // 2. " World" is appended, creating a new string "Hello World".
            // 3. 'Str' is updated to point to the new string.
            // 4. The original "Hello" may eventually be garbage collected if no references remain.
        }

        // -------------------------------
        // Value Type Method
        // -------------------------------
        static void DuplicateValue(int num1)
        {
            num1 *= 2;  // This changes 'num1' locally, but not the original 'x' in Main()
        }

        // -------------------------------
        // Reference Type Method
        // -------------------------------
        static void DuplicateArrays(int[] Array1)
        {
            // Loop through the array and double each element
            for (int i = 0; i < Array1.Length; i++)
            {
                Array1[i] *= 2;
            }
            // Modifies the original array since Array1 points to the same memory as 'arr' in Main()
        }
    }
}
