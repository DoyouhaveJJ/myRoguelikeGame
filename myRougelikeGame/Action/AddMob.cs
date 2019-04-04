using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Map;
using myRougelikeGame.Player;
using myRougelikeGame.Mob;
using myRougelikeGame.Mob.Enemy;
using myRougelikeGame.Function;

namespace myRougelikeGame.Action
{
    class AddMob
    {
        
        private theHero myHero;
        private world myWorld;
        private System.Windows.Forms.ListBox MessageBox;
        private DIYRandom dr = new DIYRandom();


        public defaultMob InitMobByID(int ID)
        {
            defaultMob a;
            switch (ID)
            {
                case 1:
                    {
                        a = new enemy_Slime();
                        return a;
                    }
                case 2:
                    {
                        a = new enemy_Goblin();
                        return a;
                    }
                default:
                    {
                        return null;
                    }

                    
            }

        }



        //在英雄的 range*range周围生成怪物 随机的 index概率
        public void AddAnMobOnRandomBlockNearbyHero(int range , int index , int maxIndex)
        {
            int x, y;
            int mob_ID;
            x = getMyHero().getLoc_x();
            y = getMyHero().getLoc_y();
            for (int i = (((x - range) <= 0) ? 0 : x - range); i < (((x + range) >= 399) ? 399 : x + range); i++) 
            {
                for (int j = (((y - range) <= 0) ? 0 : y - range); j < (((y + range) >= 399) ? 399 : y + range); j++)
                {
                    if (dr.startBet(index, maxIndex))
                    {
                        mob_ID = dr.getRandomNum(1, 2);
                        defaultMob newMob = InitMobByID(mob_ID);
                        getMyWorld().getBlockByXY(i, j).getMob_list().Add(newMob);
                        getMyWorld().getBlockByXY(i, j).setMob_Count(getMyWorld().getBlockByXY(i, j).getMob_Count()+1);
                        getMessageBox().Items.Add("在"+i+","+j+"位置生成了一只"+newMob.getMob_Name());
                    }
                }
            }
        }




        public System.Windows.Forms.ListBox getMessageBox()
        {
            return MessageBox;
        }

        public void setMessageBox(System.Windows.Forms.ListBox messageBox)
        {
            MessageBox = messageBox;
        }

        public theHero getMyHero()
        {
            return myHero;
        }
        public void setMyHero(theHero myHero)
        {
            this.myHero = myHero;
        }
        public world getMyWorld()
        {
            return myWorld;
        }
        public void setMyWorld(world myWorld)
        {
            this.myWorld = myWorld;
        }

    }
}
