using System;

/*
 * Comments can be used to explain C# code, and to make it more readable.
 * It can also be used to prevent execution when testing alternative code.
 *
 * Comments are an important part of the code.
 * They allow developers to explain their code,
 * document important information and make the code easier to understand.
 * Whatever you write in comments, compilers ignore it and do not execute them.
 *
 * For writing good and productive comments please remember the points mentioned below:
 * 1. Comments are self-explanatory       : Comments should add value
 * by explaining complex or non-obvious logic.
 * 2. Comments should be clear and concise: Avoid writing overly complex comments
 * that could confuse the reader.
 *
 * In C#, There are three types of comments which are defined below:
 * 1. Single-line comments
 * 2. Multi-line Comments
 * 3. XML comments */
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

    /// <summary>
    /// Generate a message with specific username.
    /// </summary>
    /// <param name="username">The unique username.</param>
    /// <returns>No return message, just print it to the console.</returns>
    public static void sayHi(string username)
    {
        Console.WriteLine("Hello, " + username);
    }
}