using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private string [] _prompts = {"Think of a time when you did something really difficult.", "Think about a time in your mission that was really hard to you.", "Think about a time when someone hurt you."};
    
    private string [] _questions = {"How did you feel when it was complete?", "Why do you remember that it was difficult for you?", "How Do you feel respect this event currently?", "What is your favorite thing about this experience?"};
    
    public ReflectingActivity(string activityName, string description) : base(activityName, description)
    {
    }

    public ReflectingActivity(int duration, string activityName) : base(duration, activityName)
    {
    }

    public void GetPrompt()
    {
        Random rnd = new Random();
       
        int index = rnd.Next(_prompts.Length);
        string finalPrompt = _prompts[index];

        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine(" --- " + finalPrompt + " --- ");
        Console.WriteLine("When you have something in mind, press enter to continue: ");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");

        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
        Console.Clear();

    }

    public void GetReflect()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(30);

        while (DateTime.Now < endTime)
        {
            Random rnd = new Random();
            int index = rnd.Next(_questions.Length);
            string finalq = _questions[index];

            Console.WriteLine("> " + finalq + " ");

            for (int i = 12; i > 0; i--)
            {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
        }
    }
}