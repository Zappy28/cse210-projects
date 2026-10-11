using System;

//The exceeding requirements feature that I implemented was making the UI much
//more readable. I made it so that the console does not keep filling up with
//all the old outputs, but clears after very one. To make sure the user sees
//what they inputted, I also added a pause function so it doesn't immediately 
//clear the console. Finally, I added different colors to the menu screen.

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Journal myJournal = new Journal();


        int response = 0;
        
        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch (response)
            {
                case 1:
                    myJournal.CreateEntry(); 
                    break;
                case 2:
                    myJournal.DisplayJournal(); 
                    break;
                case 3:
                    Console.Write("What filename do you want to save to? ");
                    string saveName = Console.ReadLine();
                    myJournal.WriteToFile(saveName);
                    break;
                case 4:
                    Console.Write("What filename do you want to load from? ");
                    string loadName = Console.ReadLine();
                    myJournal.ReadFromFile(loadName);
                    break;
            }
            if (response != 5)
            {
                myMenu.PauseForUser();
            }
        }

        
    }
}