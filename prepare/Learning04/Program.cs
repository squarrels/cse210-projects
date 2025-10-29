using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment("Mr. President", "C# Programming");
        Console.WriteLine(homework.GetSummary());

        MathAssignment calculus = new MathAssignment("John Cena", "Derivatives", "3.2", "1,7,9-11,15");
        Console.WriteLine(calculus.GetHomeworkList());
        Console.WriteLine(calculus.GetSummary());

        WritingAssignment essay = new WritingAssignment("Mary Jane", "Persuasive Synthesis", "The Horrors of Horror");
        Console.WriteLine(essay.GetWritingInformation());
        Console.WriteLine(essay.GetSummary());
    }
}