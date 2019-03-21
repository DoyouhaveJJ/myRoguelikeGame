using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Clothes
{
    class clothes_SackCloth:defaultItem
    {
        public clothes_SackCloth()
        {
            setType(6);//6=衣服
            setName("粗布上衣");
            setID(7);
            setWeight(0.4);
            setMaxEndurance(getRandomNum(110, 160));
            setEndurance(getRandomNum(70, 109));
            setEndurance_byStep(0.006);
            setLevel(1);
            setDescribe("粗布上衣。");
            setCost(getRandomNum(22,44));
            setEffecDescribe("穿上去很不舒服\n力量+6\n魅力-2");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setRoom(2);
            setIsEquited(false); 
            setMagicDefense(4);
            setDefense(getRandomNum(5, 10));

            setAdd_charm(-2);
            setAdd_strength(6);


        }
        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("粗布上衣(已装备)"); }
            else { setName("粗布上衣"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "破啦");
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
            user.setHero_strength(user.getHero_strength() + getAdd_strength());
            user.setHero_charm(user.getHero_charm() + getAdd_charm());
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
            user.setHero_strength(user.getHero_strength() - getAdd_strength());
            user.setHero_charm(user.getHero_charm() - getAdd_charm());
        }
       
    }
}
