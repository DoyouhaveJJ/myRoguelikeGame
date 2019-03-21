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
                i = myRandom.Next(1, 10000);
                if (i <= 4243)
                {
                    return 1;//1 = 平原
                }
                else if (i >= 4243&&i<6932) {
                    return 2;//2 = 森林
                }
                else if (i>= 6932 && i < 8279)
                {
                    return 3;//3 = 湖泊
                }
                else if (i >= 8279 && i < 9331)
                {
                    return 4;//4 = 山地
                }
                else {
                    return 5;//废墟
                }
            }
    }
}
