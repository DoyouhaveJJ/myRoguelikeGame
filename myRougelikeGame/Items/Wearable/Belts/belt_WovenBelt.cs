using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Belts
{
    class belt_WovenBelt:defaultItem
    {
        public belt_WovenBelt() {
            setType(5);//5=腰带
            setName("帆布腰带");
            setID(6);
            setWeight(0.3);
            setMaxEndurance(getRandomNum(130, 200));
            setEndurance(getRandomNum(70, 130));
            setEndurance_byStep(0.005);
            setLevel(1);
            setDescribe("帆布腰带，可以用用。");
            setCost(15);
            setEffecDescribe("戴在腰上，可能有点用，尤其是饿了的时候\n耐久+3");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setRoom(3);
            setIsEquited(false);;
            setMagicDefense(2);
            setDefense(getRandomNum(4,7));


            setAdd_endurance(3);
        
        }
        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("帆布腰带(已装备)"); }
            else { setName("帆布腰带"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "被你的大肚子崩断了");
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
