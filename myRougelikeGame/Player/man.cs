using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Player
{
    class man
    {
        private int Hp;
        private int maxHp;
        private int Exp;
        private int maxExp;
        private int Level;

        public void init() {
            Hp = 100;
            maxHp = 100;
            Exp = 0;
            maxExp = 1000;
            Level = 1;
        }

        public int getHp()
        {
            return Hp;
        }
        public void setHp(int hp)
        {
            Hp = hp;
        }
        public int getMaxHp()
        {
            return maxHp;
        }
        public void setMaxHp(int maxHp)
        {
            this.maxHp = maxHp;
        }
        public int getExp()
        {
            return Exp;
        }
        public void setExp(int exp)
        {
            Exp = exp;
        }
        public int getMaxExp()
        {
            return maxExp;
        }
        public void setMaxExp(int maxExp)
        {
            this.maxExp = maxExp;
        }
        public int getLevel()
        {
            return Level;
        }
        public void setLevel(int level)
        {
            Level = level;
        }
        

    }
}
