using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percentage = int.Parse(Console.ReadLine());
        string letter;

        // Determine letter grade.
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print letter grade.
        Console.WriteLine($"You have earned the letter grade of: {letter}");

        // Determine and print appropriate message from letter grade.
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the class. You can do it next time!");
        }
    }
}