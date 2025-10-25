using System;
using Develop03;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureRef = new Reference("1 Nephi", 3, 7);
        Console.WriteLine(scriptureRef.GetReference());
        Scripture verse = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        string userInput = "yes";
        int verseLength = verse.GetVerseLength();
        while (userInput == "yes")
        {
            for (int i = 0; i <= 5; i++)
            {
                verseLength -= 1;
                if (verseLength < 0)
                {
                    Console.WriteLine("Cannot remove more words. Type 'quit' to exit");
                    break;
                }
                else
                {
                    verse.ChangeWord();
                }
            }
            if (verseLength > 0)
            {
                verse.DisplayVerse();
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Would you like to continue? ");
            }
            userInput = Console.ReadLine();
        }
    }
}