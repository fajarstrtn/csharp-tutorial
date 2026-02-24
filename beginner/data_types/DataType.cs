using System;

public class DataType
{
    public static void Main(string[] args)
    {
        sbyte a = -127;
        byte b = 255;
        short c = 32000;
        ushort d = 65001;
        int e = 2000000;
        uint f = 65000000;
        long g = 1000000000;
        ulong h = 5000000000000;
        float i = 3.14f;
        double j = 105.27e4d;
        decimal k = 110.9898m;
        char l = 'a';
        bool m = true;
        string n = "Hello World";
        String o = "Manchester";
        object p = "The Red Devils";

        /*
         * Literal is a fixed value used in a program.
         * These values are directly written into the code
         * and can be used by variables.
         *
         * A literal can be an integer, floating-point number,
         * string, character, boolean, or even null. */
        object q = null;

        string r = @"This is a message";

        Console.WriteLine(a); // Output: -127
        Console.WriteLine(b); // Output: 255
        Console.WriteLine(c); // Output: 32000
        Console.WriteLine(d); // Output: 65001
        Console.WriteLine(e); // Output: 2000000
        Console.WriteLine(f); // Output: 65000000
        Console.WriteLine(g); // Output: 1000000000
        Console.WriteLine(h); // Output: 5000000000000
        Console.WriteLine(i); // Output: 3,14
        Console.WriteLine(j); // Output: 1052700
        Console.WriteLine(k); // Output: 110,9898
        Console.WriteLine(l); // Output: a
        Console.WriteLine(m); // Output: True
        Console.WriteLine(n); // Output: Hello World
        Console.WriteLine(o); // Output: Manchester
        Console.WriteLine(p); // Output: The Red Devils
        Console.WriteLine(q); // Output: 
        Console.WriteLine(r); // Output: This is a message
    }
}