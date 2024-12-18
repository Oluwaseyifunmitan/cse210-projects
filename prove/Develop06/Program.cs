using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordGoalEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine($"Total Score: {totalScore}");
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select Goal Type: 1. Simple 2. Eternal 3. Checklist");
        string goalType = Console.ReadLine();
        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter Required Completions: ");
                int requiredCompletions = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus Points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, requiredCompletions, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordGoalEvent()
    {
        DisplayGoals();
        Console.Write("Select Goal Number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent(ref totalScore);
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    static void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()}");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalScore);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.Points);

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.RequiredCompletions);
                    writer.WriteLine(checklistGoal.CurrentCompletions);
                    writer.WriteLine(checklistGoal.BonusPoints);
                }
            }
        }
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                totalScore = int.Parse(reader.ReadLine());
                goals.Clear();

                while (!reader.EndOfStream)
                {
                    string goalType = reader.ReadLine();
                    string name = reader.ReadLine();
                    int points = int.Parse(reader.ReadLine());

                    if (goalType == "SimpleGoal")
                    {
                        goals.Add(new SimpleGoal(name, points));
                    }
                    else if (goalType == "EternalGoal")
                    {
                        goals.Add(new EternalGoal(name, points));
                    }
                    else if (goalType == "ChecklistGoal")
                    {
                        int requiredCompletions = int.Parse(reader.ReadLine());
                        int currentCompletions = int.Parse(reader.ReadLine());
                        int bonusPoints = int.Parse(reader.ReadLine());
                        var checklistGoal = new ChecklistGoal(name, points, requiredCompletions, bonusPoints)
                        {
                            CurrentCompletions = currentCompletions
                        };
                        goals.Add(checklistGoal);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
