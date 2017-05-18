using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Weapon
    {
        //durabilty
        //damage
        MainWindow mw = new MainWindow();
        public String setArmor(String action)
        {
            string bronzesword = "Bronze Sword";
            string ironsword = "Iron Sword";
            string steelsword = "Steel Sword";
            string titaniumsword = "Titanium Sword";

            if (action.Contains(bronzesword))
            {
                mw.tbxWeaponDur.Text = "3";
                mw.tbxDamage.Text = "6";
                return bronzesword;
            }
            else if (action.Contains(ironsword))
            {
                mw.tbxWeaponDur.Text = "5";
                mw.tbxDamage.Text = "8";
                return ironsword;
            }
            else if (action.Contains(steelsword))
            {
                mw.tbxWeaponDur.Text = "7";
                mw.tbxDamage.Text = "10";
                return steelsword;
            }
            else if (action.Contains(titaniumsword))
            {
                mw.tbxWeaponDur.Text = "9";
                mw.tbxDamage.Text = "12";
                return titaniumsword;
            }
            else
            {
                mw.tbxWeaponDur.Text = "0";
                mw.tbxDamage.Text = "1";
            }
        }

    }
}
