using System;

namespace ForYourEyes.CoreFunctionality
{
    [Serializable]
    public class Settings
    {
        public int QuantityShortBreaks { get; set; }
        public int DurationShortBreak { get; set; }
        public int DistanceLongBreak { get; set; }
        public int DurationLongBreak { get; set; }
        
        public Settings(int quantityShortBreaks, int durationShortBreak, int distanceLongBreak, int durationLongBreak)
        {
            QuantityShortBreaks = quantityShortBreaks;
            DurationShortBreak = durationShortBreak;
            DistanceLongBreak = distanceLongBreak;
            DurationLongBreak = durationLongBreak;
        }
    }
}
