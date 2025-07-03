using System;
using System.Globalization;
using System.Linq;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> num = new List<int>();
        int userInput;

        Console.WriteLine("Enter numbers to add to the List (enter 0 when finished):");

        // Using a do-while loop to ensure the user is prompted at least once.
        // and to allow them to enter multiple numbers until they enter 0.
        do
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                num.Add(userInput);
            }
        } while (userInput != 0);


        // Core Calculations.
        // Calculate the sum, average, and maximum of the numbers in the list.

        int sum = num.Sum();
        double average = num.Average();
        int max = num.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average} ");
        Console.WriteLine($"The maximum number is: {max}");


        // Stretch Core Find the smallest positive num in the List.
        int smallPositive = num
            .Where(n => n > 0)
            .DefaultIfEmpty(-1)
            .Min();

        if (smallPositive > 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallPositive}");
        }

        
        // Stretch Core Sorting the List
        num.Sort();
        Console.WriteLine("The sorted numbers are:");
        foreach (int num2 in num)
        {
            Console.WriteLine(num2);
        }
    }
}