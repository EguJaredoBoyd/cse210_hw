using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp.Activities
{
    class ListingActivity : Activity
    {
        private List<string> Prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        
        public override void Start()
        {
            DisplayStartingMessage("Listing", "This activity will help you reflect on the good things in your life.");
            Random random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Console.WriteLine("You have a few seconds to think...");
            Countdown(5);
            
            List<string> responses = new List<string>();
            int elapsed = 0;
            while (elapsed < Duration)
            {
                Console.Write("Enter an item: ");
                responses.Add(Console.ReadLine());
                elapsed += 3;
            }
            
            Console.WriteLine($"You listed {responses.Count} items.");
            DisplayEndingMessage("Listing");
        }
        
        private void Countdown(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
