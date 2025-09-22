using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        do
        {
            Random randomGenerator = new Random();
            int generatedNumber = randomGenerator.Next(1, 101);
            int userNumber;
            int iterationCount = 0;

            do
            {
                iterationCount += 1;
                Console.Write("Guess the magic number between 1 and 100: ");
                string userInput = Console.ReadLine();
                userNumber = int.Parse(userInput);
                if (userNumber < generatedNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else if (userNumber > generatedNumber)
                {
                    Console.WriteLine("Too high.");
                }
            } while (userNumber != generatedNumber);

            Console.WriteLine($"Congratulations! You guessed the number in {iterationCount} guesses!");
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain.ToLower() == "yes");
        Console.WriteLine("Thanks for playing!");
    }
}