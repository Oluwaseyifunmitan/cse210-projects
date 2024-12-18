public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; set; }
    public int CurrentCompletions { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int requiredCompletions, int bonusPoints)
        : base(name, points)
    {
        RequiredCompletions = requiredCompletions;
        BonusPoints = bonusPoints;
        CurrentCompletions = 0;
    }

    public override void RecordEvent(ref int totalScore)
    {
        if (CurrentCompletions < RequiredCompletions)
        {
            CurrentCompletions++;
            totalScore += Points;
            Console.WriteLine($"Progress recorded for '{Name}'. +{Points} points.");
            if (CurrentCompletions == RequiredCompletions)
            {
                IsComplete = true;
                totalScore += BonusPoints;
                Console.WriteLine($"Goal '{Name}' completed! +{BonusPoints} bonus points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override string DisplayStatus()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} ({CurrentCompletions}/{RequiredCompletions} completions, {Points} points each, {BonusPoints} bonus)";
    }
}