using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Function;
using myRougelikeGame.Items;
using myRougelikeGame.Items.Food;
using myRougelikeGame.Items.Weapon;
using myRougelikeGame.Items.Wearable.BagForHand;
using myRougelikeGame.Mob;

namespace myRougelikeGame.Action
{
    class HeroAttack
    {
        private System.Windows.Forms.ListBox MessageBox;
        private DIYRandom dr = new DIYRandom();
        public System.Windows.Forms.ListBox getMessageBox()
        {
            return MessageBox;
        }

        public void setMessageBox(System.Windows.Forms.ListBox messageBox)
        {
            MessageBox = messageBox;
        }
        public void AttackEnemy(theHero myHero,defaultMob Enemy,int AttackType) {
            switch(AttackType){

                case 1:{
                    Enemy.setMob_Hp(Enemy.getMob_Hp() - AttackByLeftHand(myHero));
                    break;
                    }
                case 2: {
                    Enemy.setMob_Hp(Enemy.getMob_Hp() - AttackByRightHand(myHero));
                    break;
                }
                case 3: {
                    Enemy.setMob_Hp(Enemy.getMob_Hp() - AttackByLeftHandByMagic(myHero));
                    break;
                }
                case 4: {
                    Enemy.setMob_Hp(Enemy.getMob_Hp() - AttackByRightHandByMagic(myHero));
                    break;
                }
                case 5: {
                    Enemy.setMob_Hp(Enemy.getMob_Hp() - AttackByBothHand(myHero));
                    break;
                }
                case 6: {
                    Enemy.setMob_Hp(Enemy.getMob_Hp() - AttackByBothHandByMagic(myHero));
                    break;
                }

        
        }
            
        }





