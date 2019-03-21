using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Earplugs
{
    class earplug_Runner:defaultItem
    {
        public earplug_Runner() {
            setType(7);//7=耳部挂件
            setName("跑步者耳机");
            setID(8);
            setWeight(0.1);
            setMaxEndurance(getRandomNum(100, 120));
            setEndurance(getRandomNum(70, 99));
            setEndurance_byStep(0.005);
            setLevel(1);
            setDescribe("戴上去好像可以听到音乐？");
            setCost(getRandomNum(22, 44));
            setEffecDescribe("某国生产\n魅力+7颜值+5敏捷-3");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(1);
            setDefense(getRandomNum(1, 2));

            setAdd_charm(7);
            setAdd_face(5);
            setAdd_agility(-3);
        
        }
        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("跑步者耳机(已装备)"); }
            else { setName("跑步者耳机"); }
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
            user.setHero_agility(user.getHero_agility() + getAdd_agility());
            user.setHero_charm(user.getHero_charm() + getAdd_charm());
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
            user.setHero_face(user.getHero_face() - getAdd_face());
            user.setHero_agility(user.getHero_agility() - getAdd_agility());
            user.setHero_charm(user.getHero_charm() - getAdd_charm());
            
        }
    }
}
