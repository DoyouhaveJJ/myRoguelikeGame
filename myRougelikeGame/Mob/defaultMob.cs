using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.AI;
using myRougelikeGame.Map;
namespace myRougelikeGame.Mob
{
    class defaultMob
    {

        private Random randomNum = new Random();
        private defaultAI AI;
        private string mob_Name;
        private int mob_ID;
        private int mob_Type;//1=敌人
        private int mob_Status;//1=live -1=dead
        private string mob_Describe;
        private int mob_Level;
        private int mob_Damage;
        private int mob_magicDamage;
        private int mob_Defense;
        private int mob_magicDefense;
        private int mob_Hp;
        private int mob_AttackDistence;
        private defaultBlock mob_location;
        private bool isFirstDead;

        //等级有关
        private int mob_Hp_Increase;
        private int mob_Damage_Increase;
        private int mob_magicDamage_Increase;
        private int mob_Defense_Increase;
        private int mob_magicDefense_Increase;








        public void initTheMob() {
            for (int i = 0; i < getMob_Level(); i++)
            {
                setMob_Damage(getMob_Damage()+getRandomNum(1,getMob_Damage_Increase()));
                setMob_Defense(getMob_Defense() + getRandomNum(1, getMob_Defense_Increase()));
                setMob_Hp(getMob_Hp() + getRandomNum(1, getMob_Hp_Increase()));
                setMob_magicDamage(getMob_magicDamage() + getRandomNum(1, getMob_magicDamage_Increase()));
                setMob_magicDefense(getMob_magicDefense() + getRandomNum(1, getMob_magicDefense_Increase()));
            }
        }
        private void Dead()
        {
            setMob_Status(-1);
        }
        public int getRandomNum(int a, int b)
        {
            return randomNum.Next(a, b + 1);
        }



        public bool isDead() {
            if (getMob_Hp() <= 0) {
                Dead();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getMob_Name()
        {
            return mob_Name;
        }
        public void setMob_Name(string mob_Name)
        {
            this.mob_Name = mob_Name;
        }
        public int getMob_ID()
        {
            return mob_ID;
        }
        public void setMob_ID(int mob_ID)
        {
            this.mob_ID = mob_ID;
        }
        public int getMob_Type()
        {
            return mob_Type;
        }
        public void setMob_Type(int mob_Type)
        {
            this.mob_Type = mob_Type;
        }
        public string getMob_Describe()
        {
            return mob_Describe;
        }
        public void setMob_Describe(string mob_Describe)
        {
            this.mob_Describe = mob_Describe;
        }
        public int getMob_Level()
        {
            return mob_Level;
        }
        public void setMob_Level(int mob_Level)
        {
            this.mob_Level = mob_Level;
        }
        public int getMob_Damage()
        {
            return mob_Damage;
        }
        public void setMob_Damage(int mob_Damage)
        {
            this.mob_Damage = mob_Damage;
        }
        public int getMob_magicDamage()
        {
            return mob_magicDamage;
        }
        public void setMob_magicDamage(int mob_magicDamage)
        {
            this.mob_magicDamage = mob_magicDamage;
        }
        public int getMob_Defense()
        {
            return mob_Defense;
        }
        public void setMob_Defense(int mob_Defense)
        {
            this.mob_Defense = mob_Defense;
        }
        public int getMob_magicDefense()
        {
            return mob_magicDefense;
        }
        public void setMob_magicDefense(int mob_magicDefense)
        {
            this.mob_magicDefense = mob_magicDefense;
        }
        public int getMob_Hp()
        {
            return mob_Hp;
        }
        public void setMob_Hp(int mob_Hp)
        {
            this.mob_Hp = mob_Hp;
        }

        public int getMob_Hp_Increase()
        {
            return mob_Hp_Increase;
        }
        public void setMob_Hp_Increase(int mob_Hp_Increase)
        {
            this.mob_Hp_Increase = mob_Hp_Increase;
        }
        public int getMob_Damage_Increase()
        {
            return mob_Damage_Increase;
        }
        public void setMob_Damage_Increase(int mob_Damage_Increase)
        {
            this.mob_Damage_Increase = mob_Damage_Increase;
        }
        public int getMob_magicDamage_Increase()
        {
            return mob_magicDamage_Increase;
        }
        public void setMob_magicDamage_Increase(int mob_magicDamage_Increase)
        {
            this.mob_magicDamage_Increase = mob_magicDamage_Increase;
        }
        public int getMob_Defense_Increase()
        {
            return mob_Defense_Increase;
        }
        public void setMob_Defense_Increase(int mob_Defense_Increase)
        {
            this.mob_Defense_Increase = mob_Defense_Increase;
        }
        public int getMob_magicDefense_Increase()
        {
            return mob_magicDefense_Increase;
        }
        public void setMob_magicDefense_Increase(int mob_magicDefense_Increase)
        {
            this.mob_magicDefense_Increase = mob_magicDefense_Increase;
        }
        public int getMob_AttackDistence()
        {
            return mob_AttackDistence;
        }

        public void setMob_AttackDistence(int mob_AttackDistence)
        {
            this.mob_AttackDistence = mob_AttackDistence;
        }


        public defaultAI getAI()
        {
            return AI;
        }

        public void setAI(defaultAI aI)
        {
            AI = aI;
        }


        public defaultBlock getMob_location()
        {
            return mob_location;
        }

        public void setMob_location(defaultBlock mob_location)
        {
            this.mob_location = mob_location;
        }
        public int getMob_Status()
        {
            return mob_Status;
        }

        public void setMob_Status(int mob_Status)
        {
            this.mob_Status = mob_Status;
        }


        public bool getIsFirstDead()
        {
            return isFirstDead;
        }

        public void setIsFirstDead(bool isFirstDead)
        {
            this.isFirstDead = isFirstDead;
        }



    }
}
