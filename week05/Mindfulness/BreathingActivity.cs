public class BreathingActivity : Activity
{
    public BreathingActivity(string name)
        :base(name)
    {
        
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        
        string breatheIn = "Breathe in...";
        string breatheOut = "Now Breathe out...";

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(breatheIn);
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write(breatheOut);
            ShowCountDown(4);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();

    }
}