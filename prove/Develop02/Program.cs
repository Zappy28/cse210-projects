using System;

class Program
{
    static void Main(string[] args)
    {
    // class object  calls constructor
        Menu myMenu = new Menu();

        int response = 0;
        
        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    Console.WriteLine("Create");
                    // Call CreateJournalEntry()
                    break;
                case 2:
                    Console.WriteLine("Display");
                    // Call DisplayJournal()
                    break;
                case 3:
                    Console.WriteLine("Save");
                    // Call ReadFromFile()
                    break;
                case 4:
                    Console.WriteLine("Write");
                    // Call WriteToFile()
                    break;
            }
        }

        
    }
}