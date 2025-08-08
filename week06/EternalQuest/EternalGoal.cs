// EternalGoal.cs
namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) 
            : base(name, description, points) { }

        public override void RecordEvent()
        {
            // Points are awarded each time but goal is never complete
        }

        public override bool IsComplete() => false;

        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} [∞]";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal|{_shortName}|{_description}|{_points}";
        }
    }
}