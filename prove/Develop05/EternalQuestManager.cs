using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace EternalQuest
{
    class EternalQuestManager
    {
        private List<Goal> goals;
        private int score;

        public EternalQuestManager()
        {
            goals = new List<Goal>();
            score = 0;
        }

        public void AddSimpleGoal(string name, int points)
        {
            goals.Add(new SimpleGoal(name, points));
        }

        public void AddEternalGoal(string name, int points)
        {
            goals.Add(new EternalGoal(name, points));
        }

        public void AddChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        {
            goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
        }

        public void RecordEvent(string goalName)
        {
            foreach (var goal in goals)
            {
                if (goal.Name == goalName)
                {
                    int pointsGained = goal.Complete();
                    score += pointsGained;

                    // Check if the goal has been completed exactly 10 times
                    if (goal is ChecklistGoal checklistGoal && checklistGoal.CompletedCount == checklistGoal.TargetCount)
                    {
                        Console.WriteLine("Congratulations! You've completed the goal 10 times and earned an extra 200 points!");
                        score += 200; // Extra bonus points
                    }
                    return;
                }
            }
            Console.WriteLine("Goal not found.");
        }

        public void DisplayGoals()
        {
            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Current Score: {score}");
        }

        public void SaveGoals(string filename)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var data = JsonSerializer.Serialize(goals, options);
            File.WriteAllText(filename, data);
        }

        public void LoadGoals(string filename)
        {
            try
            {
                var data = File.ReadAllText(filename);
                var loadedGoals = JsonSerializer.Deserialize<List<Goal>>(data);
                goals.Clear();
                goals.AddRange(loadedGoals);
                Console.WriteLine("Goals loaded successfully.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{filename}' not found.");
            }
            catch (JsonException)
            {
                Console.WriteLine($"Error deserializing '{filename}'.");
            }
        }
    }
}
