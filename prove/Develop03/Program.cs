using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = LoadRandomScripture("scriptures.json");

        bool isAllHidden = false;

        while (!isAllHidden)
        {
            Console.Clear();
            myScripture.ShowScripture();

            Console.WriteLine("\nPress Enter to Continue or 'quit' to exit. ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return; 
            }

            isAllHidden = myScripture.HideSomeWords();
        }

        Console.Clear();
        myScripture.ShowScripture();

    }

    static Scripture LoadRandomScripture(string fileName)
    {
        // !Had to use google for the JSON specific syntax and how to load the file!
        string path = Path.Combine(AppContext.BaseDirectory, fileName);
        string json = File.ReadAllText(path);
        List<ScriptureEntry>? entries = JsonSerializer.Deserialize<List<ScriptureEntry>>(json);

        if (entries == null || entries.Count == 0)
        {
            throw new InvalidOperationException("No scriptures found in " + fileName);
        }

        Random random = new Random();
        ScriptureEntry pick = entries[random.Next(entries.Count)];

        
        return new Scripture(pick.Book, pick.Chapter, pick.Verse, pick.Quote);
    }
}