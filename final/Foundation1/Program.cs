using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var video1 = new Video("Exploring New Tech Gadgets", "TechGuru", 420);
        video1.AddComment(new Comment("Alice", "Insanely good review!"));
        video1.AddComment(new Comment("Bob", "Where can I buy one?"));
        video1.AddComment(new Comment("Charlie", "I am first!"));

        var video2 = new Video("Top 10 Coding Tips", "mistercoder", 300);
        video2.AddComment(new Comment("Gabriel", "I love this so much."));
        video2.AddComment(new Comment("William", "Well explained!"));
        video2.AddComment(new Comment("Summer", "I love the tip on how to make that youtube video program!"));

        var video3 = new Video("Ultimate Travel Vlog", "TheTravelers", 600);
        video3.AddComment(new Comment("Jon", "So beautiful!"));
        video3.AddComment(new Comment("Henry", "I didn't know Idaho was so cool?!"));
        video3.AddComment(new Comment("Jennifer", "Amazing shots!"));

        var videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
