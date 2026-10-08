class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    
    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries) 
        {
            entry.DisplayJournalEntry(); //* Goes through each entry and displays it
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);

    }
}