using System;

public class ReadLine
{
    public static void Main(string[] args)
    {
        Console.Write("Insert a number: ");

        /*
         * Now we will use Console.ReadLine() to get user input.
         * The Console.ReadLine() method returns a string.
         * 
         *  If you enter wrong input (e.g., text in a numerical input),
         * you will get an exception/error message like
         * System.FormatException: 'Input string was not in a correct format'. */
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Value: " + number);
    }
}