using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by guiding you through deep breathing exercises.";
    }

    protected override void PerformActivity(int duration)
    {
        int interval = 5;
        int cycles = duration / (interval * 2);

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(interval);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(interval);
        }
    }
}