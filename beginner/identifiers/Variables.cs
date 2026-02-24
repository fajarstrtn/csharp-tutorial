using System;

/*
 * Variable is a container used to store data value during program execution.
 * It's a placeholder of the information which can be changed at runtime. */
public class Variables
{
    public static void Main(string[] args)
    {
        string name = "John Doe";
        double salary;
        salary = 10000000;
        bool isWorking = true;

        Console.WriteLine("Hi. My name is {0} and i work for {1}", name, salary);    // Output: Hi. My name is John Doe and i work for 10000000
        Console.WriteLine(isWorking ? "Yes, I am working" : "No, I am not working"); // Output: Yes, I am working

        // You can change the value of isWorking to false.
        isWorking = false;
        Console.WriteLine(isWorking); // Output: false

    }
}