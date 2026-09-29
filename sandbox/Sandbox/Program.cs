using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{

    static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        
        myCircle._radius = 10;

        double area = myCircle.GetArea();

        Console.WriteLine(area);

    }

}






    // //Functions
    // //static means it can be called without a object
    // static double AddNumbers(double x, int y)
    // {
    //     return x + y;
    // }

    // static string MyName()
    // {
    //     return "Bob";
    // }

    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, its nice to meet you.");
    // }

    
        // string myName = MyName();
        // DisplayGreeting(myName);
        // double Total = AddNumbers(12.234, 20);
        // Console.WriteLine(Total);

        // int x = 10;
        // int y = 30;
        // int z = 40;

        // if (x == 10 && y == 30 || z == 30)
        // {
        //     Console.WriteLine("X is 10");
        //     Console.WriteLine("Y is 30");
        // }
        // else if (x == 20)
        // {
        //     Console.WriteLine("X is 20");
        // }
        // else
        // {
        //     Console.WriteLine("Default Output");
        // }


        //! While loop
        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }

        //! DoWhile loop
        // bool done;

        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // } while (! done);

        //!for loop
        // for(int i = 0; i < 10; i += 5)
        // {
        //     Console.WriteLine(i);
        // }

        //!for each loop
        // List<string> MyList = new List<string> {"Apple", "Banana", "Grape"};
        // MyList.Insert(1, "Orange");
        // MyList.Add("Cherry");

        // foreach (string fruit in MyList)
        // {
        //     Console.WriteLine(fruit);
        // }

    


    


