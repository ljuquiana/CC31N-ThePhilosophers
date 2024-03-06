using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Player
    {
        public string Name { get; set; }
        public string CharacterClass { get; set; }
        public int Hitpoints { get; set; }
        public int Experiencepts { get; set; }
        public int level { get; set; }
        public int Gold { get; set; }
    }
}
