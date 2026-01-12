using System;

class Program
{
    static void Main(string[] args)
    {
        // Asking for user's name
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        // Display user's name in assignment format.
        Console.WriteLine($"\nYour name is {lname}, {fname} {lname}.");
    }
}