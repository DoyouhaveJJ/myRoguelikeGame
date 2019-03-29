using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.AI;

namespace myRougelikeGame.Mob.Enemy
{
    class enemy_Slime:defaultMob
    {
        public enemy_Slime(){
            setMob_Name("史莱姆");
            setMob_ID(1);
            setMob_Type(1);
            setMob_Describe("最菜的敌人，你这都打不过你别混了");
            setMob_Level(getRandomNum(1,5));
            setMob_Damage(4);
            setMob_magicDamage(3);
            setMob_Defense(1);
            setMob_magicDefense(1);
            setMob_Hp(30);
            setMob_Status(1);
            setIsFirstDead(true);
            initTheMob();
            setAI(new easyBattleAI());
            getAI().setDistenceCanAttack(2);
            getAI().setMyself(this);
        }
        

    }
}
