using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;


namespace myRougelikeGame.Items.Food
{
    class food_Apple:defaultItem
    {
        public food_Apple(){


            setType(1);//1=食物
            setName("苹果");
            setID(1);
            setWeight(0.3);
            setMaxEndurance(getRandomNum(50,60));
            setEndurance(getRandomNum(1, 50));
            setEndurance_byStep(0.08);
            setLevel(1);
            setDescribe("一个苹果。");
            setCost(20);
            setEffecDescribe("可以充饥，顺便解渴");
            setQualityIndex((int)(getEndurance()*100/getMaxEndurance()));
            setIsEquited(false);

            updataQuality();


        }
        override public void UseItem(theHero user) {
            base.UseItem(user);
            getMessageBox().Items.Add("你吃了一个苹果\n饥饿度-" + getHungryDecrease() + "，口渴度-" + getThristyDecrease() + "\n免疫力-" + getImmDecrease() + ",精力+" + getEnergyIncrease());
            //System.Console.WriteLine("你吃了一个苹果\n饥饿度-"+getHungryDecrease()+"，口渴度-"+getThristyDecrease()+"\n免疫力-"+getImmDecrease()+",精力+"+getEnergyIncrease());
            if (user.getThirsty() - getThristyDecrease() <= 0)
                user.setThirsty(0);
            else
                user.setThirsty(user.getThirsty() - getThristyDecrease());

            if (user.getHungry() - getHungryDecrease() <= 0)
                user.setHungry(0);
            else
                user.setHungry(user.getHungry() - getHungryDecrease());

            if (user.getImmunity() - getImmDecrease() <= 0)
                user.setImmunity(0);
            else
                user.setImmunity(user.getImmunity() - getImmDecrease());
            
            if (user.getEnergy() + getEnergyIncrease() >= user.getMaxEnergy())
                user.setEnergy(user.getMaxEnergy());
            else
                user.setEnergy(user.getEnergy() + getEnergyIncrease());

            user.setPeeIncreaseIndex(user.getPeeIncreaseIndex() + getPeeIncrease());

            user.setShitIncreaseIndex(user.getShitIncreaseIndex() + getShitIncrease());


            user.destoryOneItem(this);
            user.getHeroBag().updata(user);
        }
        public override void updataQuality()
        {
            base.updataQuality();
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setHungryDecrease(5 + ((getRandomNum(getQualityIndex(), 100)) / 5));
            setHungryIncrease(0);
            setThristyDecrease(10 + ((getRandomNum(getQualityIndex(), 100)) / 4));
            setThristyIncrease(0);
            setImmDecrease(33 - ((getRandomNum(getQualityIndex(), 100)) / 3));
            setImmIncrease(0);
            setPeeIncrease(getThristyDecrease() / 2);
            setShitIncrease(getHungryDecrease() / 2);
            setEnergyIncrease(30 - ((getRandomNum(getQualityIndex(), 100)) / 4));
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "耐久为0,苹果烂掉了,败家的主角把它扔了");
                //System.Console.WriteLine(getName() + "耐久为0,苹果烂掉了,败家的主角把它扔了");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
