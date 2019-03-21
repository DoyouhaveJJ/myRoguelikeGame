using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;

namespace myRougelikeGame.Items.Food
{
    class food_rawWater:defaultItem
    {
        public food_rawWater(){
            setType(1);
            setName("生水");
            setWeight(0.4);
            setMaxEndurance(getRandomNum(100,130));
            setEndurance(getRandomNum(10, 100));
            setEndurance_byStep(0.05);
            setLevel(1);
            setDescribe("在湖水中大片可见的生水，直接喝会出事情。");
            setCost(0);
            setEffecDescribe("减少20口渴度，减少3免疫值");
            setIsEquited(false);
            updataQuality();
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));

         }
        public override void UseItem(theHero user)
        {
            base.UseItem(user);
            getMessageBox().Items.Add("你喝了生水\n口渴度-" + getThristyDecrease() + "，免疫力-" + getImmDecrease() + "");
            //System.Console.WriteLine("你喝了生水\n口渴度-"+getThristyDecrease()+"，免疫力-"+getImmDecrease()+"");
            if (user.getThirsty() - getThristyDecrease() <= 0) 
                user.setThirsty(0);
            else
                user.setThirsty(user.getThirsty() - getThristyDecrease());

            if (user.getImmunity() - getImmDecrease() <= 0)
                user.setImmunity(0);
            else
                user.setImmunity(user.getImmunity() - getImmDecrease());

            user.setPeeIncreaseIndex(user.getPeeIncreaseIndex() + getPeeIncrease());

            user.setShitIncreaseIndex(user.getShitIncreaseIndex() + getShitIncrease());

            user.destoryOneItem(this);
            user.getHeroBag().updata(user);
        }

        public override void updataQuality()
        {
            base.updataQuality();
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setHungryDecrease(0);
            setHungryIncrease(0);
            setThristyDecrease(40 + ((getRandomNum(getQualityIndex(), 100)) / 4));
            setThristyIncrease(0);
            setImmDecrease(50 - ((getRandomNum(getQualityIndex(), 100)) / 3));
            setImmIncrease(0);
            setPeeIncrease(getThristyDecrease() / 2 + 5);
            setShitIncrease(getHungryDecrease() / 2);
            setEnergyIncrease(0);
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "耐久为0了,于是它损坏了,败家的主角把生水扔了");
                //System.Console.WriteLine(getName() + "耐久为0了,于是它损坏了,败家的主角把生水扔了");
                return true;
              
            }
            else {
                return false;
            }
        }

        

    }
}
