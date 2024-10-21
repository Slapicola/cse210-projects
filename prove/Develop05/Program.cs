// I ask the user to type 'ready' when they have something in mind for the prompt in the Reflection activity.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Menu Options:\n 1. Start Breathing Activity\n 2. Start Reflecting Activity\n 3. Start Listing Activity\n 4. Quit");
        Console.Write("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();

        while (userChoice != "4")
        {
            if (userChoice == "1")
            {
                Console.Clear();
                Breathing breathingActivity = new Breathing("Breathing Activity", 0, "This activity will help you relax by leading you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.DisplayStartingMessage();
                Console.Clear();
                Console.WriteLine("Get Ready...");
                breathingActivity.ShowSpinner(3);
                Console.WriteLine("");
                breathingActivity.Run();
                Console.WriteLine("\n");
                breathingActivity.DisplayFinishedMessage();
                breathingActivity.ShowSpinner(3);

            }
            else if (userChoice == "2")
            {
                Console.Clear();
                Reflection reflectingActivity = new Reflection("Reflection Activity", 0, "This activity will help you reflect on times in your life when you showed strength and resilience. This will help you recognize the power you have and how you can use in other aspects of your life.");
                reflectingActivity.DisplayStartingMessage();
                Console.Clear();
                Console.WriteLine("Get Ready...");
                reflectingActivity.ShowSpinner(3);
                Console.WriteLine("");
                reflectingActivity.Run();
                Console.WriteLine("\n");
                reflectingActivity.DisplayFinishedMessage();
                reflectingActivity.ShowSpinner(3);

            }
            else if (userChoice == "3")
            {
                Console.Clear();
                Listing listingActivity = new Listing("Listing Activity", 0, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.DisplayStartingMessage();
                Console.Clear();
                Console.WriteLine("Get Ready...");
                listingActivity.ShowSpinner(3);
                Console.WriteLine("");
                listingActivity.Run();
                Console.WriteLine("");
                listingActivity.DisplayFinishedMessage();
                listingActivity.ShowSpinner(3);

            }
            Console.Clear();
            Console.WriteLine("Menu Options:\n 1. Start Breathing Activity\n 2. Start Reflecting Activity\n 3. Start Listing Activity\n 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();
        }

        
    }
}