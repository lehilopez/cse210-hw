using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your percentage grade: ");
        string userInput = Console.ReadLine();
        int percentGrade = int.Parse(userInput);

        string letterGrade = "";

        if (percentGrade >= 90)
        {
            letterGrade = "A";
            // Console.WriteLine("Your letter grade is: A");
        }
        else if (percentGrade >= 80)
        {
            letterGrade = "B";
            // Console.WriteLine("Your letter grade is: B");
        }
        else if (percentGrade >= 70)
        {
            letterGrade = "C";
            // Console.WriteLine("Your letter grade is: C");
        }
        else if (percentGrade >= 60)
        {
            letterGrade = "D";
            // Console.WriteLine("Your letter grade is: D");
        }
        else
        {
            letterGrade = "F";
            // Console.WriteLine("Your letter grade is: F");
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (percentGrade >= 70)
        {
            Console.WriteLine("Congratullations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}