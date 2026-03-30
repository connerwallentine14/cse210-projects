using System;
using System.Collections.Generic;

// Comment class
public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}

// Video class
public class Video
{
    private string _title;
    private string _author;
    private int _length; // seconds
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (Comment c in _comments)
        {
            Console.WriteLine($"- {c.GetName()}: {c.GetText()}");
        }

        Console.WriteLine();
    }
}
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