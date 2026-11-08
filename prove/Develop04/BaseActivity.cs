class BaseActivity
{
    
    private string _name;
    private string _Description;
    private int _duration;
    private DateTime _endTime;
    
    //Constructor
    public BaseActivity(string name, string description)
    {
        _name = name;
        _Description = description;
        _duration = 0;
    }

    //-----------------------------------------

    public void StartActivity()
    {
        //TODO - Display what the activity is / welcome message
        Console.Clear();

        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(); 
        Console.WriteLine(_Description);
        Console.WriteLine(); 

        ObtainDuration();

        Console.Clear();
        RunSpinner("Get Ready", 3);
    }

    public void DisplayEnding()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        RunSpinner("You finished", 3);

        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
        RunSpinner("Returning to the menu", 3);
    }

    public void ObtainDuration()
    {
        Console.WriteLine("How long would you like the duration of this activity: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime; // is the current time past when the expected end time was
    }




    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = seconds; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinner(string message, int seconds)
    {
        Console.CursorVisible = false;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] symbols = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{message} {symbols[index]}");
            index = (index + 1) % symbols.Length;
            Thread.Sleep(200);
        }
        
        Console.WriteLine();
        Console.CursorVisible = true;
        
    }
}