using System;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    class Item:ICloneable
    {
        public string name;
        public int intelligence;
        public int agility;
        public int strength;

        public Item()
        {
            name = "item";
            intelligence = 0;
            agility = 0;
            strength = 0;
        }

        public object Clone()
        {

            if (name.Equals("Manta_Style"))
            {
                return new Manta_Style();
            }
            if (name.Equals("Phase Boots"))
            {
                return new Phase_Boots();
            }
            return new Item();
        }


        //public Item(string name,int intelligence,int agility,int strength)
        //{
        //    this.name = name;
        //    this.intelligence = intelligence;
        //    this.agility = agility;
        //    this.strength = strength;

        //}
        public override string ToString()
        {
            return $" {name} ({intelligence} {agility} {strength})";
        }
    }
}
