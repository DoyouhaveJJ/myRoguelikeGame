using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Illness.ills
{
    class ill_Cold : defaultIll
    {
        public ill_Cold()
        {
            setID(1);
            setName("感冒");
            setRate(10);
            setType(1);
            setBadness(5);
            setHealDifficulty(50);
        }
    }
}
