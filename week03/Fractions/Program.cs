using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the fraction project");
        // Create fractions using all constructors
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(5); // 5/1
        Fraction fraction3 = new Fraction(3, 4); // 3/4

        // Display initial fractions and their decimal values
        DisplayFraction(fraction1);
        DisplayFraction(fraction2);
        DisplayFraction(fraction3);

        // Test getters and setters
        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine("\nAfter modifying fraction3:");
        DisplayFraction(fraction3);
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine($"{fraction.GetFractionString()} = {fraction.GetDecimalValue()}");
    }
}
