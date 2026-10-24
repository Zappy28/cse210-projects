class Scripture
{
    private List<Word> _words = new List<Word>();
    private ScriptureReference _reference;
    private Random _random = new Random();

    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(name, chapter, verse);
        _words = ConvertToWordList(text);
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse);
        _words = ConvertToWordList(text);
    }

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWordList(text);
    }

    public bool HideSomeWords()
    {
        List<Word> visible = new List<Word>();
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                visible.Add(word);
            }
        }

        for(int i = 0; i < 3 && visible.Count > 0; i++)
        {
            int index = _random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
        return NumberOfHiddenWords() == _words.Count;
    }

    public void ShowScripture()
    {
        _reference.DisplayScriptureReference();
        foreach(Word word in _words)
        {
            word.DisplayWord();
        }
        Console.WriteLine();
    }

    public string GetScriptureReference()
    {
        return _reference.GetScriptureReference();
    }

    private int NumberOfHiddenWords()
    {
        int count = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> list = new List<Word>();
        foreach (string w in text.Split(" "))
        {
            list.Add(new Word(w));
        }
        return list;
    }
}