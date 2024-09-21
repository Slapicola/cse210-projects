using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();
        int gradeInNum = int.Parse(userGrade);
        string letter = "";

        if (gradeInNum >= 90)
        {
            letter = "A";
        }
        else if (gradeInNum >= 80)
        {
            letter = "B";
        }
        else if (gradeInNum >= 70)
        {
            letter = "C";
        }
        else if (gradeInNum >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradeInNum >= 70)
        {
            Console.WriteLine("Good Job! You passed the class");
        }
        else
        {
            Console.WriteLine("You'll pass next time.");
        }

        Console.WriteLine(letter);
    }
}