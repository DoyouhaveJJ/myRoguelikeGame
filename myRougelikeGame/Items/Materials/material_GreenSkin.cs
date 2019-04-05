using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Materials
{
    class material_GreenSkin : defaultItem
    {
        public material_GreenSkin()
        {
            setType(22);//22=材料
            setName("绿皮");
            setID(26);
            setWeight(0.05);
            setMaxEndurance(getRandomNum(200, 201));
            setEndurance(getRandomNum(155, 199));
            setEndurance_byStep(0.3);
            setLevel(1);
            setDescribe("还有点温度呢");
            setCost(50);
            setEffecDescribe("大概可以卖钱");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);

            updataQuality();
        }
    }
}
