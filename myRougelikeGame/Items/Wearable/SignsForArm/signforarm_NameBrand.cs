using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.SignsForArm
{
    class signforarm_NameBrand:defaultItem
    {
         public signforarm_NameBrand()
        {
            setType(18);//18=臂章
            setName("姓名臂章");
            setID(19);
            setWeight(0.001);
            setMaxEndurance(getRandomNum(100, 200));
            setEndurance(getRandomNum(70, 99));
            setEndurance_byStep(0.1);
            setLevel(1);
            setDescribe("上面没有字");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("戴上去没什么用\n魅力+1");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(8);
            setDefense(getRandomNum(6, 7));

            setAdd_charm(1);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("姓名臂章(已装备)"); }
            else { setName("姓名臂章"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "烂了");
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
