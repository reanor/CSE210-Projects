using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter;

        if (number >= 90)
        {
            letter = "A - You Passed!";
        }
        else if (number >= 80)
        {
            letter = "B - You Passed!";
        }
        else if (number >= 70)
        {
            letter = "C - You Passed!";
        }
        else
        {
            letter = "lower than required to pass this class. Maybe next time!";
        }
        Console.WriteLine($"Your grade is - " + letter);
    }
}