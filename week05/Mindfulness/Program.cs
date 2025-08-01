using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Console.WriteLine(" Welcome to Cosmic Mind ");
        while (true)
        {
            Console.WriteLine("\nChoose a session:");
            Console.WriteLine("1. Breath Flow");
            Console.WriteLine("2. Reflect Journey");
            Console.WriteLine("3. Gratitude List");
            Console.WriteLine("4. Exit Universe");
            Console.Write(" Your choice: ");

            // using switch statement to handle user input
            // and start the corresponding session.
            switch (Console.ReadLine())
            {
                case "1":
                    new BreathFlowSession().Start();
                    break;
                case "2":
                    new ReflectJourneySession().Start();
                    break;
                case "3":
                    new GratitudeListSession().Start();
                    break;
                case "4":
                    Console.WriteLine("\nMay your mind stay cosmic. Farewell! ✨");
                    return;
                default:
                    Console.WriteLine("Invalid orbit. Try again!");
                    break;
            }
        }
    }
}

// In summary, the Mindfulness Project offers a variety of sessions to help 
// users cultivate mindfulness and self-awareness.