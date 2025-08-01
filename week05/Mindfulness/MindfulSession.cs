using System;
using System.Collections.Generic;


public abstract class MindfulSession
{
    protected string _sessionName;
    protected string _sessionGuide;
    protected int _timeLimit;


    public MindfulSession()
    {
        _sessionName = "";
        _sessionGuide = "";
        _timeLimit = 0;
    }

    public void BeginSession()
    {
        Console.WriteLine($"\nStarting {_sessionName} Session...");
        Console.WriteLine(_sessionGuide);
        Console.Write("How long (in seconds) would you like to practice? ");
        _timeLimit = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowZenSpinner(3);

    }

    public void EndSession()
    {
        Console.WriteLine("\nWell done! ");
        Console.WriteLine($"You have completed the {_sessionName} session for {_timeLimit} seconds.");
        ShowZenSpinner(3);
    }

    public void ShowZenSpinner(int seconds)
    {
        // removing the spinner animation for simplicity and focusing on the essence of mindfulness.
        string[] zenSymbols = { ".", ".", ".", ".", "." };
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(zenSymbols[i % zenSymbols.Length]);
            Thread.Sleep(150);
            Console.Write("\b \b");
        }
    }

     // This method simulates a peaceful countdown timer.
     // It counts down from the specified number of seconds, pausing for 1 second between each count.
    public void ShowPeacefulCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public abstract void Start();
}