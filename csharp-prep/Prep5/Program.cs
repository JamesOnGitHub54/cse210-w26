using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squareNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squareNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int favoriteNumber)
    {
        int SquareNumber = favoriteNumber * favoriteNumber;
        return SquareNumber;
    }

    static void DisplayResult(string userName, int SquareNumber, int birthYear)
    {
        Console.Write($"{userName}, the square of your number is: {SquareNumber}\n{userName}, you will turn {2026 - birthYear} this year.");
    }
}