using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine();

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static String PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string stringNumber = Console.ReadLine();
            int number = int.Parse(stringNumber);
            return number;
        }

        static int SquareNumber(int number)
        {
            int sqrNumber = number * number;
            return sqrNumber;
        }

        static void DisplayResult(String userName, int squaredNumber)
        {
            string result = $"{userName}, the square of your number is {squaredNumber}";
            Console.WriteLine(result);
        }

        DisplayWelcome();
        String userName = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(userName, squaredNumber);
        
    }
}