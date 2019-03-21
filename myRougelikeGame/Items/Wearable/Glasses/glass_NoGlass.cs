using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Glasses
{
    class glass_NoGlass:defaultItem
    {
        public glass_NoGlass() {
            setType(8);//8=眼镜
            setName("无镜片眼镜");
            setID(9);
            setWeight(0.05);
            setMaxEndurance(getRandomNum(200, 300));
            setEndurance(getRandomNum(40, 199));
            setEndurance_byStep(0.005);
            setLevel(1);
            setDescribe("并不能改变视力");
            setCost(getRandomNum(12, 22));
            setEffecDescribe("带上去只能增加鼻子负担\n魅力+4颜值+2耐力-2");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(1);
            setDefense(getRandomNum(1, 2));

            setAdd_face(2);
            setAdd_charm(4);
            setAdd_endurance(-2);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("无镜片眼镜(已装备)"); }
            else { setName("无镜片眼镜"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "坏掉了");
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
            user.setHero_face(user.getHero_face() + getAdd_face());
            user.setHero_endurance(user.getHero_endurance() + getAdd_endurance());
            user.setHero_charm(user.getHero_charm() + getAdd_charm());
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
            user.setHero_face(user.getHero_face() - getAdd_face());
            user.setHero_endurance(user.getHero_endurance() - getAdd_endurance());
            user.setHero_charm(user.getHero_charm() - getAdd_charm());

        }
    }

}
