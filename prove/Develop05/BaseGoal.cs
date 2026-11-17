class BaseGoal
{
    private string _name;
    private string _description;
    private int numberOfPoints;

    public BaseGoal()
    {
        SetName();
    }

    private void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    public virtual string GetConsoleString()
    {
        return $"[ ] Goal Name: {_name}";
    }
}