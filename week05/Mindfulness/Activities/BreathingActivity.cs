using System;
using System.Threading;

namespace MindfulnessApp.Activities
{
    class BreathingActivity : Activity
    {
        public override void Start()
        {
            DisplayStartingMessage("Breathing", "This activity will help you relax by guiding your breathing.");
            for (int i = 0; i < Duration / 6; i++)
            {
                Console.Write("Breathe in...");
                Countdown(3);
                Console.Write("Breathe out...");
                Countdown(3);
            }
            DisplayEndingMessage("Breathing");
        }

        private void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($" {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
