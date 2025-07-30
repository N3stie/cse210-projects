using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("Vhea Bulanadi ", " Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Roberto Son", " Fractions ", "7.3", "1-10");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("May Walters", "European History", "Roman Empire");
        Console.WriteLine(assignment3.GetSummary());    
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}