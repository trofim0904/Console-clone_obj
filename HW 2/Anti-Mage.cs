using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW_2
{
    class Anti_Mage : Hero,ICloneable
    {
        public Anti_Mage()
        {
            items = new ItemList<Item>();
            name = "Anti-Mage";
            strength = 23;
            agility = 24;
            intelligence = 12;
            power = strikePower();
        }
        public Anti_Mage(float power_decrease,ItemList<Item> item)
        {
            items = new ItemList<Item>();
            name = "Anti-Mage";
            strength = 23;
            agility = 24;
            intelligence = 12;
            power = (int) (power_decrease * strikePower());
            
            items = new ItemList<Item>(item.create_Array());
        }

        public object Clone()
        {
            ItemList<Item> list = new ItemList<Item>();
            list = new ItemList<Item>(items.create_Array());         
            return new Anti_Mage(0.33f,list);
        }

        public override ArrayList getUltimate()
        {
            //Иллюзии ближнего боя наносят 33% урона
            ArrayList clones = new ArrayList();
            for (int i = 0; i < items.Count; i++)
            {
                Item item_for_check = (Item)items[i];
                if (item_for_check.name.Equals("Manta_Style"))
                {
                    clones.Add(Clone());
                    clones.Add(Clone());
                    break;
                } 
            }
            if (clones.Count == 0)
            {
                Console.WriteLine("You do not have manta");
            }
            return clones;
        }

        public override int strikePower()
        {
            return strength + agility + intelligence;
        }
       
    }
}
