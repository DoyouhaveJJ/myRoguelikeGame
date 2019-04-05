using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items
{
    class NullItem:defaultItem
    {
        public NullItem()
        {
            setType(-1);//1=食物
            setName("空物品");
            setID(-1);
            setWeight(0.3);
            setMaxEndurance(getRandomNum(50, 60));
            setEndurance(getRandomNum(1, 50));
            setEndurance_byStep(0.08);
            setLevel(1);
            setDescribe("");
            setCost(20);
            setEffecDescribe("");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);

            updataQuality();
        }
    }
}
