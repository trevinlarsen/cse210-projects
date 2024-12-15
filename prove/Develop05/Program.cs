using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
       static void Main()
    {
        ShowMainMenu();
    }
    static void ShowMainMenu()
    {
        Console.WriteLine("Choose an activity please:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter the number of your choice: ");
        
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "1":
                Console.WriteLine("You selected the Breathing Activity.");
                StartBreathingActivity();
                break;
            case "2":
                Console.WriteLine("You selected the Reflection Activity.");
                StartReflectionActivity();
                break;
            case "3":
                Console.WriteLine("You selected the Listing Activity.");
                StartListingActivity();
                break;
            default:
                Console.WriteLine("Not an option dude/dudette. Please enter a number between 1 and 3.");
                break;
        }
    }


    static void StartActivity(string activityName, string description, int duration)
    {
        Console.WriteLine($"Starting {activityName}...");
        Console.WriteLine(description);
        Console.WriteLine($"You will be doing this activity for {duration} seconds.");
        Console.WriteLine("Get ready...");
         List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\"); 
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500); 
            Console.Write("\b \b");
        }
        
    }

    static void EndActivity(string activityName, int duration)
    {
         List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        
        

        Console.WriteLine("Good job! You have completed the activity.");
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500); 
            Console.Write("\b \b");
        }
        Console.WriteLine($"You completed the {activityName} for {duration} seconds.");
        Thread.Sleep(3000); 
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(500); 
            Console.Write("\b \b");
        }
        ShowMainMenu();
    }
    static void StartBreathingActivity()
    {
        Console.Write("How long, in seconds, would you like to do the Breathing Activity? ");
        int duration = int.Parse(Console.ReadLine());

        StartActivity("Breathing Activity", "This activity is meant to help relax your mind with deep breaths.", duration);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(5); 
            Console.WriteLine("And Breathe out...");
            Countdown(5);  
            
        }

        EndActivity("Breathing Activity", duration);
    }
    
    static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

     static void StartReflectionActivity()
    {   
         List<string> prompts = new List<string>
        {
            "Think of a time when you felt like yopu accomplished something.",
            "Think of a time when you did something really hard outside of school.",
            "Think of a time when you served those in your ward.",
            "Think of a time when you did something super random."
        };

         List<string> reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        
        Console.WriteLine("Wlecome to the Reflection Activity");
        Console.WriteLine("How long, in seconds, would you like to do the Reflection Activity? ");
        int duration = int.Parse(Console.ReadLine());

        StartActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength.", duration);
          List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
         Random rand = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            
            string selectedPrompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine(selectedPrompt);
            Thread.Sleep(1000);
             foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }
            string selectedQuestion = reflectionQuestions[rand.Next(reflectionQuestions.Count)];
            Console.WriteLine(selectedQuestion);
            Thread.Sleep(1000);
             foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }

            
        }

        EndActivity("Reflection Activity", duration);

    }

    
    static void StartListingActivity()
{
    List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    Console.WriteLine("Welcome to the Listing Activity");
    Console.WriteLine("How long, in seconds, would you like to do the Listing Activity? ");
    int duration = int.Parse(Console.ReadLine());
    StartActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);

    Random rand = new Random();
    string selectedPrompt = prompts[rand.Next(prompts.Count)];
    Console.WriteLine(selectedPrompt);

    Console.WriteLine("You have a few seconds to think. Get ready!");
    Countdown(5);

    int itemCount = 0;
    DateTime endTime = DateTime.Now.AddSeconds(duration);
    
    while (DateTime.Now < endTime)
    {
        Console.Write("Enter an item (or press Enter to stop): ");
        string userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput))
        {
            break; 
        }

        itemCount++;
        Console.WriteLine($"You listed: {userInput}");
        Thread.Sleep(1000); 
    }
    Console.WriteLine($"You listed {itemCount} items during this activity.");
    EndActivity("Listing Activity", duration);
}

}