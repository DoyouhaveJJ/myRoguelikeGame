using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Function;
using myRougelikeGame.Action;
using myRougelikeGame.Mob;
using myRougelikeGame.Battle;

namespace myRougelikeGame.AI
{
    class defaultAI
    {
        private BattleField bf;
        private DIYRandom dr = new DIYRandom();
        private EnemyAttack EA;
        private int DistenceNow;
        private int DistenceCanAttack;
        private theHero Hero;
        private defaultMob Myself;

        virtual public void JudgeOnce(){}
        virtual public void Move(){}
        virtual public void Attack(theHero Hero){}
        virtual public void Escape(){}
        virtual public void Search() { }


        

        public int getDistenceNow()
        {
            return DistenceNow;
        }
        public void setDistenceNow(int distenceNow)
        {
            DistenceNow = distenceNow;
        }
        public int getDistenceCanAttack()
        {
            return DistenceCanAttack;
        }
        public void setDistenceCanAttack(int distenceCanAttack)
        {
            DistenceCanAttack = distenceCanAttack;
        }
        public theHero getHero()
        {
            return Hero;
        }
        public void setHero(theHero hero)
        {
            Hero = hero;
        }
        public DIYRandom getDr()
        {
            return dr;
        }
        public void setDr(DIYRandom dr)
        {
            this.dr = dr;
        }


        public EnemyAttack getEA()
        {
            return EA;
        }

        public void setEA(EnemyAttack eA)
        {
            EA = eA;
        }
        public defaultMob getMyself()
        {
            return Myself;
        }

        public void setMyself(defaultMob myself)
        {
            Myself = myself;
        }

        public BattleField getBf()
        {
            return bf;
        }

        public void setBf(BattleField bf)
        {
            this.bf = bf;
        }
    }
}
