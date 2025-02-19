using System;

namespace ExerciseTracking.Activities
{
    class Running : Activity
    {
        private double Distance;
        
        public Running(DateTime date, int duration, double distance) : base(date, duration)
        {
            Distance = distance;
        }

        public override double GetDistance() => Distance;
        public override double GetSpeed() => (Distance / Duration) * 60;
        public override double GetPace() => Duration / Distance;
    }
}
