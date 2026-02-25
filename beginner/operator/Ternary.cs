using System;

public class Ternary
{
    public static void Main(string[] args)
    {
        bool isWorking = true;
        string status = isWorking ? "I am working" : "I am not working";
        Console.WriteLine(status); // Output: I am working

        if (isWorking)
            status = "I am still working";
        else
            status = "I am in an idle mode";

        Console.WriteLine(status); // Output: I am still working
    }
}