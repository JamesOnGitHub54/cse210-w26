using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine ("Enter a list of numbers, type 0 when finished.");

        // Add to list until 0 is entered.
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum is calculated.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}