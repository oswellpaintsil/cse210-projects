using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        
        int response;
        Journal myJournal = new Journal();

        do 
        {
        Entry thisEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        PromptGenerator question = new PromptGenerator();
        string thePrompt = question.GetRandomPrompt();

        Menu myMenu = new Menu();
        myMenu.DisplayMenu();
        response = int.Parse(Console.ReadLine());

        if (response == 1)
        {
            Console.WriteLine(thePrompt);
            Console.Write("> ");
            string userWritenResponse = Console.ReadLine();
            thisEntry._date = dateText;
            thisEntry._promptText = thePrompt;
            thisEntry._entryText = userWritenResponse;
            myJournal.AddEntry(thisEntry); 
        }

        else if (response == 2)
        {
            myJournal.DisplayAll();
        }

        else if (response == 3)
        {
            myJournal.LoadFromFile("myFile.txt");
        }

        else if (response == 4)
        {
            myJournal.SaveToFile("myFile.txt");
        }

        } while (response != 5);
    }   
}