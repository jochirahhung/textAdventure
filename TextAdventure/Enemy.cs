﻿using System;
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
            this.type = type;
        }

        public string Name { get => name; set => name = value; }
        public EnemeyTypes getType()
        {
            return type;
        }
        public void setEnemy(EnemeyTypes type, int herolvl)
        {
            this.type = type;
            setLevel( herolvl);
            int lvlmod=0;
            if (type == EnemeyTypes.THEIF)
            {
                if (level>1)
                {
                    lvlmod = 5*(level-1);
                }
            }
            else if (type == EnemeyTypes.THUG)
            {
                lvlmod = 6*level;
            }
            else if (type == EnemeyTypes.TROLL)
            {
                lvlmod = 7 * level;
            }
            else if (type == EnemeyTypes.OGRE)
            {
                lvlmod = 8 * level;

            }
            else if (type == EnemeyTypes.ORC)
            {
                lvlmod = 9 * level;

            }
            else if (type == EnemeyTypes.DRAGON)
            {
                lvlmod = 10 * level;

            }
            damage += lvlmod;
            defense += lvlmod;
            health += lvlmod;
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
        public void setEXP()
        {
            if (type==EnemeyTypes.THEIF)
            {

            } else if(type == EnemeyTypes.THUG)
            {

            }
            else if (type == EnemeyTypes.TROLL)
            {

            }
            else if (type == EnemeyTypes.OGRE)
            {

            }
            else if (type == EnemeyTypes.ORC)
            {

            }
            else if (type == EnemeyTypes.DRAGON)
            {

            }
        }
    }
}