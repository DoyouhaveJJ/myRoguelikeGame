using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Function
{
    class blockRandom
    {
            private Random myRandom = new Random();
            private int i;
            public int once()
            {
                i = myRandom.Next(1, 1000);
                if (i <= 600)
                {
                    return 1;//1 = 平原
                }
                else if (i <= 800&&i>600) {
                    return 2;//2 = 森林
                }
                else if (i <= 900 && i > 800)
                {
                    return 3;//3 = 湖泊
                }
                else {
                    return 4;//4 = 山地
                }
            }
    }
}
