class Menu
{
    public int ProcessMenu()
    {

        int input = 0;

        while (input < 1 || input > 5)
        {
            // New code I added!
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("       MY JOURNAL");
            Console.WriteLine("-----------------------------");
            Console.ResetColor();

            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save, or Read Journal Entries");
            Console.WriteLine("");
            Console.WriteLine("1. Create new journal entry. ");
            Console.WriteLine("2. Display all journal entries. ");
            Console.WriteLine("3. Save journal to file. ");
            Console.WriteLine("4. Read Journal from file. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. Quit. ");
            Console.ResetColor();
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
    public void PauseForUser()
    {
        Console.WriteLine();
        Console.Write("Press Enter to return to the menu...");
        Console.ReadLine();
    }
}