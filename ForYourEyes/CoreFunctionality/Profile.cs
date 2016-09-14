using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForYourEyes.CoreFunctionality
{
    [Serializable]
    public class Profile
    {
        public string Name { get; set; }
        public Settings Settings { get; set; }
        List<Break> _breaks = new List<Break>();
        public List<Break> Breaks
        {
            get { return this._breaks; }
            set { this._breaks = value; }
        }
        public ApplicationLook ApplicationLook { get; set; }
        public Sound Sound { get; set; }
        

        public Profile(string name, Settings settings, List<Break> breaks, ApplicationLook applicationLook, Sound sound)
        {
            Name = name;
            Settings = new Settings(settings.QuantityShortBreaks, settings.DurationShortBreak, settings.DistanceLongBreak, settings.DurationLongBreak);
            foreach (Break item in breaks)
            {
                Breaks.Add(new Break(item.Instruction, item.ImagePath));
            }
            ApplicationLook = new ApplicationLook(applicationLook.Theme, applicationLook.Style, applicationLook.WindowOpacity);

            Sound = new Sound(sound.SoundEnabled);
        }
    }
}
