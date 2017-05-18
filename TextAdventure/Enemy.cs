using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public enum EnemeyTypes
    {
        THEIF,
        THUG,
        TROLL,
        OGRE,
        ORC,
        DRAGON
    }

    class Enemy
    {
        //Enemies will be randomly picked and will be given an random value
        /*Values
         * name
         * type
         * damage
         * defense
         * health
         * level
         */
        private string name;
        private EnemeyTypes type;
        private int damage=3, defense=2, health=10, level=1, exp = 4;

        public Enemy()
        {

        }
        public Enemy(string name, EnemeyTypes type)
        {
            this.name = name;
            this.type = type;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public EnemeyTypes getType()
        {
            return type;
        }
        public void setEnemy(EnemeyTypes type, int herolvl)
        {
            this.type = type;
            setLevel( herolvl);
            int lvlmod=0, expMod = 0;
            if (type == EnemeyTypes.THEIF)
            {
                if (level>1)
                {
                    lvlmod = 5*(level-1);
                    expMod +=level ;
                }

            }
            else if (type == EnemeyTypes.THUG)
            {
                lvlmod = 6*level;
                expMod += (1 + level);
            }
            else if (type == EnemeyTypes.TROLL)
            {
                lvlmod = 7 * level;
                expMod += (2 + level);
            }
            else if (type == EnemeyTypes.OGRE)
            {
                lvlmod = 8 * level;
                expMod += (3 + level);

            }
            else if (type == EnemeyTypes.ORC)
            {
                lvlmod = 9 * level;
                expMod += (4 + level);
            }
            else if (type == EnemeyTypes.DRAGON)
            {
                lvlmod = 10 * level;
                expMod += (5 + level);
            }
            if (level >= 10)
            {
                expMod = 0;
                exp = 0;
            }
            damage += lvlmod;
            defense += lvlmod;
            health += lvlmod;
            
            exp += expMod;
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
        public void setLevel(int herolvl)
        {
            int[] levels = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> levelchoices = new List<int>();
            if (herolvl == 1)
            {
                levelchoices.Add(levels[0]);
                levelchoices.Add(levels[1]);
                levelchoices.Add(levels[2]);

            }
            else if (herolvl == 2)
            {
                levelchoices.Add(levels[0]);
                levelchoices.Add(levels[1]);
                levelchoices.Add(levels[2]);
                levelchoices.Add(levels[3]);

            }
            else if (herolvl == 3)
            {
                levelchoices.Add(levels[1]);
                levelchoices.Add(levels[2]);
                levelchoices.Add(levels[3]);
                levelchoices.Add(levels[4]);
            }
            else if (herolvl == 4)
            {
                levelchoices.Add(levels[2]);
                levelchoices.Add(levels[3]);
                levelchoices.Add(levels[4]);
                levelchoices.Add(levels[5]);
            }
            else if (herolvl == 5)
            {
                levelchoices.Add(levels[3]);
                levelchoices.Add(levels[4]);
                levelchoices.Add(levels[5]);
                levelchoices.Add(levels[6]);
            }
            else if (herolvl == 6)
            {
                levelchoices.Add(levels[4]);
                levelchoices.Add(levels[5]);
                levelchoices.Add(levels[6]);
                levelchoices.Add(levels[7]);
            }
            else if (herolvl == 7)
            {
                levelchoices.Add(levels[5]);
                levelchoices.Add(levels[6]);
                levelchoices.Add(levels[7]);
                levelchoices.Add(levels[8]);
            }
            else if (herolvl == 8)
            {
                levelchoices.Add(levels[6]);
                levelchoices.Add(levels[7]);
                levelchoices.Add(levels[8]);
                levelchoices.Add(levels[9]);
            }
            else if (herolvl == 9)
            {
                levelchoices.Add(levels[7]);
                levelchoices.Add(levels[8]);
                levelchoices.Add(levels[9]);
            }
            else if (herolvl == 10)
            {
                levelchoices.Add(levels[8]);
                levelchoices.Add(levels[9]);
            }
            Random r = new Random();
            int randNum=r.Next(1,levelchoices.Capacity+1);
            level = randNum;
        }
        public int getEXP()
        {
            return exp;
        }
      
    }
}