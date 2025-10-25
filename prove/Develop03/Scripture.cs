namespace Develop03;

public class Scripture
{
    private string _verse;
    private List<string> _verseList = new List<string>();
    private int _verseLength;
    public Scripture(string verse)
    {
        _verse = verse;
        foreach (string word in _verse.Split(" "))
        {
            _verseList.Add(word);
            _verseLength = _verseList.Count();
        }
    }
    private WordModifier _blanker = new WordModifier();
    public void ChangeWord()
    {
        Random _wordSelector = new Random();
        bool _isNotBlanked = true;
        while (_isNotBlanked)
        {
            int _wordIndex = _wordSelector.Next(_verseList.Count());
            string _selectedWord = _verseList[_wordIndex];
            if (_verseList[_wordIndex].Contains("_") == false)
            {
                _verseList[_wordIndex] = _blanker.WordChanger(_selectedWord);
                _isNotBlanked = false;
            }
        }
    }
    public void DisplayVerse()
    {
        foreach (string item in _verseList)
        {
            Console.Write(item + " ");
        }
    }
    public int GetVerseLength() { return _verseLength; }
}
