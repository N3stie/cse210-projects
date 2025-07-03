using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the welcome message function
        DisplayWelcome();

        // Ask the user for their name and store it
        string userName = PromptUserName();

        // Ask the user for their favorite number and store it
        int userNumber = PromptUserNumber();

        // Square the number entered by the user
        int squaredNumber = SquareNumber(userNumber);

        // Show the final result to the user
        DisplayResult(userName, squaredNumber);
    }

    // This function shows a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // This function asks for the user's name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // This function asks for the user's favorite number and returns it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        while (true)
        {
            // Try to convert the input to an integer
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }
            // If input is not valid, ask again
            Console.Write("Invalid input. Please enter a valid number: ");
        }
    }

    // This function takes a number and returns it squared
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // This function shows the user's name and the squared number
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
