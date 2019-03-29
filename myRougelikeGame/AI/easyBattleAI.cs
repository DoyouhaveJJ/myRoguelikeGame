using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Mob;
using myRougelikeGame.Player;
using myRougelikeGame.Action;

namespace myRougelikeGame.AI
{
    class easyBattleAI:defaultAI
    {
        public easyBattleAI(){}
        public override void JudgeOnce()
        {
            base.JudgeOnce();
            setDistenceNow((int)getBf().getDistence()[(getBf().getTheMobList().IndexOf(getMyself()))]);
            if (!getBf().getBseo().getIsEnemySeeHero())
            {
                Search();
            }
            else
            {
                if (getDistenceNow() <= getDistenceCanAttack())
                {
                    Attack(getHero());
                }
                else if (getMyself().getMob_Hp() < 9)
                {
                    Escape();
                }
                else
                {
                    Move();
                }
            }
        }
        public override void Attack(theHero Hero)
        {
            base.Attack(Hero);
            if (getDr().startBet(getHero().getHero_agility(), 1000))
            {
                getEA().getMessageBox().Items.Add("敌人没打中你啦！");
                getBf().setEnemyLastMove("攻击");
            }
            else {
                getEA().AttackOnce(getMyself(), Hero);
                getBf().setEnemyLastMove("攻击");
            }

        }
        public override void Escape()
        {
            base.Escape();
            getBf().getDistence()[(getBf().getTheMobList().IndexOf(getMyself()))]=((int)getBf().getDistence()[(getBf().getTheMobList().IndexOf(getMyself()))] + 1);
            getBf().setEnemyLastMove("逃跑");
        }
        public override void Move()
        {
            base.Move();
            getBf().getDistence()[(getBf().getTheMobList().IndexOf(getMyself()))] = ((int)getBf().getDistence()[(getBf().getTheMobList().IndexOf(getMyself()))] - 1);
            getBf().setEnemyLastMove("前进");
        }
        public override void Search()
        {
            base.Search();
            if(getDr().startBet(1,4)){
                getBf().getBseo().setIsEnemySeeHero(true);
            }
            getBf().setEnemyLastMove("观察");
        }






        
    }
}
