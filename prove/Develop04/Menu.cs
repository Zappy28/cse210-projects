class Menu
{
    public int ProcessMenu(int breathingCount,
    int reflectionCount,
    int listingCount)
    {

        int input = 0;

        while (input < 1 || input > 4)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("   Mindfullness program");
            Console.WriteLine("-----------------------------");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"1. Start breathing activity   ({breathingCount} completed)");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"2. Start reflection activity  ({reflectionCount} completed)");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"3. Start listing activity     ({listingCount} completed)");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("4. Quit ");
            Console.ResetColor();

            Console.Write("Select a choice from the menu: ");
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