using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        int guess;
        int magic;
        
        Random magicNumber = new Random();
        magic = magicNumber.Next(1,100);
        
            // Console.Write("What is the magic number? ");
            // String magicNumber = Console.ReadLine();
        do
        {
            Console.Write("What is your guess? ");
            String guessNumber = Console.ReadLine();

            guess = int.Parse(guessNumber);
            // magic = int.Parse(magicNumber);

            if (guess != magic && guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess != magic && guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magic);
    }
}