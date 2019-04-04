using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Mob;
using myRougelikeGame.Function;
using myRougelikeGame.Action;
using System.Collections;

namespace myRougelikeGame.Battle
{
    class BattleField
    {
        private BattleSeeEachOther bseo;
        private ArrayList Distence = new ArrayList();
        private string EnemyLastMove;
        private string HeroLastMove;
        private theHero myHero;
        private ArrayList theMobList;
        private DIYRandom dr = new DIYRandom();
        private Translate tl = new Translate();
        private AddItem addBody = new AddItem();
        public BattleField() {
            
        }


        public void clearBattle(){
           
            setEnemyLastMove("");
            setHeroLastMove("");
            getDistence().Clear();
            getMyHero().getStandBlock().setMob_Count(0);
            getTheMobList().Clear();
        }
        public void initAI(EnemyAttack EnemyAttackAction)
        {
            for (int i = 0; i < getMyHero().getStandBlock().getMob_Count(); i++)
            {
                ((defaultMob)(getTheMobList()[i])).getAI().setEA(EnemyAttackAction);
                ((defaultMob)(getTheMobList()[i])).getAI().setBf(this);
                ((defaultMob)(getTheMobList()[i])).getAI().setHero(getMyHero());
               getBseo().judgeOnce(getMyHero(), ((defaultMob)(getTheMobList()[i])));
            }
        }
        public void JudgeOnce()
        {
            for (int i = 0; i < getMyHero().getStandBlock().getMob_Count(); i++)
            {
                if (((defaultMob)(getTheMobList()[i])).isDead())
                    continue;
                ((defaultMob)(getTheMobList()[i])).getAI().setDistenceNow((int)(getDistence()[i]));
                ((defaultMob)(getTheMobList()[i])).getAI().JudgeOnce();
                getBseo().judgeOnce(getMyHero(), ((defaultMob)(getTheMobList()[i])));
                getBseo().judgeOnce(getMyHero(), ((defaultMob)(getTheMobList()[i])));
            }

        }
        public void turnBodyToGround(){
            for(int i = 0 ; i < getTheMobList().Count ; i ++){
                getMyHero().getStandBlock().getItemInGround().Add(addBody.AddOneItemByID(tl.MobIDToBodyID(((defaultMob)getTheMobList()[i]).getMob_ID())));
            }
        }
        public bool isAllDead()
        {
            int i;
            for (i = 0; i < getMyHero().getStandBlock().getMob_Count(); i++)
            {
                if (!((defaultMob)getMyHero().getStandBlock().getMob_list()[i]).isDead())
                {
                    break;
                }
            }
            if (i == getMyHero().getStandBlock().getMob_Count())
            {
                return true;
            }
            return false;

        }

        public void heroMoveToward(int index)
        {
            if ((int)(getDistence()[index]) == 0)
            {
                getDistence()[index] = 0;
                setHeroLastMove("前进");
                return;
            }
            getDistence()[index] = ((int)(getDistence()[index]) - 1);
            setHeroLastMove("前进");
        }

        public void heroCharge(int index)
        {
            if ((int)(getDistence()[index]) == 1 || (int)(getDistence()[index]) == 0)
            {
                getDistence()[index] = 0;
                setHeroLastMove("冲锋");
                return;
            }
            getDistence()[index] = ((int)(getDistence()[index]) - 2);
            setHeroLastMove("冲锋");
        }

        public void heroEscape(int index)
        {
            getDistence()[index] = ((int)(getDistence()[index]) + 2);
            setHeroLastMove("逃跑");

        }
        public void heroFallBack(int index)
        {
            getDistence()[index] = ((int)(getDistence()[index]) + 1);
            setHeroLastMove("后退");
        }
        public void heroWait()
        {
            getMyHero().setEnergy(getMyHero().getEnergy() + (int)(getMyHero().getMaxEnergy()*0.5));
            setHeroLastMove("等待");
        }
        public void heroSearch(int index)
        {
            getBseo().heroSearchEnemy(getMyHero(), (int)getDistence()[index]);
            setHeroLastMove("寻找");
        }
        public void initDistence()
        {
            for (int i = 0; i < getMyHero().getStandBlock().getMob_Count(); i++)
            {
                getDistence().Add(dr.getRandomNum(4, 30));
            }
        }
        public theHero getMyHero()
        {
            return myHero;
        }
        public void setMyHero(theHero myHero)
        {
            this.myHero = myHero;
        }


        public ArrayList getTheMobList()
        {
            return theMobList;
        }

        public void setTheMobList(ArrayList theMobList)
        {
            this.theMobList = theMobList;
        }

        public ArrayList getDistence()
        {
            return Distence;
        }
        public void setDistence(ArrayList distence)
        {
            Distence = distence;
        }
        public string getEnemyLastMove()
        {
            return EnemyLastMove;
        }
        public void setEnemyLastMove(string enemyLastMove)
        {
            EnemyLastMove = enemyLastMove;
        }
        public string getHeroLastMove()
        {
            return HeroLastMove;
        }
        public void setHeroLastMove(string heroLastMove)
        {
            HeroLastMove = heroLastMove;
        }
        public BattleSeeEachOther getBseo()
        {
            return bseo;
        }
        public void setBseo(BattleSeeEachOther bseo)
        {
            this.bseo = bseo;
        }
    }
}
