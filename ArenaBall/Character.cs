using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaBall
{
    class Character : Stats
    {
        private string name;
        private int powerLevel;
        private int health;
        private int energy;
        private bool picked;
        private bool transformation;
        private byte[] img;





        public string CharName
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int PowerLevel
        {
            get
            {
                return this.powerLevel;
            }
            set
            {
                this.powerLevel = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            set
            {
                this.energy = value;
            }
        }

        public bool Picked
        {
            get
            {
                return this.picked;
            }
            set
            {
                this.picked = value;
            }
        }

        public bool Transformation
        {
            get
            {
                return this.transformation;
            }
            set
            {
                this.transformation = value;
            }
        }

        public byte[] Img
        {
            get
            {
                return this.img;
            }
            set
            {
                this.img = value;
            }
        }
    }
}
