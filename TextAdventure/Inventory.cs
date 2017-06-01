using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Inventory
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
                return storage[1];
            }
            else if (action.Contains("Sword") || action.Contains("sword") && storage.Length <= 10)
            {
                storage[2] = (w.setWeapon(action));
                return storage[2];
            }
            else if(action.Contains("Key") || action.Contains("key") && storage.Length <= 10)
            {
                storage[3] = "Key";
                return storage[3];
            }
            return "Item does not exist";
        }
    }
}
