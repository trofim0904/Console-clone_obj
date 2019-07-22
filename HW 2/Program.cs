using System;
using System.Collections;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Phantom_Lancer pl = new Phantom_Lancer();
            Anti_Mage anti_mage = new Anti_Mage();

            Manta_Style manta_style = new Manta_Style();
            Phase_Boots phase_boots = new Phase_Boots();

            //anti_mage.items.Add(manta_style);
            anti_mage.items.Add(phase_boots);
           
            Console.WriteLine(anti_mage); 
            Console.WriteLine();

            ArrayList am_clones = anti_mage.getUltimate();

            for (int i = 0; i < am_clones.Count; i++)
            {
                Console.WriteLine(am_clones[i]);
                
            }

            pl.items.Add(phase_boots);
            pl.items.Add(manta_style);

            Console.WriteLine();
            Console.WriteLine(pl);
            Console.WriteLine();

            ArrayList pl_clones = pl.getUltimate();

            for (int i = 0; i < pl_clones.Count; i++)
            {
                Console.WriteLine(pl_clones[i]);
                
            }
            
            Console.ReadKey();
        }
    }
}
