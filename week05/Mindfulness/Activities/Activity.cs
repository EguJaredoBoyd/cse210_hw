using System;
using System.Threading;

namespace MindfulnessApp.Activities
{
    abstract class Activity
    {
        protected int Duration;
        public abstract void Start();
        
        protected void DisplayStartingMessage(string name, string description)
        {
            Console.WriteLine($"\n{name} Activity");
            Console.WriteLine(description);
            Console.Write("Enter duration in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            Thread.Sleep(2000);
        }
        
        protected void DisplayEndingMessage(string name)
        {
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed the {name} activity for {Duration} seconds.");
            Thread.Sleep(2000);
        }
    }
}
