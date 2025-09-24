using System;

class Program
{
    static void Main(string[] args)
    {
        int userNumber;
        List<int> numbers = new List<int>();

        do
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        int sumNumbers = numbers.Sum();
        double aveNumbers = numbers.Average();
        int maxNumber = numbers.Max();

        Console.WriteLine($"The sum of the numbers is {sumNumbers}.\nThe average of the numbers is {aveNumbers}.\nThe largest number is {maxNumber}.");
    }
}