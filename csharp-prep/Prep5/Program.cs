using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = (PromptUserName());
        int userNum = (PromptUserNumber());
        int squaredNumber = (SquareNumber(userNum));
        DisplayResult(userName, squaredNumber);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNum = Console.ReadLine();
            int favNum = int.Parse(userNum);
            return favNum;
        }

        static int SquareNumber(int favNum)
        {
            int squaredNum = favNum * favNum;
            //Console.WriteLine(squaredNum);
            return squaredNum;
        }

        static void DisplayResult(string name, int squaredNum)
        {
            Console.Write($"{name}, the square of your number is {squaredNum}");
        }
    }
        
}