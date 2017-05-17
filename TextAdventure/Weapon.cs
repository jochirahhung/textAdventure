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
        public void setArmor()
        {
            string bronzesword = "Bronze Sword";
            string ironsword = "Iron Sword";
            string steelsword = "Steel Sword";
            string titaniumsword = "Titanium Sword";

            if (tbxAction.contains(bronzesword))
            {
                WeaponDur.Text = 3;
                player.damge = 6;
            }
            else if (tbx.Actions.contains(ironsword))
            {
                WeaponDur.Text = 5;
                player.damge = 8;
            }
            else if (tbx.Actions.contains(steelsword))
            {
                WeaponDur.Text = 7;
                player.damge = 10;
            }
            else if (tbx.Actions.contains(titaniumsword))
            {
                WeaponDur.Text = 9;
                player.damge = 12;
            }
            else
            {
                WeaponDur.Text = 0;
                player.damge = 1;
            }
        }

    }
}
