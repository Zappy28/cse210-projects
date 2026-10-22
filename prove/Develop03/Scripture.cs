class Scripture
{
    private List<Word> _words = new List<Word>();
    private ScriptureReference _reference;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);

        _words[7].hide();
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.DisplayWord();
        }
    }

    //TODO - Add Constructor for scripture reference
    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(" ");
        foreach (string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }
}