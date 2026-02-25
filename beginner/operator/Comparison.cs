using System;

public class Comparison
{
    public static void Main(string[] args)
    {
        int x = 100, y = 200;

        Console.WriteLine(x == y); // Output: False
        Console.WriteLine(x != y); // Output: True
        Console.WriteLine(x > y);  // Output: False
        Console.WriteLine(x < y);  // Output: True
        Console.WriteLine(x >= y); // Output: False
        Console.WriteLine(x <= y); // Output: True
    }
}