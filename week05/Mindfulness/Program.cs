using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();
        Menu myMenu = new Menu();
        
        int response;

       do 
       {
       
        myMenu.MenuOptions();
        response = myMenu.GetResponse();


       if (response == 1)
        {
            
            BreathingActivity breathing = new BreathingActivity("Breathing");
            breathing.SetDescription("This activity will help you relax by walking you " +
            "through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.Clear();
            breathing.DisplayStartingMessage();
            int duration = int.Parse(Console.ReadLine());
            breathing.SetDuration(duration);
            Console.Clear();
            breathing.Run();
           
        }

        else if (response == 2)
        {
            ReflectingActivity reflecting = new ReflectingActivity("Reflecting");
            reflecting.SetDescription("This activity will help you reflect on times in your " +
            "life when you have shown strength and resilience. This will help you " +
            " recognize the power you have and how you can use it in other aspects of your life.");
            Console.Clear();
            reflecting.DisplayStartingMessage();
            int duration = int.Parse(Console.ReadLine());
            reflecting.SetDuration(duration);
            reflecting.DisplayPrompt();
            reflecting.DisplayQuestion();
            reflecting.Run();

        }

        else if (response == 3)
        {
            ListingActivity listing = new ListingActivity("Listing");
            listing.SetDescription("This activity will help you reflect on the " +
            "good things in your life by having you list as many things as " +
            " you can in a certain area.");
            Console.Clear();
            listing.DisplayStartingMessage();
            int duration = int.Parse(Console.ReadLine());
            listing.SetDuration(duration);
            // Console.WriteLine(duration);
            listing.Run();
            // lAct.GetListFromUser();
        }

        } while (response != 4);
    }
}