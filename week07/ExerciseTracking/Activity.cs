using System;

// will use this as my base class
public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance(); // setting as a km
    public abstract double GetSpeed(); // Will use it as Kph
    public abstract double GetPace(); // this will be the min per km

    public virtual string GetSummary()
    {
        return $"{Date}{GetType().Name}{Minutes}min): " +
                $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";

    }
}