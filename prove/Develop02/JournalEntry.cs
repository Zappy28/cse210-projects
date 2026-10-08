class JournalEntry()
{
    public string _date;
    public string _prompt;
    public string _response;

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
            "Talk about someone you met."
        };
        _date = DateTime.Now.ToString();
        _prompt = prompts[0]; //!Come back to replace with list of prompts
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }
}