using System.IO;

public class GoalManager
{
    //Attributes
    private List<Goal> _goals;
    private int _score;
    //Constructors
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

    }
    //Methods
    public void Start()
    {
        int userInput = 0;
        while (userInput != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string uI = Console.ReadLine();
            userInput = int.Parse(uI);
            Console.WriteLine();
            if (userInput == 1)
            {
                CreateGoal();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("The goals are:");
                ListGoalDetails();
                Console.WriteLine();
            }
            else if (userInput == 3)
            {
                SaveGoals();
            }
            else if (userInput == 4)
            {
                LoadGoals();
            }
            else if (userInput == 5)
            {
                RecordEvent();
            }
            else if (userInput == 6)
            {
                Console.WriteLine("Thank you so much for planning your goals and recording your progress in our program!");
                Console.WriteLine("Have a blessed day!");
                Console.WriteLine();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        //excedding requirements
        if (_score >= 0 && _score <= 499)
        {
            Console.WriteLine($"You have {_score} points - Level 1: Novice");
        }
        else if (_score >= 500 && _score <= 900)
        {
            Console.WriteLine($"You have {_score} points - Level 2: Apprentice");
        }
        else if (_score >= 901 && _score <= 1999)
        {
            Console.WriteLine($"You have {_score} points - Level 3: Hero");
        }
        else if (_score >= 2000)
        {
            Console.WriteLine($"You have {_score} points - Level 4: Legend");
        }
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goal are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        int userSelection = int.Parse(userInput);
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string uI = Console.ReadLine();
        int goalPoints = int.Parse(uI);
        //if statements
        if (userSelection == 1)
        {
            _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        else if (userSelection == 2)
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (userSelection == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string goalTime = Console.ReadLine();
            int goalQuantity = int.Parse(goalTime);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();
            int goalBonus = int.Parse(bonus);

            _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalQuantity, goalBonus));
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string userInput = Console.ReadLine();
        int userSelection = int.Parse(userInput);
        int pointsEarned = _goals[userSelection - 1].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points");
        _score += pointsEarned;
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();
    }
    public void SaveGoals()
    {
        //create and save info on the file
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            for (int i = 0; i < _goals.Count; i++)
            {
                outputFile.WriteLine(_goals[i].GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        //load a file
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string details = parts[1];
            if (goalType == "SimpleGoal")
            {
                string[] detailParts = details.Split(",");
                string name = detailParts[0];
                string description = detailParts[1];
                int points = int.Parse(detailParts[2]);
                bool isComplete = bool.Parse(detailParts[3]);

                SimpleGoal goal = new SimpleGoal(name, description, points);
                goal.SetComplete(isComplete);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string[] detailParts = details.Split(",");
                string name = detailParts[0];
                string description = detailParts[1];
                int points = int.Parse(detailParts[2]);

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string[] detailParts = details.Split(",");
                string name = detailParts[0];
                string description = detailParts[1];
                int points = int.Parse(detailParts[2]);
                int goalBonus = int.Parse(detailParts[3]);
                int amountCompleted = int.Parse(detailParts[4]);
                int goalTarget = int.Parse(detailParts[5]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, goalTarget, goalBonus);
                goal.SetAmountCompleted(amountCompleted);
                _goals.Add(goal);
            }
        }
    }
}