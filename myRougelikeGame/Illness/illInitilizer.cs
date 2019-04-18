using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Function;
using myRougelikeGame.Illness.ills;
namespace myRougelikeGame.Illness
{
    class illInitilizer
    {



        public defaultIll getIllByID(int ID)
        {
            switch (ID)
            {
                case 1: { return new ill_Cold(); }
                default: return null;
            
            }

        }

        

















       
    }
}
