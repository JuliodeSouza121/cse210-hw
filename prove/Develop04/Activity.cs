using System.Threading.Tasks.Dataflow;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration; 

   
    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public Activity(int duration, string activityName)
    {
        _duration = duration;
        _activityName = activityName;
    }

    public string GetNameActivity()
    {
        string activity = "Welcome to the " + _activityName;

        return activity;

    }

    public string GetDescriptionActivity()
    {
        return _description;
    }

    public int GetDurationActivity()
    {
         int miliseconds = _duration * 1000;
         return miliseconds; 
    }

    public void GetStart()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");  
    }

    public void SpinerAnimation()
    {
        List <string> frames = new List<string>();
        frames.Add("|");
        frames.Add("/");
        frames.Add("―");
        frames.Add("\\");
        frames.Add("|");
        frames.Add("/");
        frames.Add("―");
        frames.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = frames[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= frames.Count)
            {
                i = 0;
            }
        }

    }
    public void GetEnd()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!!");
        Console.WriteLine("");
        SpinerAnimation();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}.");
        SpinerAnimation();
    }


}