using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        String StringGradePercentage = Console.ReadLine();
        int NumberGradePercentage = int.Parse(StringGradePercentage);
        String letter;

        if (NumberGradePercentage >= 90)
        {
            letter = "A";
        }

        else if (NumberGradePercentage >= 80 && NumberGradePercentage < 90)
        {
            letter = "B";
        }

        else if (NumberGradePercentage >= 70 && NumberGradePercentage < 80)
        {
            letter = "C";
        }
        else if (NumberGradePercentage >= 60 && NumberGradePercentage < 70)
        {
            letter = "D";
        }
        else
        {
           letter = "F";
        }

        Console.WriteLine($"Your letter grade for this course is {letter}");
        
        if (NumberGradePercentage >= 70)
        {
            Console.WriteLine("Congratulations!! You passed the class.");
        }
        else
        {
            Console.WriteLine("You failed this class, but there is more room for improvement.");
        }
    }
}