using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.NeckLace
{
    class necklace_PlasticNeckLace:defaultItem
    {
        public necklace_PlasticNeckLace()
        {
            setType(12);//12=项链
            setName("塑料项链");
            setID(13);
            setWeight(0.001);
            setMaxEndurance(getRandomNum(100, 300));
            setEndurance(getRandomNum(20, 99));
            setEndurance_byStep(0.001);
            setLevel(1);
            setDescribe("一股塑料的气息");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("地毯货9.9！\n魅力+1运气+5");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(5);
            setDefense(getRandomNum(1, 7));

            setAdd_charm(1);
            setAdd_lucky(5);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("塑料项链(已装备)"); }
            else { setName("塑料项链"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "断了");
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
           
            user.setHero_lucky(user.getHero_lucky() + getAdd_lucky());
            user.setHero_charm(user.getHero_charm() + getAdd_charm());
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
            user.setHero_lucky(user.getHero_lucky() - getAdd_lucky());
            user.setHero_charm(user.getHero_charm() + getAdd_charm());


        }
    }
}
