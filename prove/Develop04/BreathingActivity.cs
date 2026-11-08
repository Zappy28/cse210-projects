class BreathingActivity : BaseActivity //inherits from BaseActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.")
    {
        //THIS IS DONE (I THINK), ALL THIS DOES IS CALL BASE()
    }

    public void RunActivity()
    {
        StartActivity();
        StartTimer();
        while (! HasTimerExpired()) // add when code is ready 
        {
            RunCountDownMessage("Breath in", 4);

            if(!HasTimerExpired()) //need to check again if the timer is up
            {
                RunCountDownMessage("Breathe out", 4);
                
            } 

        } 
        DisplayEnding();
    }
}