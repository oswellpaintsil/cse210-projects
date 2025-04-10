public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name)
    {
        _name = name;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(8);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(8);
        Console.Clear();
        
    }

    public void ShowSpinner(int second)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);

        List<string> spinObjects = new List<string>() {"|","/","—","|","/","—","\\"};
        
        int i = 0;
        while(DateTime.Now < endTime)
        {
            string s = spinObjects[i];

            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinObjects.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }
}
