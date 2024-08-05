using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPT_DEMO.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Forodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}