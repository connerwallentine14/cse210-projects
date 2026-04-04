using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address addr2 = new Address("456 Center Rd", "Boise", "ID", "USA");
        Address addr3 = new Address("789 Park Ave", "Salt Lake City", "UT", "USA");

        events.Add(new Lecture("C# Basics", "Learn the fundamentals of C#", "April 10", "10:00 AM", addr1, "John Doe", 50));
        events.Add(new Reception("Networking Night", "Meet professionals", "April 12", "6:00 PM", addr2, "rsvp@email.com"));
        events.Add(new Outdoor("Summer Festival", "Enjoy music and food", "June 5", "2:00 PM", addr3, "Sunny with light breeze"));

        foreach (Event e in events)
        {
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(e.GetStandardDetails());

            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(e.GetFullDetails());

            Console.WriteLine("\nSHORT DESCRIPTION:");
            Console.WriteLine(e.GetShortDescription());

            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}