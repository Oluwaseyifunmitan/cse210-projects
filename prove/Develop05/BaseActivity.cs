using System;
using System.Threading;

public abstract class Activity
{
   
private string _name;
    private string _description;
    protected int Duration;

    protected string Name { get => _name; set => _name = value; }
    protected string Description { get => _description; set => _description = value; }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name} Activity\n");
        Console.WriteLine(Description);
        Console.Write("Enter the duration in seconds: ");
        Duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine("\nPrepare to begin...");
        PauseWithAnimation(3);
        PerformActivity(Duration);
        End();
    }

    protected abstract void PerformActivity(int duration);

    protected void PauseWithAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 10; i++)
        {
            Console.Write($"{spinner[i % spinner.Length]}\r");
            Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    protected void End()
    {
        Console.WriteLine("\nGood job!");
        Console.WriteLine($"You have completed the {Name} Activity for {Duration} seconds.");
        PauseWithAnimation(3);
    }
}