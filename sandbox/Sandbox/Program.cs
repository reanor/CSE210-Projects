using System;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("This is in C#!");

        // int number = 5; 
        // number = 8;
        // number = number + 3;

        // string color = "blue";

        // if (number > 3)
        // {
        //     Console.WriteLine("");
        // }

        // Console.ReadLine(); - //storing
        Console.Write("Whats your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine($"Your color is {color}");

    }
}