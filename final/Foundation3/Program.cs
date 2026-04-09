using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "Boise", "ID", "USA");
        Address addr2 = new Address("456 Center St", "Salt Lake", "UT", "USA");
        Address addr3 = new Address("789 Park Ave", "Denver", "CO", "USA");

        Lecture lecture = new Lecture(
            "Tech Talk",
            "Learn about AI",
            "May 1",
            "10:00 AM",
            addr1,
            "Dr. Smith",
            100
        );

        Reception reception = new Reception(
            "Networking Night",
            "Meet professionals",
            "May 2",
            "6:00 PM",
            addr2,
            "rsvp@event.com"
        );

        Outdoor outdoor = new Outdoor(
            "Summer Picnic",
            "Food and games outside",
            "May 3",
            "12:00 PM",
            addr3,
            "Sunny"
        );

        Console.WriteLine("=== Lecture ===");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription("Lecture"));
        Console.WriteLine();

        Console.WriteLine("=== Reception ===");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription("Reception"));
        Console.WriteLine();

        Console.WriteLine("=== Outdoor ===");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDescription("Outdoor"));
    }
}