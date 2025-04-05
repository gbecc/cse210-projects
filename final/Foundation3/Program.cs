using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Lecture Ln", "Boston", "MA", "USA");
        Address address2 = new Address("500 Party St", "New York", "NY", "USA");
        Address address3 = new Address("Central Park", "New York", "NY", "USA");

        // Create events
        Lecture lecture = new Lecture("Benefit of Having Cats", "Discussion on the benefits of owning cats.", "Nov 15, 2025", "10:00 AM", address1, "Dr. Khat Lhadee", 100);
        Reception reception = new Reception("Company Gala", "Annual networking event.", "Dec 5, 2025", "7:00 PM", address2, "rsvp@company.com");
        OutdoorGathering picnic = new OutdoorGathering("Autumn Festival", "Music and food in the park.", "Oct 22, 2025", "2:00 PM", address3, "Sunny with light breeze");

        // List of events
        List<Event> events = new List<Event> { lecture, reception, picnic };

        // Display marketing messages
        foreach (Event ev in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\n----- Full Details -----");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\n----- Short Description -----");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n----------------------------\n");
        }
    }
}
