using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaBall
{
    class DragonballCharacterDTO : Character
    {
       


        public DragonballCharacterDTO(string name, int powerLevel, int health, int energy, bool transformation, bool picked, byte[] img)
        {
            this.CharName = name;
            this.PowerLevel = powerLevel;
            this.Health = health;
            this.Energy = energy;
            this.Picked = picked;
            this.Transformation = transformation;
            this.Img = img;
        }
    }

}
