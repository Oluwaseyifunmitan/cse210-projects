using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("C# Fundamentals", "John Doe", 480);
        Video video2 = new Video("Understanding Abstraction", "Jane Smith", 600);
        Video video3 = new Video("OOP Concepts Simplified", "Alice Brown", 540);

        // Add comments to video1
        video1.AddComment(new Comment("User1", "This video is amazing!"));
        video1.AddComment(new Comment("User2", "Thanks for the clear explanations."));
        video1.AddComment(new Comment("User3", "Helped me a lot with my project."));

        // Add comments to video2
        video2.AddComment(new Comment("UserA", "Great breakdown of abstraction."));
        video2.AddComment(new Comment("UserB", "Can you make a video on encapsulation?"));
        video2.AddComment(new Comment("UserC", "Really liked the examples."));

        // Add comments to video3
        video3.AddComment(new Comment("UserX", "OOP made simple. Thanks!"));
        video3.AddComment(new Comment("UserY", "I finally understand polymorphism."));
        video3.AddComment(new Comment("UserZ", "Love the analogies used here."));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (var video in videos)
        {
            video.DisplayDetails();
        }
    }
}
