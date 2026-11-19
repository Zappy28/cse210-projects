using System;

class Program
{
    static void Main(string[] args)
    {
        BaseGoal myGoal = new BaseGoal("BaseGoal");
        Console.WriteLine(myGoal.GetConsoleString());
    }
}