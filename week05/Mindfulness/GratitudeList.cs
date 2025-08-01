using System;
using System.Collections.Generic;

public class GratitudeListSession : MindfulSession
{
    private List<string> _joyPrompts = new List<string>
    {
        "What is one thing that made you smile today?",
        "Reflect on a moment of kindness you experienced this week.",
        "What is something beautiful you saw recently?",
    };

    private int _blessingCount;

    public GratitudeListSession()
    {
        _sessionGuide = "This session will guide you through a gratitude exercise to help you appreciate the positive aspects of your life.";
        _sessionName = "Gratitude List";
    }

    public override void Start()
    {
        BeginSession();
        Console.WriteLine($"{GetRandomPrompt()}");
        ShowPeacefulCountdown(3);

        List<string> blessings = GatherBlessings();
        _blessingCount = blessings.Count;

        Console.WriteLine($"\nYou have listed {_blessingCount} things you are grateful for.");
        EndSession();
    }

    private string GetRandomPrompt() => _joyPrompts[new Random().Next(_joyPrompts.Count)];

    private List<string> GatherBlessings()
    {
        List<string> blessings = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_timeLimit);

        Console.WriteLine("\n(Start listing. Press Enter after each item.)");
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            blessings.Add(Console.ReadLine());
        }

        return blessings;
    }


}