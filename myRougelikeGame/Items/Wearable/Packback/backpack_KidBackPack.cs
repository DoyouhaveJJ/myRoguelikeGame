using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Packback
{
    class backpack_KidBackPack:defaultItem
    {
        public backpack_KidBackPack()
        {
            setType(13);//13=背包
            setName("儿童书包");
            setID(14);
            setWeight(0.6);
            setMaxEndurance(getRandomNum(332, 542));
            setEndurance(getRandomNum(10, 331));
            setEndurance_byStep(0.055);
            setLevel(1);
            setDescribe("给小学生设计的");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("凑合着用用吧！\n容量+20");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);


            setRoom(20);
            setIsEquited(false);
            setMagicDefense(1);
            setDefense(getRandomNum(1, 2));

            
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("儿童书包(已装备)"); }
            else { setName("儿童书包"); }
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
           
           // user.setHero_endurance(user.getHero_endurance() + getAdd_endurance());
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
          //  user.setHero_endurance(user.getHero_endurance() - getAdd_endurance());


        }
    }
}
