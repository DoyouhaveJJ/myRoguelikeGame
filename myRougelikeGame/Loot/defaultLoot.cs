using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Map;
using myRougelikeGame.Player;
using System.Collections;
using myRougelikeGame.Action;

namespace myRougelikeGame.Loot
{
    class defaultLoot
    {
        private Random randomNum = new Random();
        private int lootIndex;
        private int maxLootIndex;
        private defaultBlock theBlock;
        private theHero hero;
        private ArrayList itemID_canLoot = new ArrayList();
        private ArrayList itemID_lootRate = new ArrayList();
        private AddItem AddItemAction;






        //必须和物品搜刮对齐
        virtual public void initItemID_canLoot() { }
        //lootIndex+lootRate/maxLootIndex
        virtual public void initItemID_lootRate() { }





        public ArrayList getItemID_lootRate()
        {
            return itemID_lootRate;
        }

        public void setItemID_lootRate(ArrayList itemID_lootRate)
        {
            this.itemID_lootRate = itemID_lootRate;
        }
        public int getRandomNum(int a, int b)
        {
            return randomNum.Next(a, b + 1);
        }
        public ArrayList getItemID_canLoot()
        {
            return itemID_canLoot;
        }

        public void setItemID_canLoot(ArrayList itemID_canLoot)
        {
            this.itemID_canLoot = itemID_canLoot;
        }
        public int getLootIndex()
        {
            return lootIndex;
        }
        public void setLootIndex(int lootIndex)
        {
            this.lootIndex = lootIndex;
        }
        public int getMaxLootIndex()
        {
            return maxLootIndex;
        }
        public void setMaxLootIndex(int maxLootIndex)
        {
            this.maxLootIndex = maxLootIndex;
        }
        public defaultBlock getTheBlock()
        {
            return theBlock;
        }
        public void setTheBlock(defaultBlock theBlock)
        {
            this.theBlock = theBlock;
        }
        public theHero getHero()
        {
            return hero;
        }
        public void setHero(theHero hero)
        {
            this.hero = hero;
        }


        public AddItem getAddItemAction()
        {
            return AddItemAction;
        }

        public void setAddItemAction(AddItem addItemAction)
        {
            AddItemAction = addItemAction;
        }
    }
}
