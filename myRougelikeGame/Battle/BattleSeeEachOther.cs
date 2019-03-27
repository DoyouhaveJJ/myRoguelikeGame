using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Mob;
using myRougelikeGame.Function;


namespace myRougelikeGame.Battle
{
    class BattleSeeEachOther
    {
        private BattleField bf;
        private bool isHeroSeeEnemy;
        private bool isEnemySeeHero;
        private DIYRandom dr = new DIYRandom();
        public void judgeOnce(theHero hero,defaultMob enemy){
            if (!getIsHeroSeeEnemy())//英雄若没看到敌人，则要判断
            {
                if (dr.startBet(1000 - hero.getHero_eye(), hero.getHero_eye() + 1000))//看见了
                {
                    setIsHeroSeeEnemy(true);//英雄看到敌人
                }
            }
            if (!getIsEnemySeeHero())//若敌人没看到英雄，则判断
            {
                if (dr.startBet(200 - hero.getHero_agility(), 200 + hero.getHero_agility()))
                {
                    setIsEnemySeeHero(true);//敌人看到英雄 英雄敏捷越高，越不容易看到
                }
            }
        }
        public bool heroSearchEnemy(theHero hero,int distince)
        {
            if (distince == 0) {
                return true;
            }
            if (dr.startBet(distince+1,2*distince))//看见了
            {
                setIsHeroSeeEnemy(true);//英雄看到敌人
                return true;
            }
            else
                return false;     
        }
        public void init() {
            setIsEnemySeeHero(false);
            setIsEnemySeeHero(false);
        }



    
        public bool getIsHeroSeeEnemy()
        {
            return isHeroSeeEnemy;
        }
        public void setIsHeroSeeEnemy(bool isHeroSeeEnemy)
        {
            this.isHeroSeeEnemy = isHeroSeeEnemy;
        }
        public bool getIsEnemySeeHero()
        {
            return isEnemySeeHero;
        }
        public void setIsEnemySeeHero(bool isEnemySeeHero)
        {
            this.isEnemySeeHero = isEnemySeeHero;
        }
    }
}
