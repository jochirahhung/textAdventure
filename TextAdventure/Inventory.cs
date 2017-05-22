using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Inventory
    {
        private List<string> storage = new List<string>();
        Armor a = new Armor();
        Weapon w = new Weapon();

        public Inventory(String action)
        {
            if (action.Contains("Armor") || action.Contains("armor") && storage.Count <= 10)
            {
                storage.Add(a.setArmor(action));
            }
            else if (action.Contains("Weapon") || action.Contains("weapon") && storage.Count <= 10)
            {
                storage.Add(w.setWeapon(action));
            }
            else if(action.Contains("Key") || action.Contains("key") && storage.Count <= 10)
            {
                if (storage.Contains("Key"))
                {
                    storage.Remove("Key");
                }
                else
                {
                    storage.Add("Key");
                }
            }

        }
    }
}
