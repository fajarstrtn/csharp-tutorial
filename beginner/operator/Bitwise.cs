using System;

public class Bitwise
{
    public static void Main(string[] args)
    {
        int a = 5; // 0101
        int b = 3; // 0011

        int andResult = a & b;
        Console.WriteLine(andResult); // Output: 1

        int orResult = a | b;
        Console.WriteLine(orResult); // Output: 7

        int xorResult = a ^ b;
        Console.WriteLine(xorResult); // Output: 6

        int notResult = ~a;
        Console.WriteLine(notResult); // Output: -6

        int x = 10; // 1010

        int shiftedLeft = x << 2;
        Console.WriteLine(shiftedLeft); // Output: 40

        int shiftedRight = x >> 2;
        Console.WriteLine(shiftedRight); // Output: 2
    }
}