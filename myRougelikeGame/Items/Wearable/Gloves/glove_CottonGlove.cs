using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Gloves
{
    class glove_CottonGlove:defaultItem
    {

        public glove_CottonGlove()
        {
            setType(9);//9=手套
            setName("棉手套");
            setID(10);
            setWeight(0.1);
            setMaxEndurance(getRandomNum(140, 200));
            setEndurance(getRandomNum(20, 139));
            setEndurance_byStep(0.007);
            setLevel(1);
            setDescribe("带上去可能防止受伤");
            setCost(getRandomNum(12, 22));
            setEffecDescribe("软软的，99%棉\n耐力+8，减少攻击时消耗的精力");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(5);
            setDefense(getRandomNum(1, 7));

            setAdd_endurance(8);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("棉手套(已装备)"); }
            else { setName("棉手套"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "被你穿破了");
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
            user.setEnergyConsumeByAttack(user.getEnergyConsumeByAttack() - 3);
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
            user.setHero_endurance(user.getHero_endurance() - getAdd_endurance());
            user.setEnergyConsumeByAttack(user.getEnergyConsumeByAttack() + 3);

        }
    
    }
}
