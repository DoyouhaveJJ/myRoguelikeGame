using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Pocked
{
    class pocked_SmallPocked:defaultItem
    {
        public pocked_SmallPocked()
        {
            setType(15);//15=腰包
            setName("小腰包");
            setID(16);
            setWeight(0.1);
            setMaxEndurance(getRandomNum(132, 242));
            setEndurance(getRandomNum(10, 131));
            setEndurance_byStep(0.055);
            setLevel(1);
            setDescribe("能装东西很不错了");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("凑合着用用吧！\n容量+10");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);


            setRoom(10);
            setIsEquited(false);
            setMagicDefense(1);
            setDefense(getRandomNum(1, 2));

            
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("小腰包(已装备)"); }
            else { setName("小腰包"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "破了个洞");
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
           
           // user.setHero_endurance(user.getHero_endurance() + getAdd_endurance());
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
          //  user.setHero_endurance(user.getHero_endurance() - getAdd_endurance());


        }
    }
}
