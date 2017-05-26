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
        public String setWeapon(String action)
        {
            string bronzesword = "Bronze Sword";
            string ironsword = "Iron Sword";
            string steelsword = "Steel Sword";
            string titaniumsword = "Titanium Sword";

            if (action.Contains(bronzesword))
            {
                mw.tbxDamage.Text = "6";
                return bronzesword;
            }
            else if (action.Contains(ironsword))
            {
                mw.tbxDamage.Text = "8";
                return ironsword;
            }
            else if (action.Contains(steelsword))
            {
                mw.tbxDamage.Text = "10";
                return steelsword;
            }
            else if (action.Contains(titaniumsword))
            {
                mw.tbxDamage.Text = "12";
                return titaniumsword;
            }
            else
            {
                mw.tbxDamage.Text = "1";
                return "No Weapon";
            }
        }

    }
}
