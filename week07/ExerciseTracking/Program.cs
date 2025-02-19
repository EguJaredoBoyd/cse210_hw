using System;
using System.Collections.Generic;
using ExerciseTracking.Activities;

namespace ExerciseTracking
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
            
            List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2022, 11, 3), 30, 4.8),
                new Cycling(new DateTime(2022, 11, 3), 45, 20.0),
                new Swimming(new DateTime(2022, 11, 3), 30, 20)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
