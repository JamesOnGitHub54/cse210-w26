using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

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

        // The sum is calculated.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // The average is calculated.
        float countNumbers = numbers.Count;
        float average = sum / countNumbers;
        Console.WriteLine($"The average is: {average}");

        // The maximum is stored.
        int maximum = 0;
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        // Maximum number is referred to as the "largest number" in expected output.
        Console.WriteLine($"The largest number is: {maximum}");
    }
}