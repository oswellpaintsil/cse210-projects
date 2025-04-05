using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();

        Assignment myAssignment = new Assignment("Oswell Paintsil", "Multiplication");
        MathAssignment ma = new MathAssignment("Roberto Rodriguez", "Fractions","7.3","8-19");
        WritingAssignment wa = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(myAssignment.GetSummary());
        Console.WriteLine();

        Console.WriteLine(ma.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());
        Console.WriteLine();
        
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());
        Console.WriteLine();

    }
}