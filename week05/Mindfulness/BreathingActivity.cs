using System;

public class BreathFlowSession : MindfulSession
{
    public BreathFlowSession()
    {
        _sessionName = "BreathFlow";
        _sessionGuide = "This session will guide you through a simple breathing exercise to help you relax and focus.";
    }


    // This method starts the breathing session, guiding the user through a series of breaths.
    // It uses a countdown timer to manage the duration of the session.
    public override void Start()
    {
        BeginSession();
        DateTime endTime = DateTime.Now.AddSeconds(_timeLimit);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... (hold for 4 seconds)");
            ShowPeacefulCountdown(4);
            Console.WriteLine("Breathe out... (hold for 4 seconds)");
            ShowPeacefulCountdown(4);
        }

        EndSession();
    }
}