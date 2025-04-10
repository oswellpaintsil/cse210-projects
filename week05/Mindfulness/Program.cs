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
            
            BreathingActivity bAct = new BreathingActivity("Breathing");
            bAct.SetDescription("This activity will help you relax by walking you " +
            "through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.Clear();
            bAct.DisplayStartingMessage();
            int duration = int.Parse(Console.ReadLine());
            bAct.SetDuration(duration);
            Console.Clear();
            bAct.Run();
           
        }

        else if (response == 2)
        {
            ReflectingActivity rAct = new ReflectingActivity("Reflecting");
            rAct.SetDescription("This activity will help you reflect on times in your " +
            "life when you have shown strength and resilience. This will help you " +
            " recognize the power you have and how you can use it in other aspects of your life.");
            Console.Clear();
            rAct.DisplayStartingMessage();
            int duration = int.Parse(Console.ReadLine());
            rAct.SetDuration(duration);
            rAct.DisplayPrompt();
            rAct.DisplayQuestion();
            rAct.Run();

        }

        else if (response == 3)
        {
            ListingActivity lAct = new ListingActivity("Listing");
            lAct.SetDescription("This activity will help you reflect on the " +
            "good things in your life by having you list as many things as " +
            " you can in a certain area.");
            Console.Clear();
            lAct.DisplayStartingMessage();
            int duration = int.Parse(Console.ReadLine());
            lAct.SetDuration(duration);
            // Console.WriteLine(duration);
            lAct.Run();
            // lAct.GetListFromUser();
        }

        } while (response != 4);
    }
}