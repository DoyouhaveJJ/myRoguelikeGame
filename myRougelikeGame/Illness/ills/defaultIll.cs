using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;

namespace myRougelikeGame.Illness.ills
{
    class defaultIll
    {
        private int ID; //
        private string name;//
        private int type;//1=增加能量消耗负担类型的
        private int badness;//最大为1000
        private int healDifficulty;//最大为1000
        private int rate;//最大为1000
        private theHero myHero;


        virtual public void Symptom(){}//症状
        public int getID()
        {
            return ID;
        }
        public void setID(int iD)
        {
            ID = iD;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public int getBadness()
        {
            return badness;
        }
        public void setBadness(int badness)
        {
            this.badness = badness;
        }
        public int getHealDifficulty()
        {
            return healDifficulty;
        }
        public void setHealDifficulty(int healDifficulty)
        {
            this.healDifficulty = healDifficulty;
        }
        public int getRate()
        {
            return rate;
        }
        public void setRate(int rate)
        {
            this.rate = rate;
        }

	    public theHero getMyHero() {
		    return myHero;
	    }

	    public void setMyHero(theHero myHero) {
		    this.myHero = myHero;
        }

    }
}
