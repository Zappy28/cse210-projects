using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 30;
        int z = 40;

        if (x == 10 && y == 30 || z == 30)
        {
            Console.WriteLine("X is 10");
            Console.WriteLine("Y is 30");
        }
        else if (x == 20)
        {
            Console.WriteLine("X is 20");
        }
        else
        {
            Console.WriteLine("Default Output");
        }
    }
}

