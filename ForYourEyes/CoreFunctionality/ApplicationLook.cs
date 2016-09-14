using MetroFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForYourEyes.CoreFunctionality
{
    [Serializable]
    public class ApplicationLook
    {
        public MetroThemeStyle Theme { get; set; }
        public MetroColorStyle Style { get; set; }
        public int WindowOpacity { get; set; }
        
        public ApplicationLook(MetroThemeStyle theme, MetroColorStyle style, int windowOpacity)
        {

            Theme = theme;
            Style = style;
            WindowOpacity = windowOpacity;
        }
    }
}
