using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Body
{
    class body_Slime:defaultItem
    {
        public body_Slime()
        {
            setType(21);//21=尸体
            setName("史莱姆的尸体");
            setID(22);
            setWeight(3.5);
            setMaxEndurance(getRandomNum(400, 600));
            setEndurance(getRandomNum(35, 360));
            setEndurance_byStep(0.3);
            setLevel(1);
            setDescribe("一滩黏糊糊的液体");
            setCost(100);
            setEffecDescribe("真实恶心心，可以用来做一些材料吧");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);

            updataQuality();
        }
    }
}
