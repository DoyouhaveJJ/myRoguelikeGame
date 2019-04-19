using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Illness.ills;
using myRougelikeGame.Function;
namespace myRougelikeGame.Illness
{
    class illSystem
    {
        private theHero myhero;
        private illInitilizer iii = new illInitilizer();
        private defaultIll ill_Hero;
        private DIYRandom dr = new DIYRandom();

        public defaultIll InitIllByIDwithRate(int ID, int rate)
        {
            if (dr.startBet(rate, 1000))
            {
                return iii.getIllByID(ID);
            }
            else
            {
                return null;
            }
        }


        public void HeroGetIll(defaultIll ill){
            if (myhero.getHero_Status() != 1)//已经染病了 不能再染病了
                return;
            ill_Hero = ill;
            getMyhero().setHero_Status(2);
       //     ill_Hero().set
            

        }

        public void SufferByTurn(){
            

        }

        public void TryCureBySelf()
        {


        }
        public void Cure()
        {


        }



        public theHero getMyhero()
        {
            return myhero;
        }

        public void setMyhero(theHero myhero)
        {
            this.myhero = myhero;
        }
    }
}
