namespace Develop03;

public class WordModifier
{
    private string _word;
    public WordModifier() {

    }
    public string WordChanger(string word)
    {
        _word = word;
        string _newWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            if (char.IsLetter(_word[i]) == true)
            {
                _newWord += "_";
            }
            else
            {
                _newWord += _word[i];
            }
        }
        return _newWord;
    }
}
