using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Pants
{
    class pants_BadPants:defaultItem
    {
        public pants_BadPants()
        {
            setType(14);//14=裤子
            setName("破短裤");
            setID(15);
            setWeight(0.3);
            setMaxEndurance(getRandomNum(110, 180));
            setEndurance(getRandomNum(30, 109));
            setEndurance_byStep(0.01);
            setLevel(1);
            setDescribe("破旧的短裤。");
            setCost(getRandomNum(22,44));
            setEffecDescribe("会漏出膝盖\n敏捷+4\n魅力-1");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setRoom(4);
            setIsEquited(false); 
            setMagicDefense(6);
            setDefense(getRandomNum(5, 10));

            setAdd_charm(-1);
            setAdd_agility(4);


        }
        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("破短裤(已装备)"); }
            else { setName("破短裤"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "破掉了");
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
            user.setHero_agility(user.getHero_agility() + getAdd_agility());
            user.setHero_charm(user.getHero_charm() + getAdd_charm());
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
            user.setHero_agility(user.getHero_agility() - getAdd_agility());
            user.setHero_charm(user.getHero_charm() - getAdd_charm());
        }
    }
}
