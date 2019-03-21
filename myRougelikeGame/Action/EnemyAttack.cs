using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Mob;
using myRougelikeGame.Player;

namespace myRougelikeGame.Action
{
    class EnemyAttack
    {
        private System.Windows.Forms.ListBox MessageBox;
        public System.Windows.Forms.ListBox getMessageBox()
        {
            return MessageBox;
        }
        public void setMessageBox(System.Windows.Forms.ListBox messageBox)
        {
            MessageBox = messageBox;
        }
        public void AttackOnce(defaultMob Mob,theHero Hero) {
            int Damage;
            switch (once()) {
                case 1: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() *((double)Hero.getHero_Chest().getDefense() / (double)(Hero.getHero_Chest().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_Chest().setEndurance(Hero.getHero_Chest().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的胸口一下，对胸口造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
                case 2: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_LeftLeg().getDefense() / (double)(Hero.getHero_LeftLeg().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_LeftLeg().setEndurance(Hero.getHero_LeftLeg().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的左腿一下，对左腿造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                
                }
                case 3: {

                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_RightLeg().getDefense() / (double)(Hero.getHero_RightLeg().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_RightLeg().setEndurance(Hero.getHero_RightLeg().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的右腿一下，对右腿造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
                case 4: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_LeftFoot().getDefense() / (double)(Hero.getHero_LeftFoot().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_LeftFoot().setEndurance(Hero.getHero_LeftFoot().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的左脚一下，对左脚造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
                case 5: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_Web().getDefense() / (double)(Hero.getHero_Web().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_Web().setEndurance(Hero.getHero_Web().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的腹部一下，对腹部造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
                case 6: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_LeftArm().getDefense() / (double)(Hero.getHero_LeftArm().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_LeftArm().setEndurance(Hero.getHero_LeftArm().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的左臂一下，对左臂造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                
                }
                case 7: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_RightArm().getDefense() / (double)(Hero.getHero_RightArm().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_RightArm().setEndurance(Hero.getHero_RightArm().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的右臂一下，对右臂造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                
                }
                case 8: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_LeftHand().getDefense() / (double)(Hero.getHero_LeftHand().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_LeftHand().setEndurance(Hero.getHero_LeftHand().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的左手一下，对左手造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                
                }
                case 9: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_RightHand().getDefense() / (double)(Hero.getHero_RightHand().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_RightHand().setEndurance(Hero.getHero_RightHand().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的右手一下，对右手造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
                case 10: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_Head().getDefense() / (double)(Hero.getHero_Head().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_Head().setEndurance(Hero.getHero_Head().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的头部一下，对头部造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
                case 11: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_Neck().getDefense() / (double)(Hero.getHero_Neck().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_Neck().setEndurance(Hero.getHero_Neck().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的脖子一下，对脖子造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
                case 12: {
                    Damage = (int)(Mob.getMob_Damage() - Mob.getMob_Damage() * ((double)Hero.getHero_RightFoot().getDefense() / (double)(Hero.getHero_RightFoot().getDefense() + Mob.getMob_Damage())));
                    Hero.getHero_RightFoot().setEndurance(Hero.getHero_RightFoot().getEndurance() - Damage);
                    Hero.setHp(Hero.getHp() - (int)(Damage * 0.5));
                    getMessageBox().Items.Add("敌人" + Mob.getMob_Name() + "攻击了你的右脚一下，对右脚造成" + Damage + "伤害，你的血量减少了" + (int)(Damage * 0.5) + "点");
                    break;
                }
            
            }
        
        }
           
        
        
        
        
        public int once()
            {
                Random myRandom = new Random();
                int i;
                i = myRandom.Next(1, 1330);
                if (i <= 200)
                {
                    return 1;//1 = 胸部
                }
                else if (i <= 400 && i>200) {//200
                    return 2;//2 = 左腿
                }
                else if (i <= 600 && i > 400)//200
                {
                    return 3;//3 = 右腿
                }
                else if (i <= 600 && i > 400)//200
                {
                    return 4;//4 = 左脚
                }
                else if (i <= 750 && i > 600)//150
                {
                    return 5;//5=腹部
                }
                else if(i <= 850 && i > 750)//100
                {
                    return 6;//6=左臂
                }
                else if(i <= 950 && i > 850)//100
                {
                    return 7;//7=右臂
                }
                else if(i <= 1000 && i > 950)//50
                {   
                    return 8;//8=左手
                }
                else if(i <= 1050 && i > 1000)//50
                {
                    return 9;//9=右手
                }
                else if(i<= 1100 && i>1050){//50
                    return 10;//10=头部
                }
                else if(i <= 1130 && i > 1100){//30
                    return 11;//11=脖子
                }
                else if(i <= 1330 && i > 1130){//200
                    return 12;//12=右脚
                }else{
                    return 1;
                }
           }
    }
}





