using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Function;

namespace myRougelikeGame.Action
{
    class HeroLevelUp
    {
        DIYRandom dr = new DIYRandom();
        int i = 0;
        public void LevelUp(theHero hero,System.Windows.Forms.ListBox Msg){
            Msg.Items.Add("恭喜升级!你升到了"+hero.getLevel());
            if(dr.startBet(1 , 5)){
               i = dr.getRandomNum(1, 3);
                hero.setHero_strength(hero.getHero_strength() + i);
                Msg.Items.Add("力量+" + i);
            }
            if (dr.startBet(1 , 5)) {
                i = dr.getRandomNum(1, 3);
                hero.setHero_iq(hero.getHero_iq() + i);
                Msg.Items.Add("智商+" + i);
            }
            if (dr.startBet(1 , 5))
            {
                i = dr.getRandomNum(1, 3);
                hero.setHero_lucky(hero.getHero_lucky() + i);
                Msg.Items.Add("幸运+" + i);
            }
            if (dr.startBet(1 , 5))
            {
                i = dr.getRandomNum(1, 3);
                hero.setHero_charm(hero.getHero_charm() +i);
                Msg.Items.Add("魅力+" + i);
            }
            if (dr.startBet(1 , 5))
            {
                i = dr.getRandomNum(1, 3);
                hero.setHero_agility(hero.getHero_agility() +i);
                Msg.Items.Add("敏捷+" + i);
            }
            if (dr.startBet(1 , 5))
            {
                i = dr.getRandomNum(1, 3);
                hero.setHero_face(hero.getHero_face() + i);
                Msg.Items.Add("颜值+" + i);
            }
            if (dr.startBet(1 , 5))
            {
                i = dr.getRandomNum(1, 3);
                hero.setHero_eq(hero.getHero_eq() + i);
                Msg.Items.Add("情商+" + i);
            }
            if (dr.startBet(1 , 5))
            {
                i = dr.getRandomNum(1, 3);
                hero.setHero_talk(hero.getHero_talk() + i);
                Msg.Items.Add("口才+" + i);
            }
            if (dr.startBet(1 , 5))
            {
                i = dr.getRandomNum(1, 3);
                hero.setHero_endurance(hero.getHero_endurance() + i);
                Msg.Items.Add("耐力+" + i);
            }
            hero.setMaxHp(hero.getMaxHp() + (int)(hero.getHero_endurance() * 0.05));
            hero.setMaxHungry(hero.getMaxHungry() + (int)(hero.getHero_endurance() * 0.04));
            hero.setMaxThirsty(hero.getMaxThirsty() + (int)(hero.getHero_endurance() * 0.04));
            hero.setMaxImmunity(hero.getMaxImmunity() + (int)(hero.getHero_endurance() * 0.03 + hero.getHero_eq() * 0.03));
            hero.setMaxBlood(hero.getMaxBlood() + (int)(hero.getHero_strength() * 0.04 + hero.getHero_iq()));
            hero.setMaxPain(hero.getMaxPain() + (int)(hero.getHero_endurance() * 0.02 + hero.getHero_strength() * 0.03));
            hero.setMaxEnergy(hero.getMaxEnergy() + (int)(hero.getHero_agility() * 0.05 + hero.getHero_strength() * 0.04));




        }
    }
}
