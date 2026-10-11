class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry() { }

    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void DisplayJournalEntry() //*Final code
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry() 
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "What was the highlight and low of your day?",
            "What emotions did you feel today?",
            "Whats one thing you wished you did today?"
        };
        _date = DateTime.Now.ToString();
        Random random = new Random();
        _prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }
}