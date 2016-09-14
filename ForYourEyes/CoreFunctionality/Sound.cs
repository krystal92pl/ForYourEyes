using System;

namespace ForYourEyes.CoreFunctionality
{
    [Serializable]
    public class Sound
    {
        public bool SoundEnabled { get; set; }

        public Sound(bool soundEnabled)
        {
            SoundEnabled = soundEnabled;
        }
    }
}
