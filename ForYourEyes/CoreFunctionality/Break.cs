using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForYourEyes.CoreFunctionality
{
    [Serializable]
    public class Break
    {
        public string Instruction { get; set; }
        public string ImagePath { get; set; }

        public Break(string instruction, string imagePath)
        {
            Instruction = instruction;
            ImagePath = imagePath;
        }
    }
}
