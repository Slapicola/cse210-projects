//To show creativity I added a leveling up system to the program. If the user gains a multiple of 100 points they get a message saying
// they leveled up, and their level is incremented by one.
//Their level is shown under their score when the menu is shown.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        Console.Clear();
        goalManager.Start();
    }
}