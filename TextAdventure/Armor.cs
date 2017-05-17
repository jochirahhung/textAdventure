using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Armor : Item
    {
        MainWindow mw = new MainWindow();
        //durabilty
        //defense
    

        public void setArmor()
        {
            string leatherarmor = "Leather Armor";
            string bronzearmor = "Bronze Armor";
            string ironarmor = "Iron Armor";
            string steelarmor = "Steel Armor";

            if (tbxAction.contains( leatherarmor)) {
                armor.durability = 3;
                player.defense = 6;
                    }
            else if (tbx.Actions.contains( bronzearmor))
            {
                armor.durability = 5;
                player.defense = 8;
            }
            else if (tbx.Actions.contains(ironarmor))
            {
                armor.durability = 7;
                player.defense = 10;
            }
            else if (tbx.Actions.contains(steelarmor))
            {
                armor.durability = 9;
                player.defense = 12;
            }
            else
            {
                armor.durability = 0;
                player.defense = 1;
            }
        }

        /*
         *armorThing(String action){
         * 
         * if tbx.Action.contains(string leatherarmor){
         * armor.durability = 3
         * armor.defense = 6
         * 
         * 
         */

 

    }
}
