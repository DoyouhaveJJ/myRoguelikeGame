using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Rings
{
    class ring_ToyRing:defaultItem
    {
        public ring_ToyRing()
        {
            setType(16);//16=戒指
            setName("玩具戒指");
            setID(17);
            setWeight(0.0001);
            setMaxEndurance(getRandomNum(200, 300));
            setEndurance(getRandomNum(20, 199));
            setEndurance_byStep(0.001);
            setLevel(1);
            setDescribe("哄哄小孩用的");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("来自著名的玩具生产公司\n运气+7");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(5);
            setDefense(getRandomNum(1, 7));

            setAdd_lucky(7);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("玩具戒指(已装备)"); }
            else { setName("玩具戒指"); }
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
           
            user.setHero_lucky(user.getHero_lucky() + getAdd_lucky());
           
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
            user.setHero_lucky(user.getHero_lucky() - getAdd_lucky());
           


        }
    }
}
