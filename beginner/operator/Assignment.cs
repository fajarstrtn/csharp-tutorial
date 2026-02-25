using System;

public class Assignment
{
    public static void Main(string[] args)
    {
        string name = "John Doe";
        Console.WriteLine(name);

        int number = 10;
        number += 10;
        Console.WriteLine(number); // Output: 20

        number -= 5;
        Console.WriteLine(number); // Output: 15

        number *= 4;
        Console.WriteLine(number); // Output: 60

        number /= 2;
        Console.WriteLine(number); // Output: 30

        number %= 3;
        Console.WriteLine(number); // Output: 0
    }
}