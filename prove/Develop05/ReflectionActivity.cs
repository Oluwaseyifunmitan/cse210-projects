using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    public ReflectionActivity()
    {
        Name = "Reflection";
        Description = "This activity will help you reflect on times when you have shown strength and resilience.";
    }

    protected override void PerformActivity(int duration)
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}\n");
        PauseWithAnimation(5);

        int timePerQuestion = duration / _questions.Count;
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            PauseWithAnimation(timePerQuestion);
        }
    }
}