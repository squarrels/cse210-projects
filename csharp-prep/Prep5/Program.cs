using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static void PromptUserBirthYear(out int userBirthYear)
    {
        Console.Write("Enter your birth year: ");
        userBirthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber*userNumber;
        return squaredNumber;
    }
    static void DisplayResult(string userName, int squaredNumber, int userBirthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{userName}, this year you will turn {2025 - userBirthYear}.");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        int userBirthYear;
        PromptUserBirthYear(out userBirthYear);
        DisplayResult(userName, squaredNumber, userBirthYear);
    }
}