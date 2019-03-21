using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Shoes
{
    class shoes_Slippers:defaultItem
    {
        public shoes_Slippers()
        {
            setType(17);//17=鞋子
            setName("拖鞋");
            setID(18);
            setWeight(0.5);
            setMaxEndurance(getRandomNum(200, 300));
            setEndurance(getRandomNum(70, 199));
            setEndurance_byStep(0.1);
            setLevel(1);
            setDescribe("走着走着就掉了怎么办");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("全地形宝马拖孩\n敏捷+2,减少移动消耗的精力");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(8);
            setDefense(getRandomNum(6, 7));

            setAdd_agility(2);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("拖鞋(已装备)"); }
            else { setName("拖鞋"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "破了");
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
            user.setEnergyConsumeByMove(user.getEnergyConsumeByMove() - 1);
           
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
            user.setHero_agility(user.getHero_agility() - getAdd_agility());
            user.setEnergyConsumeByMove(user.getEnergyConsumeByMove() + 1);
           


        }
    }
}
