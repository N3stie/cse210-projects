using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // i combine all the 1-3 cores and taking this as a improve code also specificaly following the rubrics.

        Random randomGen = new Random();
        string playAgain;

        // instead of while loop, i use do-while loop to ensure the game runs at least once and allows the user to play again.
        // this is a good practice to ensure the game runs at least once and allows the user
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
                    Console.WriteLine("Higher");
                }
                else if (guess > randomNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {randomNum} in {guessCount} attempts.");
                }


                // i use do-while loop to ensure the user is prompted until they guess the correct number.
            } while (guess != randomNum);

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes" || playAgain == "y");
        {
            Console.WriteLine("Thank you for playing!");
        }

    }
}