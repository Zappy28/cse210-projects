class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public ReflectionActivity() : base ("Relfection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<FlaggedString>();
        _questions = new List<FlaggedString>();
    }

    public void RunActivity()
    {
        SetPromptsAndQuestions();

        StartActivity();

        Random random = new Random();

        int prompt_Index = random.Next(_prompts.Count);
        string prompt = _prompts[prompt_Index].GetPrompt();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {prompt} ---");

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on the following questions as they relate to this experience");
        RunCountDownMessage("You may begin in: ", 5);

        StartTimer();

        while (!HasTimerExpired())
        {
            int question_index = random.Next(_questions.Count);
            string question = _questions[question_index].GetPrompt();
            RunSpinner(question, 5);
        }

        DisplayEnding();

        
    }

    private void SetPromptsAndQuestions()
    {
        _prompts.Clear();
        _questions.Clear();

        _prompts.Add(new FlaggedString("Think of a time when you stood up for someone else."));
        _prompts.Add(new FlaggedString("Think of a time when you did something really difficult."));
        _prompts.Add(new FlaggedString("Think of a time when you helped someone in need."));
        _prompts.Add(new FlaggedString("Think of a time when you did something truly selfless."));

        _questions.Add(new FlaggedString("Why was this experience meaningful to you?"));
        _questions.Add(new FlaggedString("Have you ever done anything like this before?"));
        _questions.Add(new FlaggedString("How did you get started?"));
        _questions.Add(new FlaggedString("How did you feel when it was complete?"));
        _questions.Add(new FlaggedString("What made this time different than other times when you were not as successful?"));
        _questions.Add(new FlaggedString("What is your favorite thing about this experience?"));
        _questions.Add(new FlaggedString("What could you learn from this experience that applies to other situations?"));
        _questions.Add(new FlaggedString("What did you learn about yourself through this experience?"));
        _questions.Add(new FlaggedString("How can you keep this experience in mind in the future?"));
    }
}