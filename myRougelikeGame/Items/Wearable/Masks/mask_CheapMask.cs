using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Masks
{
    class mask_CheapMask:defaultItem
    {
        public mask_CheapMask()
        {
            setType(11);//11=口罩
            setName("廉价口罩");
            setID(12);
            setWeight(0.001);
            setMaxEndurance(getRandomNum(120, 190));
            setEndurance(getRandomNum(20, 100));
            setEndurance_byStep(0.005);
            setLevel(1);
            setDescribe("带上去保护口鼻");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("掏宝包邮9.9！\n耐力+5");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(5);
            setDefense(getRandomNum(1, 7));

            setAdd_endurance(5);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("廉价口罩(已装备)"); }
            else { setName("廉价口罩"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "穿破了");
                //System.Console.WriteLine(getName() + "破掉了，不能用啦");
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void EquipItem(Player.theHero user)
        {
            base.EquipItem(user);
           
            user.setHero_endurance(user.getHero_endurance() + getAdd_endurance());
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
            user.setHero_endurance(user.getHero_endurance() - getAdd_endurance());


        }
    }
}
