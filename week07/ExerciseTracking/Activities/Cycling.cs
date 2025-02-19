using System;

namespace ExerciseTracking.Activities
{
    class Cycling : Activity
    {
        private double Speed;
        
        public Cycling(DateTime date, int duration, double speed) : base(date, duration)
        {
            Speed = speed;
        }

        public override double GetDistance() => (Speed * Duration) / 60;
        public override double GetSpeed() => Speed;
        public override double GetPace() => 60 / Speed;
    }
}
