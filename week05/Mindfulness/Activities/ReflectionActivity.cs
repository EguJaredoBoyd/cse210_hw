using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp.Activities
{
    class ReflectionActivity : Activity
    {
        private List<string> Prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        private List<string> Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself?"
        };
        
        public override void Start()
        {
            DisplayStartingMessage("Reflection", "This activity will help you reflect on times of strength and resilience.");
            Random random = new Random();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Thread.Sleep(3000);
            
            int elapsed = 0;
            while (elapsed < Duration)
            {
                Console.WriteLine(Questions[random.Next(Questions.Count)]);
                Countdown(5);
                elapsed += 5;
            }
            DisplayEndingMessage("Reflection");
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
