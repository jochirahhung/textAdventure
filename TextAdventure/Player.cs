using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Player
    {
        private string name;
        private int damage = 4, defense = 3, health = 10, level = 1, exp = 0;

        public Player()
        {

        }
        public Player(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string givenname)
        {
            name = givenname;
        }
        public int getDamage()
        {
            return damage;
        }
        public int getDefense()
        {
            return defense;
        }
        public int getHealth()
        {
            return health;
        }
        public int getLevel()
        {
            return level;
        }
        public int EXP()
        {
            return exp;                           
        }
        public void addToEXP(int enemyEXP)
        {
            if (exp >= 100 && level <= 10)
            {
                exp += enemyEXP;
                exp = 0;
                level++;
                health += 5;
                damage++;
                defense++;
            }
        }

    }
}
