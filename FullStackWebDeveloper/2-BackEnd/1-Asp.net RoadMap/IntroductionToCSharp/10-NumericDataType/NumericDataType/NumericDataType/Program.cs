namespace NumericDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte is an 8-bit unsigned integer type that ranges from 0 to 255.
            //It is used to store only positive integer values.
            //byte Size is 1 byte
            byte byte1 = 10;
            byte byte2 = 20;
            byte byte3 = 50;
            // byte byte4 = -50; is not allowed as byte can only store positive integer values
            Console.WriteLine($"byte1: {byte1}");
            Console.WriteLine($"byte2: {byte2}");
            Console.WriteLine($"byte3: {byte3}");
            //sizeof operator is used to get the size of the data type
            Console.WriteLine($"Size of byte: {sizeof(byte)}");
            //minValue is used to get the minimum value of the data type
            Console.WriteLine($"Min Value of byte: {byte.MinValue}");
            //maxValue is used to get the maximum value of the data type
            Console.WriteLine($"Max Value of byte: {byte.MaxValue}");
            //sbyte is an 8-bit signed integer type that ranges from -128 to 127.
            //It is used to store small integer values.
            //sbyte Size is 1 byte
            sbyte sbyte1 = 10;
            sbyte sbyte2 = 20;
            sbyte sbyte3 = -50;
            Console.WriteLine($"sbyte1: {sbyte1}");
            Console.WriteLine($"sbyte2: {sbyte2}");
            Console.WriteLine($"sbyte3: {sbyte3}");
            Console.WriteLine($"Size of sbyte: {sizeof(sbyte)}");
            Console.WriteLine($"Min Value of sbyte: {sbyte.MinValue}");
            Console.WriteLine($"Max Value of sbyte: {sbyte.MaxValue}");
            //short is a 16-bit signed integer type that ranges from -32,768 to 32,767.
            //It is used to store small integer values.
            //short Size is 2 bytes
            short short1 = 10;
            short short2 = 20;
            short short3 = -50;
            Console.WriteLine($"short1: {short1}");
            Console.WriteLine($"short2: {short2}");
            Console.WriteLine($"short3: {short3}");
            Console.WriteLine($"Size of short: {sizeof(short)}");
            Console.WriteLine($"Min Value of short: {short.MinValue}");
            Console.WriteLine($"Max Value of short: {short.MaxValue}");
            //ushort is a 16-bit unsigned integer type that ranges from 0 to 65,535.
            //It is used to store only positive integer values.
            //ushort Size is 2 bytes
            ushort ushort1 = 10;
            ushort ushort2 = 20;
            ushort ushort3 = 50;
            // ushort ushort4 = -50; is not allowed as ushort can only store positive integer values
            Console.WriteLine($"ushort1: {ushort1}");
            Console.WriteLine($"ushort2: {ushort2}");
            Console.WriteLine($"ushort3: {ushort3}");
            Console.WriteLine($"Size of ushort: {sizeof(ushort)}");
            Console.WriteLine($"Min Value of ushort: {ushort.MinValue}");
            Console.WriteLine($"Max Value of ushort: {ushort.MaxValue}");
            //int is a 32-bit signed integer type that ranges from -2,147,483,648 to 2,147,483,647.
            //It is used to store integer values.
            //int Size is 4 bytes
            int int1 = 10;
            int int2 = 20;
            int int3 = -50;
            Console.WriteLine($"int1: {int1}");
            Console.WriteLine($"int2: {int2}");
            Console.WriteLine($"int3: {int3}");
            Console.WriteLine($"Size of int: {sizeof(int)}");
            //minValue is used to get the minimum value of the data type
            Console.WriteLine($"Min Value of int: {int.MinValue}");
            //maxValue is used to get the maximum value of the data type
            Console.WriteLine($"Max Value of int: {int.MaxValue}");
            //uint is a 32-bit unsigned integer type that ranges from 0 to 4,294,967,295.
            //It is used to store only positive integer values.
            //uint Size is 4 bytes
            uint uint1 = 10;
            uint uint2 = 20;
            uint uint3 = 50;
            // uint uint4 = -50; is not allowed as uint can only store positive integer values
            Console.WriteLine($"uint1: {uint1}");
            Console.WriteLine($"uint2: {uint2}");
            Console.WriteLine($"uint3: {uint3}");
            Console.WriteLine($"Size of uint: {sizeof(uint)}");
            Console.WriteLine($"Min Value of uint: {uint.MinValue}");
            Console.WriteLine($"Max Value of uint: {uint.MaxValue}");
            //long is a 64-bit signed integer type that ranges from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            //It is used to store large integer values.
            //long Size is 8 bytes
            long long1 = 10;
            long long2 = 20;
            long long3 = -50;
            Console.WriteLine($"long1: {long1}");
            Console.WriteLine($"long2: {long2}");
            Console.WriteLine($"long3: {long3}");
            Console.WriteLine($"Size of long: {sizeof(long)}");
            Console.WriteLine($"Min Value of long: {long.MinValue}");
            Console.WriteLine($"Max Value of long: {long.MaxValue}");
            //ulong is a 64-bit unsigned integer type that ranges from 0 to 18,446,744,073,709,551,615.
            //It is used to store only positive integer values.
            //ulong Size is 8 bytes
            ulong ulong1 = 10;
            ulong ulong2 = 20;
            ulong ulong3 = 50;
            // ulong ulong4 = -50; is not allowed as ulong can only store positive integer values
            Console.WriteLine($"ulong1: {ulong1}");
            Console.WriteLine($"ulong2: {ulong2}");
            Console.WriteLine($"ulong3: {ulong3}");
            Console.WriteLine($"Size of ulong: {sizeof(ulong)}");
            Console.WriteLine($"Min Value of ulong: {ulong.MinValue}");
            Console.WriteLine($"Max Value of ulong: {ulong.MaxValue}");
            //float is a 32-bit floating-point type that ranges from -3.402823e38 to 3.402823e38.
            //It is used to store single-precision floating-point values.
            //float Size is 4 bytes
            float float1 = 10.5f;
            float float2 = 20.5f;
            float float3 = -50.5f;
            //float Precision is 7 digits
            float float4 = 1.675534567897675676898f;
            Console.WriteLine($"float1: {float1}");
            Console.WriteLine($"float2: {float2}");
            Console.WriteLine($"float3: {float3}");
            Console.WriteLine($"float4: {float4}");
            Console.WriteLine($"Size of float: {sizeof(float)}");
            Console.WriteLine($"Min Value of float: {float.MinValue}");
            Console.WriteLine($"Max Value of float: {float.MaxValue}");
            //double is a 64-bit floating-point type that ranges from -1.79769313486232e308 to 1.79769313486232e308.
            //It is used to store double-precision floating-point values.
            //double Size is 8 bytes
            double double1 = 10.5;
            double double2 = 20.5;
            double double3 = -50.5;
            //double Precision is 15-16 digits
            double double4 = 1.675534567897675676898;
            Console.WriteLine($"double1: {double1}");
            Console.WriteLine($"double2: {double2}");
            Console.WriteLine($"double3: {double3}");
            Console.WriteLine($"double4: {double4}");
            Console.WriteLine($"Size of double: {sizeof(double)}");
            Console.WriteLine($"Min Value of double: {double.MinValue}");
            Console.WriteLine($"Max Value of double: {double.MaxValue}");
            //decimal is a 128-bit floating-point type that ranges from -79228162514264337593543950335 to 79228162514264337593543950335.
            //It is used to store decimal values.
            //decimal Size is 16 bytes
            decimal decimal1 = 10.5m;
            decimal decimal2 = 20.5m;
            decimal decimal3 = -50.5m;
            Console.WriteLine($"decimal1: {decimal1}");
            Console.WriteLine($"decimal2: {decimal2}");
            Console.WriteLine($"decimal3: {decimal3}");
            Console.WriteLine($"Size of decimal: {sizeof(decimal)}");
            Console.WriteLine($"Min Value of decimal: {decimal.MinValue}");
            Console.WriteLine($"Max Value of decimal: {decimal.MaxValue}");

            //1_000_000 is a valid integer Where you can use underscore to separate digits in numeric literals.
            int OneMillion = 1_000_000;
            Console.WriteLine(OneMillion);
            //to print 1,000,000 in screen you can use below code 
            //N0 is a standard numeric format string that represents a number with a comma as a thousands separator.
            //where N is a numeric format string that is used to format numeric values.
            //0 is a digit placeholder that specifies the desired number of digits to display after the decimal point.
            Console.WriteLine(OneMillion.ToString("N0"));//1,000,000

        }
    }
}
