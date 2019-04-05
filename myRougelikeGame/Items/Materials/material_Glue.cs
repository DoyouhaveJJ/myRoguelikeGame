using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Materials
{
    class material_Glue : defaultItem
    {
        public material_Glue()
        {
            setType(22);//22=材料
            setName("胶水");
            setID(24);
            setWeight(0.05);
            setMaxEndurance(getRandomNum(400, 401));
            setEndurance(getRandomNum(355, 399));
            setEndurance_byStep(0.5);
            setLevel(1);
            setDescribe("黏黏哒");
            setCost(10);
            setEffecDescribe("可以做啥呢？");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);

            updataQuality();
        }
    }
}
