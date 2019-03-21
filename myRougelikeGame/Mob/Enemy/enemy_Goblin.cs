using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.AI;

namespace myRougelikeGame.Mob.Enemy
{
    class enemy_Goblin:defaultMob
    {
        public enemy_Goblin()
        {
            setMob_Name("哥布林");
            setMob_ID(1);
            setMob_Type(1);
            setMob_Describe("比史莱姆强一、");
            setMob_Level(getRandomNum(3, 6));
            setMob_Damage(4);
            setMob_magicDamage(3);
            setMob_Defense(1);
            setMob_magicDefense(1);
            setMob_Hp(30);
            initTheMob();
            setAI(new easyBattleAI());
            getAI().setDistenceCanAttack(3);
            getAI().setMyself(this);
        }
    }
}
