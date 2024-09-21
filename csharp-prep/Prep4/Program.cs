using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter Number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);

        while (userNumber != "0")
        {
            numbers.Add(number);
            Console.Write("Enter Number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
        }

        int total = 0;
        int average = 0;
        int largestNum = 0;


        foreach (int num in numbers)
        {
            total += num;
            average = total / numbers.Count;
            if (num > largestNum)
            {
                largestNum = num;
            }

        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}