using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}