using System;
using System.IO.Pipes;

/*
 * The const keyword is useful when you want a variable
 * to always store the same value, so that others won't mess up your code.
 *
 * You cannot declare a constant variable without assigning the value.
 * If you do, an error will occur. */
public class Constant
{
    // This will declare the variable as a constant, which means unchangeable and read-only.
    public const double PI = 3.14;

    public static void Main(string[] agrs)
    {
        const string DEFAULT_SHAPE = "Circle";

        Console.WriteLine(PI);            // Output: 3,14
        Console.WriteLine(DEFAULT_SHAPE); // Output: Circle
    }
}