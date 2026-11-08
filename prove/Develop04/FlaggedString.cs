class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt)
    {
        _prompt = prompt;
        _hasBeenUsed = false;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetHasBeenUsed()
    {
        _hasBeenUsed = true;
    }

    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }
}