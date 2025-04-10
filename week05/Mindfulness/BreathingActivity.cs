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
        
        string bIn = "Breathe in...";
        string bOut = "Now Breathe out...";

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(bIn);
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write(bOut);
            ShowCountDown(4);
            Console.WriteLine();
            Console.WriteLine();
        }
        DisplayEndingMessage();

    }
}