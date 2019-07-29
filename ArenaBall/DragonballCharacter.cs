using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaBall
{
    class DragonballCharacter : Character
    {
        
       
            

        public DragonballCharacter(DragonballCharacterDTO dbz)
        {
            this.CharName = dbz.CharName;
            this.PowerLevel = dbz.PowerLevel;
            this.Health = dbz.Health;
            this.Energy = dbz.Energy;
            this.Picked = dbz.Picked;
            this.Transformation = dbz.Transformation;
            this.Img = dbz.Img;
        }
    }
    
}
