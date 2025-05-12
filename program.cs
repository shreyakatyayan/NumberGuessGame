using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int numberToGuess = rand.Next(1, 101); // 1 to 100
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("Guess a number between 1 and 100.");

        while (guess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < numberToGuess)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > numberToGuess)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Correct! You guessed it in {attempts} attempts.");
            }
        }
    }
}
