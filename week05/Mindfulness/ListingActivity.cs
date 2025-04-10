using System.Collections.Generic;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name)
        :base(name)
    {
        _prompts = new List<string>();
        
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine($"You listed {GetListCount()} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random randomNumber = new Random();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        int index = randomNumber.Next(1,_prompts.Count);
        string myPrompt = _prompts[index];
        Console.WriteLine($"---{myPrompt}---");

    }

    public List<string> GetListFromUser()
    {
        List<string> userInputs = new List<string>();

        int duration = GetDuration();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while(DateTime.Now < endTime)
        // while(true)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }
                

            userInputs.Add(input);
            
        }
        return userInputs;
    }

    public int GetListCount()
    {
        _count = GetListFromUser().Count;
        return _count;
    }

}

