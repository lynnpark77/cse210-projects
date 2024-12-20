using System.Net;

public class GoalManager
{
    public List<Goal> _goals;
    public int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

    }

    public void Start()
    {
        
        while ( true )
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine( "1.Create New Goal");
            Console.WriteLine( "2.List Goals");
            Console.WriteLine( "3.Save Goals");
            Console.WriteLine( "4.Load Goals");
            Console.WriteLine( "5.Record Events");
            Console.WriteLine( "6.Quit");
            Console.WriteLine("Select a choice from the menu : ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1" :
                CreateGoal();
                break;

                case "2" :
                ListGoalDetails();
                break;

                case "3" :
                SaveGoals();
                break;

                case "4" :
                LoadGoals();
                break;

                case "5" :
                RecordEvent();
                break;

                case "6" :
                Console.WriteLine("See you next time!!");
                return;
            }

        }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    // public void ListGoalNames()
    // {
    //     Console.WriteLine("The goals are : ");
    //     int index = 1;
    //     foreach (Goal g in _goals)
    //     {
    //         Console.WriteLine($"{index}.{g.GetDetailsString()}");
    //         index ++;
    //     }

    // }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are : ");
        int index = 1;
        foreach (Goal g in _goals)
        {
            string check = g.IsComplete() ? "X": " ";
            Console.WriteLine($"{index}.[{check}] {g.GetDetailsString()}");
            index ++;
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goal = Console.ReadLine();


        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch(goal)
        {
            case "1":
            _goals.Add(new SimpleGoal(name,description,points));
            break;

            case "2":
            _goals.Add(new EternalGoal(name,description,points));
            break;

            case "3":
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name,description,points,target,bonus));
            break;

        }

    }

    public void RecordEvent()
    {


    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }


    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        // string[] lines = System.IO.File.ReadAllLines(file);
        // List<Goal> g = new List<Goal>();

        //  foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");

        //     string name = parts[0].Trim();
        //     string description = parts[1].Trim();
        //     string points = parts[2].Trim();
        //     string  = parts[3].Trim();
            
            
        // }
        // _goals = ;

    }



}