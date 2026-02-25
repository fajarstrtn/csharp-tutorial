using System;

public class Logical
{
    public static void Main(string[] args)
    {
        bool x = true, y = false;

        Console.WriteLine(x && y); // Output: False
        Console.WriteLine(x || y); // Output: True
        Console.WriteLine(!x);     // Output: False
        Console.WriteLine(!y);     // Output: True
    }
}