using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Inventory
    {
        private string[] storage = new string[10];
        Armor a = new Armor();
        Weapon w = new Weapon();
        MainWindow m = new MainWindow();

        public string generateInventory(string action)
        {
            if (action.Contains("Armor") || action.Contains("armor") && storage.Length <= 10)
            {
                storage[1] = (a.setArmor(action));
            }
            else if (action.Contains("Weapon") || action.Contains("weapon") && storage.Length <= 10)
            {
                storage[2] = (w.setWeapon(action));
            }
            else if(action.Contains("Key") || action.Contains("key") && storage.Length <= 10)
            {
                storage[3] = "Key";
            }
            return storage.Length.ToString();
        }
    }
}
