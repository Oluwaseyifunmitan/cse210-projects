public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent(ref int totalScore)
    {
        totalScore += Points;
        Console.WriteLine($"Recorded progress for '{Name}'. +{Points} points.");
    }

    public override string DisplayStatus()
    {
        return $"[ ] {Name} ({Points} points each time)";
    }
}
