using System;

/*
 * Identifiers are used for identification purposes.
 * Or in other words, identifiers are the user-defined name of the program components. */
public class Identifiers
{
    public static void Main(string[] args)
    {
        byte number = 10;
        byte number2 = 72;
        short _thousands = 15000;
        int higherNumber = 5731000;
        int HigherNumber = 9731000;

        // Identifiers are not allowed to use as keywords unless they include @ as a prefix.
        long @longNumber = 350000000000;

        // You can add as many WriteLine() methods as you want.
        Console.WriteLine(number);       // Output: 10
        Console.WriteLine(number2);      // Output: 72
        Console.WriteLine(_thousands);   // Output: 15000
        Console.WriteLine(higherNumber); // Output: 5731000
        Console.WriteLine(HigherNumber); // Output: 9731000
        Console.WriteLine(@longNumber);  // Output: 350000000000
    }
}