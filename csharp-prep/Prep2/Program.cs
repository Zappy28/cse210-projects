using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //int myNumber = int.Parse(numberString) to convert


        string grade;
        string letter;


        Console.Write("Input Grade Percentage (Ex: 95): ");
        grade = Console.ReadLine();
        int intGrade = int.Parse(grade);


        if (intGrade >= 90)
        {
            letter = "A";
        }
        else if (intGrade >= 80)
        {
            letter = "B";
        }
        else if (intGrade >= 70)
        {
            letter = "C";
        }
        else if (intGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (intGrade >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Try again next time.");
        }


        
    }
}