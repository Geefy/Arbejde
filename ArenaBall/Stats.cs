using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaBall
{
    interface Stats
    {
        int PowerLevel { get; set; }
        string CharName { get; set; }
        bool Picked { get; set; }
        bool Transformation { get; set; }
        int Health { get; set; }
        int Energy { get; set; }

        
    }

    
}
