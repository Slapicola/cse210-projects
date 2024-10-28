public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 0;
    }

    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine("");
        Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("Select a choice form the menu: ");
        string userChoice = Console.ReadLine();
        while (userChoice != "6")
        {
        if (userChoice == "1")
        {
            Console.WriteLine("The types of Goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
            Console.Write("Which type of Goal would you like to create? ");
            string goalType = Console.ReadLine();

            if (goalType == "1") //Simple Goal
            {
                CreateGoal(1);
            }
            else if (goalType == "2") //Eternal Goal
            {
                CreateGoal(2);
            }
            else if (goalType == "3") //Checklist Goal
            {
                CreateGoal(3);
            }
            
        }
        else if (userChoice == "2")
        {
            ListGoalDetails();
            Console.WriteLine("");
        }
        else if (userChoice == "3")
        {
            SaveGoals();
        }
        else if (userChoice == "4")
        {
            LoadGoals();
        }
        else if (userChoice == "5")
        {
            RecordEvent();
        }
        Console.WriteLine("");
        DisplayPlayerInfo();
        Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("Select a choice form the menu: ");
        userChoice = Console.ReadLine();
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You are at level {_level}.");
    }

    public void ListGoalNames()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count++;
        }

    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete() == true)
            {
                Console.WriteLine($"[X] {goal.GetDetailsString()}");
            }
            else
            {
                Console.Write($"[ ] {goal.GetDetailsString()}");
                Console.WriteLine("");
            }
            
        }

    }

    public void CreateGoal(int goalNum)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalNum == 1)
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);

        }
        else if (goalNum == 2)
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);

        }
        else if (goalNum == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus amount for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonusPoints);
            _goals.Add(goal);

        }

    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine($"Which goal did you accomplish? ");
        int goalNum = int.Parse(Console.ReadLine());
        if (!_goals[goalNum - 1].IsComplete())
        {
            _score+=_goals[goalNum - 1].RecordEvent();
        }

        if (_score % 100 == 0)
        {
            Console.WriteLine("You've leveled up!");
            _level++;
        }
        

    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for this Save? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score/{_score}");
            outputFile.WriteLine($"Level/{_level}");

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you would like to load? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("/");

            string type = parts[0];

            if (type == "Score")
            {
                _score = int.Parse(parts[1]);
            }
            else if (type == "Level")
            {
                _level = int.Parse(parts[1]);
            }
            else
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    bool isCompleted = bool.Parse(parts[4]);

                    SimpleGoal aGoal = new SimpleGoal(name, description, points, isCompleted);
                    _goals.Add(aGoal);

                }
                else if (type == "EternalGoal")
                {
                    EternalGoal aGoal = new EternalGoal(name, description, points);
                    _goals.Add(aGoal);

                }
                else if (type == "ChecklistGoal")
                {
                    bool isCompleted = bool.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int target = int.Parse(parts[6]);
                    int amountCompleted = int.Parse(parts[7]);
                    ChecklistGoal aGoal = new ChecklistGoal(name, description, points, isCompleted, bonus, target, amountCompleted);
                    _goals.Add(aGoal);
                }
            }

        }
    }
}