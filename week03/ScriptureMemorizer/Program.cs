using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        
        Reference scriptureRef = new Reference("Alma", 37, 37);
        Scripture scripture = new Scripture(scriptureRef, 
            "Counsel with the Lord in all thy doings, and he will direct thee for good; " +
            "yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; " +
            "and when thou risest in the morning let thy heart be full of thanks unto God; " +
            "and if ye do these things, ye shall be lifted up at the last day.");
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are now hidden. Program ending.");
        }
    }

}