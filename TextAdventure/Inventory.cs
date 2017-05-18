using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Inventory
    {
        private List<Item> storage = new List<Item>();
        Armor a = new Armor();
        Weapon w = new Weapon();

        public Inventory(String action)
        {
            if (action.Contains("Armor") && storage.Count <= 10)
            {
                storage.Add(a.setArmor(action));
            }
        }

       
    
    }
}
