using System.Collections.Generic;
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name)
        :base(name)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public void Run()
    {
        int duration = GetDuration();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(5);

        while(DateTime.Now < endTime)
            {
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            DisplayPrompt();
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.Write("Now ponder on each of the following questions as they are related to this expression.\nYou may begin in: ");
            ShowCountDown(8);
            Console.Clear();
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
            Console.WriteLine();
            }
            DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random randomNumber = new Random();
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        int index = randomNumber.Next(1,_prompts.Count);
        string myPrompt = _prompts[index];

        return myPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randomQuestion = new Random();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        int index = randomQuestion.Next(1,_questions.Count);
        string myQuestion = _questions[index];

        return myQuestion;
        
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}