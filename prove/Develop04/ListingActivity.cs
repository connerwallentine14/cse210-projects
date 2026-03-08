using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List as many positive things as you can.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);

        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        List<string> items = new List<string>();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items!");

        DisplayEndingMessage();
    }
}