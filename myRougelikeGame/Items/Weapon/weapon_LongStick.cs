using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
namespace myRougelikeGame.Items.Weapon
{
    class weapon_LongStick:defaultItem
    {
        public weapon_LongStick(){
        setType(4);//2=武器 4=双持武器
            setName("长棍");
            setID(5);
            setWeight(1);
            setMaxEndurance(getRandomNum(90,130));
            setEndurance(getRandomNum(40, 90));
            setEndurance_byStep(0.05);
            setEndurance_byAttack(2);
            setEndurance_byUse(0.5);
            setLevel(2);
            setDescribe("一根很长的木棍");
            setCost(10);
            setEffecDescribe("必须双手拿。");

            setIsEquited(false);
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setMinMagicDamage(0);
            setMaxMagicDamage(0);
            setGreatDamageIndex(2);
            setHitRate(80 + getQualityIndex() / 5);
            setMinDamage(getRandomNum(2, getQualityIndex() % 4+2));
            setMaxDamage(getRandomNum(6, getQualityIndex() % 5 + 5));
            setGreatDamageRate(getRandomNum(5, 5 + getQualityIndex() / 15));
        }

    
        public override void UseItem(theHero user)
        {
            base.UseItem(user);
            decreaseEnduranceByUse();
            getMessageBox().Items.Add("什么事都没发生，白白浪费耐久，你傻！");
            //System.Console.WriteLine("什么事都没发生，白白浪费耐久，你傻！");
        }



        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("长棍(已装备)"); }
            else { setName("长棍"); }
        }



        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add("又长又细的长棍断了！");
               // System.Console.WriteLine(getName() + "又长又细的木棍断了！");
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
