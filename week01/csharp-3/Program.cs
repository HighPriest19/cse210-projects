using System;

class Program
{
    static void Main()
    {
        // Exercise 3: Using loops to keep asking for numbers until the user types 0

        int number = -1;   // initialize with a non-zero value
        int sum = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                sum += number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}
