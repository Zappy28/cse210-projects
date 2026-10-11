class Journal
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    
    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entries) 
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);

    }

    public void ReadFromFile(string filename)
    {
        _entries.Clear(); 

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            JournalEntry entry = new JournalEntry(parts[0], parts[1], parts[2]);
            _entries.Add(entry);
        }
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.ToString());
            }
        }
    }
}