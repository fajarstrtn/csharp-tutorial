using System;

public class Operator
{
    public static void Main(string[] args)
    {
        // An operator is a symbol that performs an operation on values.
        int result = 10 + 125;
        Console.WriteLine(result); // Output: 135

        int x = 400, y = 150;

        Console.WriteLine((x + y)); // Output: 550
        Console.WriteLine((x - y)); // Output: 250
        Console.WriteLine((x * y)); // Output: 60000
        Console.WriteLine((x / y)); // Output: 2
        Console.WriteLine((x % y)); // Output: 100
    }
}