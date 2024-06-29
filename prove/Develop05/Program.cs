using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            EternalQuestManager eqManager = new EternalQuestManager();

            while (true)
            {
                Console.WriteLine("\nEternal Quest Program");
                Console.WriteLine("1. Add Simple Goal");
                Console.WriteLine("2. Add Eternal Goal");
                Console.WriteLine("3. Add Checklist Goal");
                Console.WriteLine("4. Record Event");
                Console.WriteLine("5. Display Goals");
                Console.WriteLine("6. Display Score");
                Console.WriteLine("7. Save Goals");
                Console.WriteLine("8. Load Goals");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddSimpleGoal(eqManager);
                        break;
                    case "2":
                        AddEternalGoal(eqManager);
                        break;
                    case "3":
                        AddChecklistGoal(eqManager);
                        break;
                    case "4":
                        RecordEvent(eqManager);
                        break;
                    case "5":
                        eqManager.DisplayGoals();
                        break;
                    case "6":
                        eqManager.DisplayScore();
                        break;
                    case "7":
                        SaveGoals(eqManager);
                        break;
                    case "8":
                        LoadGoals(eqManager);
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddSimpleGoal(EternalQuestManager eqManager)
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points for completing: ");
            int points = int.Parse(Console.ReadLine());
            eqManager.AddSimpleGoal(name, points);
        }

        static void AddEternalGoal(EternalQuestManager eqManager)
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points for each completion: ");
            int points = int.Parse(Console.ReadLine());
            eqManager.AddEternalGoal(name, points);
        }

        static void AddChecklistGoal(EternalQuestManager eqManager)
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points for each completion: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            eqManager.AddChecklistGoal(name, points, targetCount, bonusPoints);
        }

        static void RecordEvent(EternalQuestManager eqManager)
        {
            Console.Write("Enter goal name to record: ");
            string goalName = Console.ReadLine();
            eqManager.RecordEvent(goalName);
        }

        static void SaveGoals(EternalQuestManager eqManager)
        {
            Console.Write("Enter filename to save goals: ");
            string saveFilename = Console.ReadLine();
            eqManager.SaveGoals(saveFilename);
        }

        static void LoadGoals(EternalQuestManager eqManager)
        {
            Console.Write("Enter filename to load goals: ");
            string loadFilename = Console.ReadLine();
            eqManager.LoadGoals(loadFilename);
        }
    }
}