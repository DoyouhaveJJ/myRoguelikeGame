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
            if (dr.startBet(1000-hero.getHero_eye(), hero.getHero_eye()+1000))//看见了
            {
                setIsHeroSeeEnemy(true);
            }
            if(dr.startBet(200-hero.getHero_agility(),250)){
                setIsEnemySeeHero(true);
            }
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
