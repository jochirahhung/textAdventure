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
        public void setArmor()
        {
            string bronzesword = "Bronze Sword";
            string ironsword = "Iron Sword";
            string steelsword = "Steel Sword";
            string titaniumsword = "Titanium Sword";

            if (mw.tbxAction.Text.Contains(bronzesword))
            {
                mw.tbxWeaponDur.Text = "3";
                mw.tbxDamage.Text = "6";
            }
            else if (mw.tbxAction.Text.Contains(ironsword))
            {
                mw.tbxWeaponDur.Text = "5";
                mw.tbxDamage.Text = "8";
            }
            else if (mw.tbxAction.Text.Contains(steelsword))
            {
                mw.tbxWeaponDur.Text = "7";
                mw.tbxDamage.Text = "10";
            }
            else if (mw.tbxAction.Text.Contains(titaniumsword))
            {
                mw.tbxWeaponDur.Text = "9";
                mw.tbxDamage.Text = "12";
            }
            else
            {
                mw.tbxWeaponDur.Text = "0";
                mw.tbxDamage.Text = "1";
            }
        }

    }
}
