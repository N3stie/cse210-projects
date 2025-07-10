using System;
using System.Collections.Generic;

// This class generates random prompts for the journal entries.
// It contains a list of prompts and a method to get a random prompt.
// in short, it provides a way to retrieve a prompt for the user to respond to.

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn today that I didn’t know yesterday?",
        "Describe a moment you felt proud of yourself today."
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
