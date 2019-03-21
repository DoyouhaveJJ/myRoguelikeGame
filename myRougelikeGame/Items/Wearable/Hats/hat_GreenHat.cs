using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Hats
{
    class hat_GreenHat:defaultItem
    {
        public hat_GreenHat()
        {
            setType(10);//10=帽子
            setName("绿帽子");
            setID(11);
            setWeight(0.05);
            setMaxEndurance(getRandomNum(240, 290));
            setEndurance(getRandomNum(20, 200));
            setEndurance_byStep(0.009);
            setLevel(1);
            setDescribe("带上去很受伤");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("别戴！\n魅力-5");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(2);
            setDefense(getRandomNum(6, 7));

            setAdd_charm(-5);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("绿帽子(已装备)"); }
            else { setName("绿帽子"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "终于穿破了");
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
           
            user.setHero_charm(user.getHero_charm() + getAdd_charm());
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
            user.setHero_charm(user.getHero_charm() - getAdd_charm());


        }
    }
}
