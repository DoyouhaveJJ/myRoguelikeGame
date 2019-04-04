using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Body
{
    class body_Goblin : defaultItem
    {
        public body_Goblin()
        {
            setType(21);//21=尸体
            setName("哥布林的尸体");
            setID(23);
            setWeight(15);
            setMaxEndurance(getRandomNum(400, 500));
            setEndurance(getRandomNum(35, 399));
            setEndurance_byStep(0.6);
            setLevel(1);
            setDescribe("看得出来，营养不良");
            setCost(100);
            setEffecDescribe("骨头也许有点用，还有绿色的皮");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);

            updataQuality();
        }
    }
}
