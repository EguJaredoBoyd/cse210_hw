using System;
using MindfulnessApp.Activities;

namespace MindfulnessApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World! This is the Mindfulness Project.");
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness App");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();
                Activity activity = null;
                
                switch (choice)
                {
                    case "1": activity = new BreathingActivity(); break;
                    case "2": activity = new ReflectionActivity(); break;
                    case "3": activity = new ListingActivity(); break;
                    case "4": return;
                    default: Console.WriteLine("Invalid choice. Try again."); Thread.Sleep(2000); continue;
                }
                
                activity.Start();
            }
        }
    }
}
