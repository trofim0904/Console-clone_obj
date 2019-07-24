using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    abstract class Hero
    {
        public string name;
        public int intelligence;
        public int agility;
        public int strength;
        public int power;
        public ItemList<Item> items;
        
        public abstract int strikePower();

        public abstract ArrayList getUltimate();

        public override string ToString()
        {
            if (items.Count == 0)
            {
                return $"Name:  {name}  Power: {power} (Int:{intelligence} Agl:{agility} Str:{strength})";
            }
            else
            {
                string charac = $"Name:  {name}  Power: {power} (Int:{intelligence} Agl:{agility} Str:{strength})";
                for (int i = 0; i < items.Count; i++)
                {
                    charac += items[i];

                }
                return charac;
            }
        }
    }
}
