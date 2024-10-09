using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Reference reference1 = new Reference("1 Nephi", 12, 48);
        Scripture scripture = new Scripture(reference1, "Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect.");
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
        string userChoice = Console.ReadLine();

        while (userChoice == Console.ReadLine())
        {
            Console.WriteLine(scripture.GetDisplayText());
            
            if (scripture.IsCompletelyHidden() == false)
            {
                Console.Clear();
                scripture.HideRandomWords(3);
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            }
            else
            {
                break;
            }
        }
    }
}