        public int AttackByLeftHand(theHero myHero) {
            if (myHero.isOutOfEnergy(1)) { getMessageBox().Items.Add("没有多余的精力来攻击了！"); return 0; }
            int Damage;
            if (myHero.getHero_LeftHand().getIsEquipedSomething())
            {
                switch (myHero.getHero_LeftHand().getTakeInHand().getType())
                {
                    case 2:
                        { //单手武器
                            Damage = (int)(myHero.getHero_strength() * 0.5) + dr.getRandomNum(myHero.getHero_LeftHand().getTakeInHand().getMinDamage(), myHero.getHero_LeftHand().getTakeInHand().getMaxDamage());
                            if (!dr.startBet(myHero.getHero_LeftHand().getTakeInHand().getHitRate(), 100))
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次，但没打中");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次，但没打中");
                                return 0;
                            }

                            if (dr.startBet(myHero.getHero_LeftHand().getTakeInHand().getGreatDamageRate(), 100))
                            {
                                Damage = Damage * myHero.getHero_LeftHand().getTakeInHand().getGreatDamageIndex();
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次，居然出现了暴击！\n造成了" + Damage + "点伤害");
                                // System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次，居然出现了暴击！\n造成了" + Damage + "点伤害");
                            }
                            else
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次\n造成了" + Damage + "点伤害");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次\n造成了" + Damage + "点伤害");
                            }
                            myHero.getHero_LeftHand().getTakeInHand().decreaseEnduranceByAttack();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.attackCauseDecreaseEnergy();
                            return Damage;
                        }
                    case 3:
                        {
                            Damage = (int)(myHero.getHero_strength() * 0.3);
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手打了一次，\n造成了" + Damage + "点伤害");
                            //System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手打了一次，\n造成了" + Damage + "点伤害");
                            myHero.getHero_LeftHand().getTakeInHand().DecreaseEndurance();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.attackCauseDecreaseEnergy();
                            return Damage;
                        }
                    case 4:
                        {
                            getMessageBox().Items.Add("双手武器不能单手用啦");
                            // System.Console.WriteLine("双手武器不能单手用啦");
                            return 0;
                        }
                    default: return 0;

                }

            }
            else
            {
                Damage = (int)(myHero.getHero_strength() * 0.2);
                getMessageBox().Items.Add("你用左手拳头打了一拳，\n造成了" + Damage + "点伤害");
                // System.Console.WriteLine("你用左手拳头打了一拳，\n造成了" + Damage + "点伤害");
                myHero.attackCauseDecreaseEnergy();
                return Damage;
            }
        
        }
        public int AttackByLeftHandByMagic(theHero myHero)
        {
            if (myHero.isOutOfEnergy(1)) return 0;
            int magicDamage;
            if (myHero.getHero_LeftHand().getIsEquipedSomething())
            {
                switch (myHero.getHero_LeftHand().getTakeInHand().getType())
                {
                    case 2:
                        { //单手武器
                            magicDamage = (int)(myHero.getHero_iq() * 0.5) + dr.getRandomNum(myHero.getHero_LeftHand().getTakeInHand().getMinMagicDamage(), myHero.getHero_LeftHand().getTakeInHand().getMaxMagicDamage());
                            if (!dr.startBet(myHero.getHero_LeftHand().getTakeInHand().getHitRate(), 100))
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次，但没打中");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手攻击了一次，但没打中");
                                return 0;
                            }
                            if (dr.startBet(myHero.getHero_LeftHand().getTakeInHand().getGreatDamageRate(), 100))
                            {
                                magicDamage = magicDamage * myHero.getHero_LeftHand().getTakeInHand().getGreatDamageIndex();
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手魔法了一次，居然出现了暴击！\n造成了" + magicDamage + "点伤害");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手魔法了一次，居然出现了暴击！\n造成了" + magicDamage + "点伤害");
                            }
                            else
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手魔法了一次\n造成了" + magicDamage + "点伤害");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手魔法了一次\n造成了" + magicDamage + "点伤害");
                            }
                            myHero.getHero_LeftHand().getTakeInHand().decreaseEnduranceByAttack();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.attackCauseDecreaseEnergy();
                            return magicDamage;
                        }
                    case 3:
                        {    
                            magicDamage = (int)(myHero.getHero_iq() * 0.25);
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手搞了一次魔法，\n造成了" + magicDamage + "点伤害");
                            //System.Console.WriteLine("你用拿着" + myHero.getHero_LeftHand().getTakeInHand().getName() + "的左手打了一次，\n造成了" + Damage + "点伤害");
                            myHero.getHero_LeftHand().getTakeInHand().DecreaseEndurance();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.magicCauseDecreaseEnergy();
                            return magicDamage;
                        }
                    case 4:
                        {
                            getMessageBox().Items.Add("双手武器不能单手用啦");
                            // System.Console.WriteLine("双手武器不能单手用啦");
                            return 0;
                        }
                    default: return 0;

                }

            }
            else
            {
                magicDamage = (int)(myHero.getHero_iq() * 0.2);
                getMessageBox().Items.Add("你用左手拳头搞了一次魔法，\n造成了" + magicDamage + "点伤害");
                // System.Console.WriteLine("你用左手拳头打了一拳，\n造成了" + Damage + "点伤害");
                myHero.magicCauseDecreaseEnergy();
                return magicDamage;
            }

        }
        public int AttackByRightHand(theHero myHero)
        {
            if (myHero.isOutOfEnergy(1)) return 0;
            int Damage;
            if (myHero.getHero_RightHand().getIsEquipedSomething())
            {
                switch (myHero.getHero_RightHand().getTakeInHand().getType())
                {
                    case 2:
                        { //单手武器
                            Damage = (int)(myHero.getHero_strength() * 0.5) + dr.getRandomNum(myHero.getHero_RightHand().getTakeInHand().getMinDamage(), myHero.getHero_RightHand().getTakeInHand().getMaxDamage());
                            if (!dr.startBet(myHero.getHero_RightHand().getTakeInHand().getHitRate(), 100))
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次，但没打中");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次，但没打中");
                                return 0;
                            }

                            if (dr.startBet(myHero.getHero_RightHand().getTakeInHand().getGreatDamageRate(), 100))
                            {
                                Damage = Damage * myHero.getHero_RightHand().getTakeInHand().getGreatDamageIndex();
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次，居然出现了暴击！\n造成了" + Damage + "点伤害");
                                // System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次，居然出现了暴击！\n造成了" + Damage + "点伤害");
                            }
                            else
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次\n造成了" + Damage + "点伤害");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次\n造成了" + Damage + "点伤害");
                            }
                            myHero.getHero_RightHand().getTakeInHand().decreaseEnduranceByAttack();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.attackCauseDecreaseEnergy();
                            return Damage;
                        }
                    case 3:
                        {
                            Damage = (int)(myHero.getHero_strength() * 0.3);
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手打了一次，\n造成了" + Damage + "点伤害");
                            //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手打了一次，\n造成了" + Damage + "点伤害");
                            myHero.getHero_RightHand().getTakeInHand().DecreaseEndurance();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.attackCauseDecreaseEnergy();
                            return Damage;
                        }
                    case 4:
                        {
                            getMessageBox().Items.Add("双手武器不能单手用啦");
                            // System.Console.WriteLine("双手武器不能单手用啦");
                            return 0;
                        }
                    default: return 0;

                }

            }
            else
            {
                Damage = (int)(myHero.getHero_strength() * 0.2);
                getMessageBox().Items.Add("你用右手拳头打了一拳，\n造成了" + Damage + "点伤害");
                // System.Console.WriteLine("你用右手拳头打了一拳，\n造成了" + Damage + "点伤害");
                myHero.attackCauseDecreaseEnergy();
                return Damage;
            }

        }
        public int AttackByRightHandByMagic(theHero myHero)
        {
            if (myHero.isOutOfEnergy(1)) return 0;
            int magicDamage;
            if (myHero.getHero_RightHand().getIsEquipedSomething())
            {
                switch (myHero.getHero_RightHand().getTakeInHand().getType())
                {
                    case 2:
                        { //单手武器
                            magicDamage = (int)(myHero.getHero_iq() * 0.5) + dr.getRandomNum(myHero.getHero_RightHand().getTakeInHand().getMinMagicDamage(), myHero.getHero_RightHand().getTakeInHand().getMaxMagicDamage());
                            if (!dr.startBet(myHero.getHero_RightHand().getTakeInHand().getHitRate(), 100))
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次，但没打中");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手攻击了一次，但没打中");
                                return 0;
                            }
                            if (dr.startBet(myHero.getHero_RightHand().getTakeInHand().getGreatDamageRate(), 100))
                            {
                                magicDamage = magicDamage * myHero.getHero_RightHand().getTakeInHand().getGreatDamageIndex();
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手魔法了一次，居然出现了暴击！\n造成了" + magicDamage + "点伤害");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手魔法了一次，居然出现了暴击！\n造成了" + magicDamage + "点伤害");
                            }
                            else
                            {
                                getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手魔法了一次\n造成了" + magicDamage + "点伤害");
                                //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手魔法了一次\n造成了" + magicDamage + "点伤害");
                            }
                            myHero.getHero_RightHand().getTakeInHand().decreaseEnduranceByAttack();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.attackCauseDecreaseEnergy();
                            return magicDamage;
                        }
                    case 3:
                        {
                            magicDamage = (int)(myHero.getHero_iq() * 0.25);
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手搞了一次魔法，\n造成了" + magicDamage + "点伤害");
                            //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的右手打了一次，\n造成了" + Damage + "点伤害");
                            myHero.getHero_RightHand().getTakeInHand().DecreaseEndurance();
                            myHero.getHeroBag().checkItems();
                            myHero.getHeroBag().updata(myHero);
                            myHero.magicCauseDecreaseEnergy();
                            return magicDamage;
                        }
                    case 4:
                        {
                            getMessageBox().Items.Add("双手武器不能单手用啦");
                            // System.Console.WriteLine("双手武器不能单手用啦");
                            return 0;
                        }
                    default: return 0;

                }

            }
            else
            {
                magicDamage = (int)(myHero.getHero_iq() * 0.2);
                getMessageBox().Items.Add("你用右手拳头搞了一次魔法，\n造成了" + magicDamage + "点伤害");
                // System.Console.WriteLine("你用右手拳头打了一拳，\n造成了" + Damage + "点伤害");
                myHero.magicCauseDecreaseEnergy();
                return magicDamage;
            }

        }
        public int AttackByBothHand(theHero myHero) {
            if (myHero.isOutOfEnergy(1)) return 0;
            int Damage = 0;
            if (myHero.getHero_LeftHand().getIsEquipedSomething() && myHero.getHero_RightHand().getIsEquipedSomething())
            {
                if (myHero.getHero_LeftHand().getTakeInHand() == myHero.getHero_RightHand().getTakeInHand())
                    if (myHero.getHero_LeftHand().getTakeInHand().getType() == 4)
                    {
                        Damage = (int)(myHero.getHero_strength() * 0.8) + dr.getRandomNum(myHero.getHero_RightHand().getTakeInHand().getMinDamage(), myHero.getHero_RightHand().getTakeInHand().getMaxDamage());
                       // magicDamage = (int)(myHero.getHero_iq() * 0.8) + dr.getRandomNum(myHero.getHero_RightHand().getTakeInHand().getMinMagicDamage(), myHero.getHero_RightHand().getTakeInHand().getMaxMagicDamage());
                        if (!dr.startBet(myHero.getHero_RightHand().getTakeInHand().getHitRate(), 100))
                        {
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手攻击了一次，但没打中");
                            //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手攻击了一次，但没打中");
                            return 0;
                        }

                        if (dr.startBet(myHero.getHero_RightHand().getTakeInHand().getGreatDamageRate(), 100))
                        {
                            Damage = Damage * myHero.getHero_RightHand().getTakeInHand().getGreatDamageIndex();
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手攻击了一次，居然出现了暴击！\n造成了" + Damage + "点伤害");
                            // System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手攻击了一次，居然出现了暴击！\n造成了" + Damage + "点伤害");
                        }
                        else
                        {
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手攻击了一次\n造成了" + Damage + "点伤害");
                            // System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手攻击了一次\n造成了" + Damage + "点伤害");
                        }
                        myHero.getHero_LeftHand().getTakeInHand().decreaseEnduranceByAttack();
                        myHero.getHeroBag().checkItems();
                        myHero.getHeroBag().updata(myHero);
                        myHero.attackCauseDecreaseEnergy();
                        return Damage;

                    }
            }
            getMessageBox().Items.Add("必须要有双手武器才能双手攻击");
            // System.Console.WriteLine("必须要有双手武器才能双手攻击");

            return 0;
        }
        public int AttackByBothHandByMagic(theHero myHero)
        {
            if (myHero.isOutOfEnergy(1)) return 0;
            int magicDamage = 0;
            if (myHero.getHero_LeftHand().getIsEquipedSomething() && myHero.getHero_RightHand().getIsEquipedSomething())
            {
                if (myHero.getHero_LeftHand().getTakeInHand() == myHero.getHero_RightHand().getTakeInHand())
                    if (myHero.getHero_LeftHand().getTakeInHand().getType() == 4)
                    {
                        //Damage = (int)(myHero.getHero_strength() * 0.8) + dr.getRandomNum(myHero.getHero_RightHand().getTakeInHand().getMinDamage(), myHero.getHero_RightHand().getTakeInHand().getMaxDamage());
                        magicDamage = (int)(myHero.getHero_iq() * 0.8) + dr.getRandomNum(myHero.getHero_RightHand().getTakeInHand().getMinMagicDamage(), myHero.getHero_RightHand().getTakeInHand().getMaxMagicDamage());
                        if (!dr.startBet(myHero.getHero_RightHand().getTakeInHand().getHitRate(), 100))
                        {
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手魔法了一次，但没打中");
                            //System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手攻击了一次，但没打中");
                            return 0;
                        }
                        if (dr.startBet(myHero.getHero_RightHand().getTakeInHand().getGreatDamageRate(), 100))
                        {
                            magicDamage = magicDamage * myHero.getHero_RightHand().getTakeInHand().getGreatDamageIndex();
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手魔法了一次，居然出现了暴击！\n造成了" + magicDamage + "点伤害");
                            // System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手魔法了一次，居然出现了暴击！\n造成了" + magicDamage + "点伤害");
                        }
                        else
                        {
                            getMessageBox().Items.Add("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手魔法了一次\n造成了" + magicDamage + "点伤害");
                            // System.Console.WriteLine("你用拿着" + myHero.getHero_RightHand().getTakeInHand().getName() + "的双手魔法了一次\n造成了" + magicDamage + "点伤害");
                        }
                        myHero.getHero_LeftHand().getTakeInHand().decreaseEnduranceByAttack();
                        myHero.getHeroBag().checkItems();
                        myHero.getHeroBag().updata(myHero);
                        myHero.magicCauseDecreaseEnergy();
                        return magicDamage;

                    }
            }
            getMessageBox().Items.Add("必须要有双手武器才能双手攻击");
            // System.Console.WriteLine("必须要有双手武器才能双手攻击");

            return 0;
        }


    }
}
