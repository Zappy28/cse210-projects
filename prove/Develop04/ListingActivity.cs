using System.Runtime.InteropServices;

class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts; 

    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.")
    {
        _prompts = new List<FlaggedString>();
    }   

    public void RunActivity()
    {
        SetPrompts();

        StartActivity();

        //Select a random prompt to show the user 
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index].GetPrompt(); //get prompt returns a prompt from Flagged string

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {prompt} ---");

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Start listing your answers.");   

        StartTimer();

        int itemCount = 0;

        while (!HasTimerExpired())
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(answer))
            {
                itemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items.");

        DisplayEnding();


    } 

    private void SetPrompts()
    {
        _prompts.Clear();

        _prompts.Add(new FlaggedString("Who are people that you appreciate?"));
        _prompts.Add(new FlaggedString("What are personal strengths of yours?"));
        _prompts.Add(new FlaggedString("Who are people that you have helped this week?"));
        _prompts.Add(new FlaggedString("When have you felt the Holy Ghost this month?"));
        _prompts.Add(new FlaggedString("Who are some of your personal heroes?"));
    }
}