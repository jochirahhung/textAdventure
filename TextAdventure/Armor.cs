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

            if (mw.tbxAction.Text.Contains( leatherarmor)) {
                mw.tbxArmorDur.Text = "3";
                mw.tbxDefense.Text = "6";
                    }
            else if (mw.tbxAction.Text.Contains( bronzearmor))
            {
                mw.tbxArmorDur.Text = "5";
                mw.tbxDefense.Text = "8";
            }
            else if (mw.tbxAction.Text.Contains(ironarmor))
            {
                mw.tbxArmorDur.Text = "7";
                mw.tbxDefense.Text = "10";
            }
            else if (mw.tbxAction.Text.Contains(steelarmor))
            {
                mw.tbxArmorDur.Text = "9";
                mw.tbxDefense.Text = "12";
            }
            else
            {
                mw.tbxArmorDur.Text = "0";
                mw.tbxDefense.Text = "1";
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
