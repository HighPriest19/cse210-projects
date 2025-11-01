using System;

class Program
{
    static void Main()
    {
        // Exercise 2: Practice if statements and decision making

        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        // Convert user input (string) to a number
        int grade = int.Parse(input);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
    }
}
