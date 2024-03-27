using System.Formats.Asn1;
using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private string [] _listingprompt  = {"When you have you felt the Holy Ghost this month", "When you feel that you did something to help others", "When you were brave in a difficult situation", "When you feel happy today"};
    
    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    public ListingActivity(int duration, string activityName) : base(duration, activityName)
    {   
    }

    public void GetListingPrompt()
    {
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt: ");

        Random rnd = new Random();
       
        int index = rnd.Next(_listingprompt.Length);
        string finalPrompt = _listingprompt[index];

        Console.WriteLine(" --- " + finalPrompt + " --- ");

         Console.Write("You may begin in: ");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.Clear();

    }

    public void GetListing()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(20);

        int count = 0;

        while (DateTime.Now < endTime)
        {
            
            Console.Write(">");
            string answer = Console.ReadLine();
            count = count + 1;
        }

        if (count >= 1)
        {
            Console.WriteLine(" ");
            Console.WriteLine("You listed " + count 
        + " items!");
        }

        else 
        {
            Console.WriteLine(" ");
            Console.WriteLine("You listed " + count 
        + " item!");
        }
        
        
    }
}