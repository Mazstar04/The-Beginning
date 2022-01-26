using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private double StartTime;
        private double EndTime;

        public Stopwatch()
        {
            StartTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }

        public double GetStartTime()
        {
            return StartTime;
        }
        public double GetEndTime()
        {
            return EndTime;
        }

        public void Start()
        {

            StartTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }

        public void Stop()
        {
            EndTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }

        public double GetElapsed()
        {
            double elapsed = EndTime - StartTime;
            return elapsed;
        }
    }
}