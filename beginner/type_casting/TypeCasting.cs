using System;

public class TypeCasting
{
    public static void Main(string[] args)
    {
        // Implicit casting is done automatically when passing a smaller size type to a larger size type.
        int a = 100;
        long b = a;
        Console.WriteLine("Widening : {0} {1}", a, b); // Output: Widening : 100 100

        // Explicit casting must be done manually by placing the type in parentheses in front of the value.
        short c = 97;
        char d = (char)c;
        Console.WriteLine("Narrowing: {0} {1}", c, d); // Output: Narrowing: 97 a

        // It's also possible to convert data types explicitly by using built-in methods.
        int num1 = Convert.ToInt32("70");
        long num2 = Convert.ToInt64("1000000000");
        double num3 = Convert.ToDouble(10000);
        string str = Convert.ToString(10.5);
        bool @bool = Convert.ToBoolean("true");
        decimal _decimal = Convert.ToDecimal("10000000000");

        Console.WriteLine(num1);     // Output: 70
        Console.WriteLine(num2);     // Output: 1000000000
        Console.WriteLine(num3);     // Output: 10000
        Console.WriteLine(str);      // Output: 10,5
        Console.WriteLine(@bool);    // Output: True
        Console.WriteLine(_decimal); // Output: 10000000000

        byte number = 65;

        /*
         * In C#, numeric types support implicit conversions among themselves, but not to char or bool.
         * Also, char and bool are incompatible.
         * The compiler ensures type compatibility before conversion. */
        short @short = number;

        /*
         * Converting a short (16-bit signed integer) to a char (16-bit Unicode character)
         * requires an explicit cast because, while both are 16-bit,
         * a short can hold negative values that do not map to valid Unicode characters.
         * Since char is unsigned (range 0 to 65.535) and short is signed
         * (range this conversion is technically a narrowing conversion, not a widening one. 
         * Converting short to char char @char = @short; */
        int @int = number;
        long @long = @int;
        float @float = @long;
        double @double = @float;
        Console.WriteLine(@double); // Output: 65

        /*
         * Explicit type casting is the process of manually converting one data type
         * into another using a cast operator (type).
         * It is required when converting from a larger data type to a smaller one,
         * or between incompatible types and may cause data loss or exceptions. */
        double num4 = 1024.668;
        int num5 = (int)num4;
        Console.WriteLine(num5); // Output: 1024

        char ch1 = Convert.ToChar(65);
        Console.WriteLine(ch1); // Output: A
    }
}