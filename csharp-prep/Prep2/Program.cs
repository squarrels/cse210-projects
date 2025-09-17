using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string gradeFromUser = Console.ReadLine();
        int gradeValue = int.Parse(gradeFromUser);

        string gradeLetter = "";
        if (gradeValue >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeValue >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeValue >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeValue >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        string gradeSign = "";
        if (gradeValue < 95 && gradeValue >= 60)
        {
            int signDeterminer = gradeValue % 10;
            if (signDeterminer >= 7)
            {
                gradeSign = "+";
            }
            else if (signDeterminer < 3)
            {
                gradeSign = "-";
            }
        }

        Console.WriteLine($"Your grade is {gradeLetter}{gradeSign}.");
    }
}