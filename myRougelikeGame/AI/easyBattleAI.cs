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
            setDistenceNow(getBf().getDistence());
            base.JudgeOnce();
            if (getDistenceNow() <= getDistenceCanAttack())
            {
                Attack(getHero());
            }
            else if (getMyself().getMob_Hp() < 9)
            {
                Escape();
            }
            else {
                Move();
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
            getBf().setDistence(getBf().getDistence() + 1);
            getBf().setEnemyLastMove("逃跑");
        }
        public override void Move()
        {
            base.Move();
            getBf().setDistence(getBf().getDistence() - 1);
            getBf().setEnemyLastMove("前进");
        }






        
    }
}
