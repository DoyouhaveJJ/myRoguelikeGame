using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.BagForHand
{
    class bagforhand_PlasticBag:defaultItem
    {
        public bagforhand_PlasticBag() {
            setType(3);  //3=可穿戴物(手持物)
            setName("塑料袋");
            setID(4);
            setWeight(0.05);
            setMaxEndurance(getRandomNum(70, 100));
            setEndurance(getRandomNum(20, 70));
            setEndurance_byStep(0.09);
            setLevel(1);
            setDescribe("塑料袋，可以拿在手上。");
            setCost(5);
            setEffecDescribe("可以提供8个容量");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));

            setRoom(8);
            setIsEquited(false);
            setDefense(0);
            setMagicDefense(0);
        }

        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("塑料袋(已装备)"); }
            else { setName("塑料袋"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "破掉了，不能用啦");
                //System.Console.WriteLine(getName() + "破掉了，不能用啦");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
