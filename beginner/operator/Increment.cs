using System;

public class Increment
{
    public static void Main(string[] args)
    {
        int x = 0;

        /*
        * x++: Use then add.
        * ++x: Add then use. */
        Console.WriteLine(x++); // Output: 0
        Console.WriteLine(x++); // Output: 1
        Console.WriteLine(x++); // Output: 2
        Console.WriteLine(x++); // Output: 3
        Console.WriteLine(x++); // Output: 4

        Console.WriteLine(x--); // Output: 5
        Console.WriteLine(x--); // Output: 4
        Console.WriteLine(x--); // Output: 3
        Console.WriteLine(x--); // Output: 2
        Console.WriteLine(x--); // Output: 1

        Console.WriteLine(x); // Output: 0

        int y = 0;

        /*
         * y--: Use then subtract.
         * --y: Subtract then use. */
        Console.WriteLine(++y); // Output: 1
        Console.WriteLine(++y); // Output: 2
        Console.WriteLine(++y); // Output: 3
        Console.WriteLine(++y); // Output: 4
        Console.WriteLine(++y); // Output: 5

        Console.WriteLine(--y); // Output: 4
        Console.WriteLine(--y); // Output: 3
        Console.WriteLine(--y); // Output: 2
        Console.WriteLine(--y); // Output: 1
        Console.WriteLine(--y); // Output: 0

        Console.WriteLine(y); // Output: 0
    }
}