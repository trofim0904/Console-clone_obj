using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    class Manta_Style:Item,ICloneable
    {

        public Manta_Style() 
        {
            name = "Manta_Style";
            strength = 10;
            agility = 26;
            intelligence = 10;
        }

    }
}
