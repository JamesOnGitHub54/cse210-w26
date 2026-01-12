using System;

class Program
{
    static void Main(string[] args)
    {
        // Magic number established by user.
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Magic number is generated.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Initialized user guess will differ from magic number.
        int userGuess = magicNumber + 1;

        // Game loops until number is guessed.
        while (userGuess != magicNumber)
        {
            // User guess is made.
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            // Determine guess to magic number relationship. Gives hint or completion message.
            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}