using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();

        int number;
        String userNumber;
        List<int>numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            
            if (number != 0)
            {
                numberList.Add(number);
            }
            
        } while (number != 0);

        if (numberList.Count != 0)
        {
            int sum = numberList.Sum();
            Double average = numberList.Average();
            int maxNumber = numberList.Max();
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
        else
        {
            Console.WriteLine("The list is empty!");
        }

    }
}