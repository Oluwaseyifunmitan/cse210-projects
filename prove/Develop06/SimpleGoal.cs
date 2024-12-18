public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int totalScore)
    {
        if (!IsComplete)
        {
            IsComplete = true;
            totalScore += Points;
            Console.WriteLine($"Goal '{Name}' completed! +{Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override string DisplayStatus()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} ({Points} points)";
    }
}