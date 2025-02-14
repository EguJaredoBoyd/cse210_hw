using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nEternal Quest - Goal Tracker");
            Console.WriteLine("1. Add a Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save & Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Select Goal Type:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string type = Console.ReadLine();

                Console.Write("Enter Goal Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Description: ");
                string desc = Console.ReadLine();
                Console.Write("Enter Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1") manager.AddGoal(new SimpleGoal(name, desc, points));
                else if (type == "2") manager.AddGoal(new EternalGoal(name, desc, points));
                else if (type == "3")
                {
                    Console.Write("How many times must it be completed? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter Bonus Points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
                Console.Write("Enter the goal number to record: ");
                int index = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(index);
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
            }
            else if (choice == "4")
            {
                manager.SaveGoals("goals.txt");
                Console.WriteLine("Goals saved. Exiting...");
                break;
            }
        }
    }
}
