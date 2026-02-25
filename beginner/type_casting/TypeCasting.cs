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
    }
}