namespace Develop02;

public class Entry
{
    static List<string> _promptList = new List<string>() //Initialize the prompt list with 10 prompts
    {
    "How do you feel about the weather today?",
    "What is something kind that a stranger did for you today?",
    "What is something kind that you did for a stranger today?",
    "How did you see God answer today's prayers?",
    "If you could have eaten one more food item today, what would it be and why?",
    "What was the most beautiful not person you saw today?",
    "If you were to compare today to a song, what song would it be?",
    "Were you joyful today? Could the people you met see the same?",
    "What have you already repented of today?",
    "Which Star Wars character did you most act like today?"
    };

    public string _date = DateTime.Now.ToShortDateString(); //Automatically pulls the date from the user's computer
    public Entry() { }
    public string GivePrompt()
    {
        Random _promptSelector = new Random(); //Create a new randomizer (used Copilot to understand how this works)
        int _promptIndex = _promptSelector.Next(_promptList.Count());
        string _promptSelected = _promptList[_promptIndex];
        Console.Write($"{_promptSelected} ");
        return _promptSelected; //Return the selected prompt so it can be stored.
    }
    public string CreateJournalEntry()
    {
        string prompt = GivePrompt();
        string response = Console.ReadLine();
        string FullEntry = $"{_date} - {prompt}\n{response}"; //Save all the info in journal format
        return FullEntry;
    }
}
