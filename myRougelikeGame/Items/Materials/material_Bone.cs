using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Materials
{
    class material_Bone : defaultItem
    {
        public material_Bone()
        {
            setType(22);//22=材料
            setName("骨头");
            setID(25);
            setWeight(0.05);
            setMaxEndurance(getRandomNum(500, 501));
            setEndurance(getRandomNum(455, 499));
            setEndurance_byStep(0.4);
            setLevel(1);
            setDescribe("看上去挺硬的");
            setCost(20);
            setEffecDescribe("可以拿来做武器啥的");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);

            updataQuality();
        }
    }
}
