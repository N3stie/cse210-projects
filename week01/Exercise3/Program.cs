using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // i combine all the 1-3 cores and taking this as a improve code also specificaly following the rubrics.

        Random randomGen = new Random();
        string playAgain;

        do
        {
            int randomNum = randomGen.Next(1, 101);
            int guess;
            int guessCount = 0;

            Console.WriteLine("********** Welcome to the Number Guessing Game! **********");

            do
            {
                Console.Write("Please enter your guess (Between 1 and 100):");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess < randomNum)
                {
                    Console.WriteLine("Higer");
                }
                else if (guess > randomNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {randomNum} in {guessCount} attempts.");
                }

            } while (guess != randomNum);

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes" || playAgain == "y");
        {
            Console.WriteLine("Thank you for playing!");
        }

    }
}