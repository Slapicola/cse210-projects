using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");

        Console.Write("What would you like to do? ");
        string userChoice = Console.ReadLine();
        Journal journal1 = new Journal();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        do
        {
            if (userChoice == "1") //I need to use a while or do/while loop here
            {
                Entry newEntry = new Entry();
                PromptGenerator newPrompt = new PromptGenerator();
                string prompt = newPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                newEntry._dateTime = dateText;
                newEntry._promptText = prompt;
                newEntry._text = Console.ReadLine();

                journal1.AddEntry(newEntry);
            }
            else if (userChoice == "2") //Display
            {
                journal1.DisplayAll();
            }
            else if (userChoice == "3") //Load
            {
                Console.WriteLine("What is the filename? ");
                string loadFile = Console.ReadLine();
                journal1.LoadFromFile(loadFile);
            }
            else if (userChoice == "4") //Save
            {
                Console.WriteLine("What is the name of the file? ");
                string saveFile = Console.ReadLine();
                journal1.SaveToFile(saveFile);
            }
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");

            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

        } while (userChoice != "5");

        
    }
}