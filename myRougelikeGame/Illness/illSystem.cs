using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
namespace myRougelikeGame.Illness
{
    class illSystem
    {
        private theHero myhero;
        private illInitilizer iii = new illInitilizer();









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
