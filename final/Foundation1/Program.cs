using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Code in C#", "Alice", 600);
        v1.AddComment(new Comment("Bob", "Great tutorial!"));
        v1.AddComment(new Comment("Charlie", "Very helpful."));
        v1.AddComment(new Comment("Diana", "Thanks!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Top 10 Gaming Moments", "GamerGuy", 900);
        v2.AddComment(new Comment("Eve", "Awesome clips!"));
        v2.AddComment(new Comment("Frank", "Loved #3"));
        v2.AddComment(new Comment("Grace", "So funny!"));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Cooking Pasta Like a Pro", "ChefMike", 480);
        v3.AddComment(new Comment("Hank", "Delicious!"));
        v3.AddComment(new Comment("Ivy", "Trying this tonight."));
        v3.AddComment(new Comment("Jack", "Easy to follow."));
        videos.Add(v3);

        // Video 4
        Video v4 = new Video("Car Maintenance Basics", "AutoFix", 720);
        v4.AddComment(new Comment("Kyle", "Very useful."));
        v4.AddComment(new Comment("Liam", "Saved me money."));
        v4.AddComment(new Comment("Mia", "Clear explanation."));
        videos.Add(v4);

        // Display all videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}