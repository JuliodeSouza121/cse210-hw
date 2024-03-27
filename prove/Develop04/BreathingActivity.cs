public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    public BreathingActivity(int duration, string activityName) : base(duration, activityName)
    {
    }

    public void GetBreath()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        while (DateTime.Now < endTime)
        {
        Console.WriteLine("");
        Console.Write("Breath in...");
        
        for ( int i = 5; i > 0; i--)
        {
            
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("");
        Console.Write("Now breath out...");
        
        for ( int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("");

        }
    }
   
}