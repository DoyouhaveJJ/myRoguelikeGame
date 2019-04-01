using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using myRougelikeGame.Items;
using myRougelikeGame.Loot;
using myRougelikeGame.Mob;

namespace myRougelikeGame.Map
{
    class defaultBlock
    {
        private string name;
        private int ID;
        private int type;
        private ArrayList itemInGround = new ArrayList();
        private defaultLoot blockLoot;
        private ArrayList mob_list = new ArrayList();
        private int mob_Count;

        private int loc_x;
        private int loc_y;

        public int getMob_Count()
        {
            return mob_Count;
        }

        public void setMob_Count(int mob_Count)
        {
            this.mob_Count = mob_Count;
        }


        public ArrayList getItemInGround()
        {
            return itemInGround;
        }


        public defaultLoot getBlockLoot()
        {
            return blockLoot;
        }

        public void setBlockLoot(defaultLoot blockLoot)
        {
            this.blockLoot = blockLoot;
        }
        public void setItemInGround(ArrayList itemInGround)
        {
            this.itemInGround = itemInGround;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getID()
        {
            return ID;
        }
        public void setID(int iD)
        {
            ID = iD;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }


        public ArrayList getMob_list()
        {
            return mob_list;
        }

        public void setMob_list(ArrayList mob_list)
        {
            this.mob_list = mob_list;
        }


        public int getLoc_x()
        {
            return loc_x;
        }
        public void setLoc_x(int loc_x)
        {
            this.loc_x = loc_x;
        }
        public int getLoc_y()
        {
            return loc_y;
        }
        public void setLoc_y(int loc_y)
        {
            this.loc_y = loc_y;
        }
        

    }
}
