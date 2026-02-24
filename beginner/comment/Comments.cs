using System;

/*
 * Comments can be used to explain C# code, and to make it more readable.
 * It can also be used to prevent execution when testing alternative code. */
public class Comments
{
    public static void Main(string[] args)
    {
        // This is a single-line comment.
        Console.Write("Hello World!");          // Output: Hello World!
        Console.Write("\n");                    // Output:
        Console.Write("Hello, John Doe!\n");    // Output: Hello, John Doe!

        /*
         * This is a multi-line comment.
         * Print "Have a nice day" */
        Console.WriteLine("Have a nice day");   // Output: Have a nice day
    }
}