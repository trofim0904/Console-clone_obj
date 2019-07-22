using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    class Item
    {
        public string name;
        public int intelligence;
        public int agility;
        public int strength;

        public override string ToString()
        {
            return $" {name}";
        }
    }
}
