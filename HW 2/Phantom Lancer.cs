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
            items = new ArrayList();
            name = "Phantom_Lancer";
            strength = 19;
            agility = 29;
            intelligence = 19;
            power = strikePower();

        }

        public Phantom_Lancer(ArrayList item)
        {
            items = new ArrayList();
            name = "Phantom_Lancer";
            strength = 19;
            agility = 29;
            intelligence = 19;
            power = strikePower();
            for (int i = 0; i < item.Count; i++)
            {
                
                items.Add(item[i]);
                
            }
        }

        public Phantom_Lancer(ArrayList item , float power_decrease)
        {
            items = new ArrayList();
            name = "Phantom_Lancer";
            strength = 19;
            agility = 29;
            intelligence = 19;
            power = (int)(power_decrease * strikePower());

            for (int i = 0; i < item.Count; i++)
            {           
                items.Add(item[i]);         
            }
        }

        public object Clone()
        {
            ArrayList list = new ArrayList();
            list = (ArrayList)items.Clone();
            
            return new Phantom_Lancer(list, 0.2f);
        }

        public object CloneWhithoutDecrease()
        {
            ArrayList list = new ArrayList();
            list = (ArrayList)items.Clone();
            
            return new Phantom_Lancer(list);
        }

        public override ArrayList getUltimate()
        {
            //Первая иллюзия наносит урона: 0 %

            //Вторая иллюзия наносит урона: 20 %

            ArrayList clones = new ArrayList
            {
                Clone(),
                CloneWhithoutDecrease()
            };
            return clones;
        }

        public override int strikePower()
        {
            return (strength + agility) * intelligence;
        }      
    }
}
