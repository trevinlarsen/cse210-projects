using System;

class Program
{
   static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            ShowMainMenu();
        }
    }

    static void ShowMainMenu()
    {
        int totalScoreWithBonus = 0;
        foreach (var goal in goals)
    {
        totalScoreWithBonus += goal.PointValue; 

        if (goal.IsComplete)
        {
            totalScoreWithBonus += goal.BonusPoints;
        }
    }
    
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Record Event");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Enter the number of your choice: ");
        Console.WriteLine($"Total Score: {totalScore}");
        
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                CreateNewGoal();
                break;
            case "2":
                ListGoals();
                break;
            case "3":
                RecordEvent();
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");

        string type = Console.ReadLine();
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the point value: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            goals.Add(new SimpleGoal(name, points));
        }
        else if (type == "2")
        {
            goals.Add(new EternalGoal(name, points));
        }
        else if (type == "3")
        {
            Console.Write("Enter the target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
        }

        Console.WriteLine("Goal created successfully!");
    }

    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }

  static void RecordEvent()
{
    Console.WriteLine("\nSelect a goal to record progress:");
    for (int i = 0; i < goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
    }
    Console.Write("Enter the goal number: ");
    int goalNumber = int.Parse(Console.ReadLine()) - 1;

    if (goalNumber >= 0 && goalNumber < goals.Count)
    {
        Goal selectedGoal = goals[goalNumber];
        selectedGoal.RecordEvent(); 
        if (selectedGoal.IsComplete)
        {
            totalScore += selectedGoal.PointValue; 
        }
    }
    else
    {
        Console.WriteLine("Invalid goal number.");
    }
}



}