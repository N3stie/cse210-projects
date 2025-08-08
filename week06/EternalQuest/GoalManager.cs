// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;
        private int _level = 1;

        public void Start()
        {
            while (true)
            {
                Console.Clear();
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": SaveGoals(); break;
                    case "4": LoadGoals(); break;
                    case "5": RecordEvent(); break;
                    case "6": return;
                    default: Console.WriteLine("Invalid option"); break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        private void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score} (Level {_level})");
        }

        private void CreateGoal()
        {
            Console.WriteLine("\nGoal Types:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Select goal type: ");
            
            string type = Console.ReadLine();
            string name = GetInput("Enter goal name: ");
            string desc = GetInput("Enter description: ");
            int points = GetIntInput("Enter points: ", 0);

            switch (type)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, desc, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, desc, points));
                    break;
                case "3":
                    int target = GetIntInput("Enter target count: ", 1);
                    int bonus = GetIntInput("Enter bonus points: ", 0);
                    _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type");
                    break;
            }
        }

        private void ListGoalDetails()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("\nNo goals created yet.");
                return;
            }

            Console.WriteLine("\nGoal Details:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i].GetDetailsString()}");
            }
        }

        private void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("\nNo goals available to record.");
                return;
            }

            ListGoalNames();
            int index = GetIntInput("Select goal to record: ", 1, _goals.Count) - 1;
            
            _goals[index].RecordEvent();
            int earnedPoints = _goals[index].GetPoints();
            _score += earnedPoints;
            CheckLevelUp();
            Console.WriteLine($"\nEvent recorded! +{earnedPoints} points");
            
            if (_goals[index] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                Console.WriteLine($"Bonus achieved! Total points for this goal: {earnedPoints}");
            }
        }

        private void ListGoalNames()
        {
            Console.WriteLine("\nGoals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
            }
        }

        private void SaveGoals()
        {
            string filename = GetInput("Enter filename to save (default: goals.txt): ");
            if (string.IsNullOrWhiteSpace(filename))
            {
                filename = "goals.txt";
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(_score);
                    foreach (Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }
                Console.WriteLine($"Goals saved successfully to {filename}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving goals: {ex.Message}");
            }
        }

        private void LoadGoals()
        {
            string filename = GetInput("Enter filename to load (default: goals.txt): ");
            if (string.IsNullOrWhiteSpace(filename))
            {
                filename = "goals.txt";
            }

            if (!File.Exists(filename))
            {
                Console.WriteLine($"File not found: {filename}");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filename);
                if (lines.Length == 0)
                {
                    Console.WriteLine("Empty file");
                    return;
                }

                _score = int.Parse(lines[0]);
                _goals.Clear();

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (parts.Length < 4) continue;

                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            if (parts.Length > 4 && bool.Parse(parts[4]))
                            {
                                simpleGoal.RecordEvent();
                            }
                            _goals.Add(simpleGoal);
                            break;
                            
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;

                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(
                                parts[1], parts[2],
                                int.Parse(parts[3]),
                                int.Parse(parts[5]),
                                int.Parse(parts[4]));
                            NewMethod(parts, checklistGoal);
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
                Console.WriteLine($"Goals loaded successfully from {filename}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading goals: {ex.Message}");
                _goals.Clear();
                _score = 0;
            }
        }

        private static void NewMethod(string[] parts, ChecklistGoal checklistGoal)
        {

            
            checklistGoal.SetCompletionCount(int.Parse(parts[6]));
        }

        private void CheckLevelUp()
        {
            int newLevel = _score / 1000 + 1;
            if (newLevel > _level)
            {
                Console.WriteLine($"\nLEVEL UP! You reached level {newLevel}!");
                _level = newLevel;
            }
        }

        private string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine()?.Trim() ?? string.Empty;
        }

        private int GetIntInput(string prompt, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int result) && 
                    result >= minValue && result <= maxValue)
                {
                    return result;
                }
                Console.WriteLine($"Please enter a number between {minValue} and {maxValue}");
            }
        }
    }
}