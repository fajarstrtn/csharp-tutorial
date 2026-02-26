using System;

public class Param
{

    /*
     * The params keyword in C# allows a method to accept
     * a variable number of arguments of a specified type.
     * It is used as a parameter which can take
     * the variable number of arguments of specific data type.
     * It is a useful feature when the number of arguments is unknown,
     * providing flexibility in method calls.
     *
     * Some key points involved with params in C#:
     * 1. It is useful when programmers don't know the number of parameters to be used.
     * 2. Only one params keyword is allowed and no additional params will be allowed
     * in function declaration after a params keyword.
     * 3. The length of the params will be zero if no arguments are passed.
     *
     * Rules you must know about params keyword:
     * 1. Single params per method  : You can only use one params parameter in a method to avoid ambiguity.
     * You need to specify the array type, and all arguments passed must be compatible with that type.
     * 2. Must be the last parameter: The params keyword should be the last parameter
     * in the method signature to ensure that the method correctly interprets the arguments.
     * 3. Empty array               : If no arguments are passed to a params parameter,
     * it will be treated as an empty array.
     *
     * Benefits of Using Params:
     * 1. Simplifies Method Overloading  : Without params, you need to create multiple method overloads
     * to handle different numbers of arguments.
     * This increases the complexity and reduces maintainability.
     * Allows the single method to accept any number of arguments.
     * 2. Improved Code Readability      : It enhances code readability by eliminating the need
     * to manually create arrays or use multiple overloads.
     * Pass values directly to the method in a comma-separated list,
     * making method calls more easier to read.
     * 3. Flexibility with Argument Count: Allow to pass any number of arguments (including none),
     * making the method more flexible.
     * The method can handle any number of values,
     * making it more versatile and adaptable.
     * 4. Supports Implicit Array        : It automatically wraps values in an array.
     * This eliminates the need of explicitly create an array before passing it,
     * improving ease of use. */
    private static void Iterate(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length; ++i)
        {
            Console.Write(numbers[i]);
            if (numbers[i] != (numbers.Length - 1))
                Console.Write(" ");
        }
        Console.WriteLine();
    }

    private static void Absorb(int number, params string[] words)
    {
        Console.Write(number + " ");

        string text = "";
        foreach (string word in words)
        {
            text += word + " ";
        }
        Console.WriteLine(text.Trim());
    }
    public static void Main(string[] args)
    {
        Iterate(100, 200, 300, 400, 500);    // Output: 100 200 300 400 500
        Absorb(1000, "Hello", "World", "!"); // Output: 1000 Hello World !
    }
}