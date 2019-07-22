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
            items = new ArrayList();
            name = "Anti-Mage";
            strength = 23;
            agility = 24;
            intelligence = 12;
            power = strikePower();
        }
        public Anti_Mage(float power_decrease,ArrayList item)
        {
            items = new ArrayList();
            name = "Anti-Mage";
            strength = 23;
            agility = 24;
            intelligence = 12;
            power = (int) (power_decrease * strikePower());
            for (int i = 0; i < item.Count; i++)
            {
                items.Add(item[i]);
            }
        }

        public object Clone()
        {
            ArrayList list = new ArrayList();
            list = (ArrayList)items.Clone();
    
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
