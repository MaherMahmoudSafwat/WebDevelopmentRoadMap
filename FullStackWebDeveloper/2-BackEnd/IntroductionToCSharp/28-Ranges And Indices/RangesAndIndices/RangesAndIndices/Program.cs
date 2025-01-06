namespace RangesAndIndices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indices are used to access elements from the end of the collection
            //var can't be used with [] to declare an array
            var numbers = new string[] 
            { 
                "one", //---> 0  5th element from the end
                "two", //---> 1  4rd element from the end
                "three", //---> 2 3nd element from the end
                "four", //---> 3 2st element from the end
                "five" //---> 4 1th element from the end
            };
            //Accessing elements from the end of the collection
            var lastElement = numbers[^1];//Accessing the last element
            Console.WriteLine($"Last element is {lastElement}");//Output: Last element is five
            var secondLastElement = numbers[^2];//Accessing the second last element
            Console.WriteLine($"Second last element is {secondLastElement}");//Output: Second last element is four
            var thirdLastElement = numbers[^3];//Accessing the third last element
            Console.WriteLine($"Third last element is {thirdLastElement}");//Output: Third last element is three
            var fourthLastElement = numbers[^4];//Accessing the fourth last element
            Console.WriteLine($"Fourth last element is {fourthLastElement}");//Output: Fourth last element is two
            var fifthLastElement = numbers[^5];//Accessing the fifth last element
            Console.WriteLine($"Fifth last element is {fifthLastElement}");//Output: Fifth last element is one
            

            Console.WriteLine("[1..^1]");//Output: [1..^1]
            var range = numbers[1..^1];//Accessing elements from the 1st index to the 4th index
            //range now is an array of strings with the following elements {"two", "three", "four"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[..^2]");//Output: [..^2]
            range = numbers[..^2];//Accessing elements from the 0th index to the 3rd index
            //range now is an array of strings with the following elements {"one", "two", "three"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[2..^3]");//Output: [2..^3]
            range = numbers[2..^3];//Accessing elements from the 2nd index to the 2nd index
            //range now is an array of strings with the following elements {"three"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[^3..^1]");//Output: [^3..^1]
            range = numbers[^3..^1];//Accessing elements from the 2nd index to the 2nd index
            //range now is an array of strings with the following elements {"three", "four"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[^3..^2]");//Output: [^3..^2]
            range = numbers[^3..^2];//Accessing elements from the 2nd index to the 2nd index
            //range now is an array of strings with the following elements {"three"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[^3..^3]");//Output: [^3..^3]
            range = numbers[^3..^3];//Accessing elements from the 2nd index to the 2nd index
            //range now is an empty array of strings
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[^3..]");//Output: [^3..]
            range = numbers[^3..];//Accessing elements from the 2nd index to the end of the collection
            //range now is an array of strings with the following elements {"three", "four", "five"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[..]");//Output: [..]
            range = numbers[..];//Accessing all elements of the collection
            //range now is an array of strings with the following elements {"one", "two", "three", "four", "five"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[1..4]");//Output: [1..4]
            range = numbers[1..4];//Accessing elements from the 1st index to the 4th index
            //range now is an array of strings with the following elements {"two", "three", "four"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[1..]");//Output: [1..]
            range = numbers[1..];//Accessing elements from the 1st index to the end of the collection
            //range now is an array of strings with the following elements {"two", "three", "four", "five"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("[..5]");//Output: [..5]
            range = numbers[..5];//Accessing elements from the 0th index to the 5th index
            //range now is an array of strings with the following elements {"one", "two", "three", "four", "five"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }



            //--------------------------------------------------------------------------------
            //Ranges and indices can be used with arrays, lists, and strings
            //Range is a struct that has a Start and End property
            //Range is a datatype that is used to represent a range of elements in a collection
            Range range1 = 1..4;//range is a range of elements from the 1st index to the 4th index
            Console.WriteLine(range1);//Output: 1..4
            range = numbers[range1];//Accessing elements from the 1st index to the 4th index
            //range now is an array of strings with the following elements {"two", "three", "four"}
            foreach (var item in range)
            {
                Console.WriteLine(item);
            }
            Range range2 = 1..^5;//range is a range of elements from the 1st index to the 5th index from the end
            Console.WriteLine(range1.GetType());//Output: System.Range
            Console.WriteLine(range1.Start);//Output: 1
            Console.WriteLine(range1.End);//Output: 4
            Console.WriteLine(range2);//Output: 1..^5
            Console.WriteLine(range2.GetType());//Output: System.Range
            Console.WriteLine(range2.Start);//Output: 1
            Console.WriteLine(range2.End);//Output: 5



            //--------------------------------------------------------------------------------
            //Index is a struct that has a Value property
            //Index is a datatype that is used to represent an index of an element in a collection
            Index index1 = 1;//index is an index of the 1st element
            Console.WriteLine(index1);//Output: ^1
            Console.WriteLine(index1.GetType());//Output: System.Index
            Console.WriteLine(index1.Value);//Output: 1
            Index index2 = ^5;//index is an index of the 5th element from the end
            Console.WriteLine(index2);//Output: ^5
            Console.WriteLine(index2.GetType());//Output: System.Index
            Console.WriteLine(numbers[index2]);//Output: 1



        }
    }
}
