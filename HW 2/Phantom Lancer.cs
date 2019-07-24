using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HW_2
{
    class Phantom_Lancer : Hero, ICloneable
    {
        public Phantom_Lancer()
        {
            items = new ItemList<Item>();
            name = "Phantom_Lancer";
            strength = 19;
            agility = 29;
            intelligence = 19;
            power = strikePower();

        }

        public Phantom_Lancer(ItemList<Item> item)
        {
            items = new ItemList<Item>();
            name = "Phantom_Lancer";
            strength = 19;
            agility = 29;
            intelligence = 19;
            power = strikePower();
            items = new ItemList<Item>(item.create_Array());
        }

        public Phantom_Lancer(ItemList<Item> item , float power_decrease)
        {
            items = new ItemList<Item>();
            name = "Phantom_Lancer";
            strength = 19;
            agility = 29;
            intelligence = 19;
            power = (int)(power_decrease * strikePower());
            items = new ItemList<Item>(item.create_Array());
        }

        public object Clone()
        {
            ItemList<Item> list = new ItemList<Item>();
            list = new ItemList<Item>(items.create_Array());

            return new Phantom_Lancer(list, 0.2f);
        }

        public object CloneWhithoutPower()
        {
            ItemList<Item> list = new ItemList<Item>();
            list = new ItemList<Item>(items.create_Array());
            
            return new Phantom_Lancer(list,0);
        }

        public override ArrayList getUltimate()
        {
            //Первая иллюзия наносит урона: 0 %

            //Вторая иллюзия наносит урона: 20 %

            ArrayList clones = new ArrayList
            {
                Clone(),
                CloneWhithoutPower()
            };
            return clones;
        }

        public override int strikePower()
        {
            return (strength + agility) * intelligence;
        }      
    }
}
