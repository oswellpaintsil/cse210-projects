using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.WriteLine();

        var aFraction = new Fractions();
        var myFraction = new Fractions(5);
        var theFraction = new Fractions(3,4);

        Console.WriteLine(aFraction.GetFractionString());
        Console.WriteLine(aFraction.GetTop());
        aFraction.SetTop(5);
        Console.WriteLine(aFraction.GetFractionString());
        Console.WriteLine(myFraction.GetTop());
        Console.WriteLine(theFraction.GetFractionString());
        Console.WriteLine(theFraction.GetDecimalValue());
        theFraction.SetTop(1);
        theFraction.SetBottom(3);
        Console.WriteLine(theFraction.GetFractionString());
        Console.WriteLine(theFraction.GetDecimalValue());

    }
}