using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";

        while (answer != "4")
        {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        answer = Console.ReadLine();
        

        if (answer == "1")
        {
            Console.Clear();
            BreathingActivity _breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in an out slowly, Clear your mind and focus on yout breathing.");
            Console.WriteLine(_breathing.GetNameActivity());
            Console.WriteLine("");
            Console.WriteLine(_breathing.GetDescriptionActivity());
            Console.WriteLine("");
            Console.Write("How long, in seconds, would you like for your session? ");
            string durationst = Console.ReadLine();
            int duration = int.Parse(durationst);
            BreathingActivity _breathing1 = new BreathingActivity(duration, "Breathing Activity");
            _breathing.GetStart();
            _breathing.SpinerAnimation();
            _breathing.GetBreath();
            _breathing1.GetEnd();
        }

        else if (answer == "2")
        {
            Console.Clear();
            ReflectingActivity _reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine(_reflecting.GetNameActivity());
            Console.WriteLine("");
            Console.WriteLine(_reflecting.GetDescriptionActivity());
            Console.WriteLine("");
            Console.Write("How long, in seconds, would you like for your session? ");
            string durationst = Console.ReadLine();
            int duration = int.Parse(durationst);
            ReflectingActivity _reflecting1 = new ReflectingActivity(duration, "Reflecting Activity");
            _reflecting.GetStart();
            _reflecting.SpinerAnimation();
            _reflecting.GetPrompt();
            _reflecting.GetReflect();
            _reflecting1.GetEnd();
        }

        else if (answer == "3")
        {
             Console.Clear();
            ListingActivity _listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in certain area.");
            Console.WriteLine(_listing.GetNameActivity());
            Console.WriteLine("");
            Console.WriteLine(_listing.GetDescriptionActivity());
            Console.WriteLine("");
            Console.Write("How long, in seconds, would you like for your session? ");
            string durationst = Console.ReadLine();
            int duration = int.Parse(durationst);
            ListingActivity _listing1 = new ListingActivity(duration, "Listing Activity");
            _listing.GetStart();
            _listing.GetListingPrompt();
            _listing.GetListing();
            _listing.SpinerAnimation();
            _listing1.GetEnd();
        }

        }
    }
}