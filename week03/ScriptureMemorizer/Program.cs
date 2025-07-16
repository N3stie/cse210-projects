using System;

class Program
{
    static void Main(string[] args)
    {
        // using the reference class to create a reference for the scripture.
        
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // I create a list of sciptures to use a library of scriptures.
        List<Scripture> scripturesLibrary = new List<Scripture>();
        scripturesLibrary.Add(scripture);
        scripturesLibrary.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

        Random rand = new Random();
        Scripture currentScripture = scripturesLibrary[rand.Next(scripturesLibrary.Count)];

        // i use the while true loop to keep the program running until the user decides to quit or all words are hidden.
        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit" || currentScripture.IsCompletelyHidden())
            {
                break;
            }

            currentScripture.HideRandomWords(3); // It will hide 3 random words each pressing the Enter key
        }
    }
}