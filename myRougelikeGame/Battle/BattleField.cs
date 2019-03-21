using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Mob;

namespace myRougelikeGame.Battle
{
    class BattleField
    {

        private int Distence;
        private string EnemyLastMove;
        private string HeroLastMove;
        private theHero myHero;
        private defaultMob theMob;

        public void clearBattle(){
            setDistence(20);
            setEnemyLastMove("");
            setHeroLastMove("");
            setMyHero(null);
            setTheMob(null);
        }

        public theHero getMyHero()
        {
            return myHero;
        }
        public void setMyHero(theHero myHero)
        {
            this.myHero = myHero;
        }
        public defaultMob getTheMob()
        {
            return theMob;
        }
        public void setTheMob(defaultMob theMob)
        {
            this.theMob = theMob;
        }


        public int getDistence()
        {
            return Distence;
        }
        public void setDistence(int distence)
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
    }
}
