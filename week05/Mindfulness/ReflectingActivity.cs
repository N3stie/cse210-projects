using System;
using System.Collections.Generic;


// this sectioion defines the ReflectJourneySession class, which is a type of MindfulSession.
// It provides a structured way for users to reflect on their experiences and gain insights.
public class ReflectJourneySession : MindfulSession
{
    private List<string> _wisdomPrompts = new List<string>
    {
        "What is one lesson you learned this week?",
        "Reflect on a challenge you faced and how you overcame it.",
        "What are you grateful for today?",
    };

    private List<string> _deepQuestions = new List<string>
    {
        "What does success mean to you?",
        "How do you define happiness?",
        "What is your biggest fear and how can you overcome it?",
    };

    public ReflectJourneySession()
    {
        _sessionGuide = "This session will guide you through a reflective journey to deepen your understanding of yourself and your experiences.";
        _sessionName = "Reflective Journey";
    }

    public override void Start()
    {
        BeginSession();
        Console.WriteLine($"{GetRandomPrompt()}");
        ShowZenSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_timeLimit);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"{GetRandomQuestion()}");
            ShowZenSpinner(4);
        }
        EndSession();
    }

    private string GetRandomPrompt() => _wisdomPrompts[new Random().Next(_wisdomPrompts.Count)];
    private string GetRandomQuestion() => _deepQuestions[new Random().Next(_deepQuestions.Count)];
}