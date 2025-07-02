using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // In this section the student Will enter the grade % of the course.

        Console.Write("Hello Student Please Enter Your Grade: ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string letter = "";
        string sign = "";

        // In this section it will go for argue if how many % grade does the student input so it will check in if statement.
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        // In this section it will determine the sign of the grade %.
        int lastDigit = grade % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && grade < 93)
        {
            sign = "-";
        }


        Console.WriteLine($"Your grade is {letter}{sign}");

        // In this section it will determine if the student passed the course or not.

        if (grade >= 70)
        {
            Console.Write("Congratulations, you passed the course!");
        }
        else
        {
            Console.Write("Sorry, you did not pass the course. Please try again.");
        }




    
    }
}