﻿using System;
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
    

        public string setArmor(String action)
        {
            string leatherarmor = "Leather Armor";
            string bronzearmor = "Bronze Armor";
            string ironarmor = "Iron Armor";
            string steelarmor = "Steel Armor";

            if (action.Contains( leatherarmor)) {
                mw.tbxArmorDur.Text = "3";
                mw.tbxDefense.Text = "6";
                return leatherarmor;
            }
            else if (action.Contains( bronzearmor))
            {
                mw.tbxArmorDur.Text = "5";
                mw.tbxDefense.Text = "8";
                return bronzearmor;
            }
            else if (action.Contains(ironarmor))
            {
                mw.tbxArmorDur.Text = "7";
                mw.tbxDefense.Text = "10";
                return ironarmor;
            }
            else if (action.Contains(steelarmor))
            {
                mw.tbxArmorDur.Text = "9";
                mw.tbxDefense.Text = "12";
                return steelarmor;
            }
            else
            {
                mw.tbxArmorDur.Text = "0";
                mw.tbxDefense.Text = "1";
                return "No Armor";
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
