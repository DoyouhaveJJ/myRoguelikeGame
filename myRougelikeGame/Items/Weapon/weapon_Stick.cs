using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
namespace myRougelikeGame.Items.Weapon
{
    class weapon_Stick:defaultItem
    {
        public weapon_Stick()
        {
            setType(2);//2=武器 4=双持武器
            setName("木棍");
            setID(3);
            setWeight(0.3);
            setMaxEndurance(getRandomNum(60,90));
            setEndurance(getRandomNum(30, 60));
            setEndurance_byStep(10);
            setEndurance_byAttack(2);
            setEndurance_byUse(0.5);
            setLevel(1);
            setDescribe("一根普通的木棍");
            setCost(4);
            setEffecDescribe("最好别拿它去打人。");

            setIsEquited(false);
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setMinMagicDamage(0);
            setMaxMagicDamage(0);
            setGreatDamageIndex(2);
            setHitRate(80 + getQualityIndex() / 5);
            setMinDamage(getRandomNum(1, getQualityIndex() % 4));
            setMaxDamage(getRandomNum(5, getQualityIndex() % 5 + 5));
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
            if (getIsEquited()) { setName("木棍(已装备)"); }
            else { setName("木棍"); }
        }



        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add("又短又粗的木棍断了！");
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
