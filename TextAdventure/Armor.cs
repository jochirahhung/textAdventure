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
                armor.Text = 3;
                player.Text = 6;
                    }
            else if (tbx.Actions.contains( bronzearmor))
            {
                tbxArmorDur.Text = 5;
                player.Text = 8;
            }
            else if (tbx.Actions.contains(ironarmor))
            {
                armor.Text = 7;
                player.Text = 10;
            }
            else if (tbx.Actions.contains(steelarmor))
            {
                armor.Text = 9;
                player.Text = 12;
            }
            else
            {
                armor.Text = 0;
                player.Text = 1;
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
