using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Map;
using myRougelikeGame.Player;
using myRougelikeGame.Mob;
using myRougelikeGame.Mob.Enemy;

namespace myRougelikeGame.Action
{
    class AddMob
    {
        
        private theHero myHero;
        private world myWorld;
        private System.Windows.Forms.ListBox MessageBox;



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




        public void AddAnMobOnRandomBlock()
        {


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
