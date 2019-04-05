using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
namespace myRougelikeGame.Items.Weapon
{
    class weapon_BoneStick:defaultItem
    {
        public weapon_BoneStick()
        {
            setType(2);//2=武器 4=双持武器
            setName("骨棍");
            setID(27);
            setWeight(1);
            setMaxEndurance(getRandomNum(300,301));
            setEndurance(getRandomNum(298, 299));
            setEndurance_byStep(0.03);
            setEndurance_byAttack(1.5);
            setEndurance_byUse(0.5);
            setLevel(1);
            setDescribe("一根坚硬的骨头棒子");
            setCost(20);
            setEffecDescribe("上面还沾有血迹。");

            setIsEquited(false);
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setMinMagicDamage(1);
            setMaxMagicDamage(4);
            setGreatDamageIndex(2);
            setHitRate(70 + getQualityIndex() / 5);
            setMinDamage(getRandomNum(1, getQualityIndex() % 8));
            setMaxDamage(getRandomNum(10, getQualityIndex() % 5 + 10));
            setGreatDamageRate(getRandomNum(5, 5 + getQualityIndex() / 15));
        }


        public override void UseItem(theHero user)
        {
            base.UseItem(user);
            decreaseEnduranceByUse();
            getMessageBox().Items.Add("什么事都没发生，白白浪费耐久，你傻！");
           // System.Console.WriteLine("什么事都没发生，白白浪费耐久，你傻！");
        }



        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("骨棍(已装备)"); }
            else { setName("骨棍"); }
        }



        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add("咔嚓，你的骨棍断了！");
                //System.Console.WriteLine(getName() + "又短又粗的木棍断了！");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AttackByUse() {
            System.Console.WriteLine("攻击了一下");
        }
    }
}
