using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        List<string> journalEntries = new List<string>();
        Console.WriteLine("Welcome to your digital journal!");
        int selectedOption = 0;
        while (selectedOption != 5)
        {
            Console.WriteLine("You can:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View all written entries");
            Console.WriteLine("3. Save your journal");
            Console.WriteLine("4. Load a journal");
            Console.WriteLine("5. Quit");
            Console.Write("Which do you choose? ");
            selectedOption = int.Parse(Console.ReadLine());

            if (selectedOption == 1)
            {
                Entry newEntry = new Entry();
                string currentEntry = newEntry.CreateJournalEntry();
                journalEntries.Add(currentEntry);
            }
            else if (selectedOption == 2)
            {
                foreach (string entry in journalEntries)
                {
                    Console.WriteLine(entry);
                    Console.WriteLine();
                }
            }
            else if (selectedOption == 3)
            {
                
            }
            else if (selectedOption == 4)
            {

            }
        }
    }

}