using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?"
    };

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many items as you can in a certain area.";
    }

    protected override void PerformActivity(int duration)
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}\n");
        PauseWithAnimation(5);

        Console.WriteLine("Start listing your items (type 'done' to finish early):");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string? item = Console.ReadLine();
            if (item?.ToLower() == "done") break;
            count++;
        }

        Console.WriteLine($"You listed {count} items.\n");
    }
}
