using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using myRougelikeGame.Items;
using myRougelikeGame.Loot;

namespace myRougelikeGame.Map
{
    class defaultBlock
    {
        private string name;
        private int ID;
        private int type;
        private ArrayList itemInGround = new ArrayList();
        private defaultLoot blockLoot;


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

    }
}
