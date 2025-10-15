using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction blank = new Fraction();
        Fraction whole = new Fraction(6);
        Fraction part = new Fraction(6, 7);

        Console.WriteLine(blank.GetDecimalValue());
        Console.WriteLine(blank.GetFractionString());
        Console.WriteLine(whole.GetFractionString());
        Console.WriteLine(whole.GetDecimalValue());
        Console.WriteLine(part.GetFractionString());
        Console.WriteLine(part.GetDecimalValue());
    }
}