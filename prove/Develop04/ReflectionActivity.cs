using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on times in your life when you have shown strength.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("Reflect on the following questions:");

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}