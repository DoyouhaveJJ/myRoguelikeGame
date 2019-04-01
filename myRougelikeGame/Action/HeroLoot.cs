using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Loot;
using myRougelikeGame.Function;
using myRougelikeGame.Action;
using System.Threading;

namespace myRougelikeGame.Action
{
    class HeroLoot
    {
        private System.Windows.Forms.ListBox LootMessage;
        private AddItem AddItemAction;
        private defaultLoot loot;
        private DIYRandom dr = new DIYRandom();
        private bool isLootSomething = false;
        public void LootOnce() {
            
            for (int i = 0; i < loot.getItemID_canLoot().Count; i++) { 
                if(dr.startBet((int)loot.getItemID_lootRate()[i]+loot.getLootIndex(),loot.getMaxLootIndex())){
                    //
                    loot.getTheBlock().getItemInGround().Add(AddItemAction.AddOneItemByID((int)loot.getItemID_canLoot()[i]));
                  //AddItemAction.AddOneItemByIDToBlock((int)loot.getItemID_canLoot()[i], loot.getTheBlock());
                    Thread.Sleep(10);
                    getLootMessage().Items.Add("你搜刮到了一个东西");
                    isLootSomething = true;
                }
            }
            
        }
        public void Loot() {
            if (loot.getHero().isOutOfEnergy(5)) {
                getLootMessage().Items.Add("你没有精力来搜刮了");
                return;
            }

            if (loot.getLootIndex() == 0) { getLootMessage().Items.Add("没搜刮到什么东西"); return; }
            for (int i = 0; i < dr.getRandomNum(1, loot.getHero().getHero_lucky()); i++)
            {
                LootOnce();
            }
            if (!isLootSomething)
                getLootMessage().Items.Add("运气真差，啥都没搜刮到");
            loot.setLootIndex(0);
            loot.getHero().lootCauseDecreaseEnergy();

        }




















        public System.Windows.Forms.ListBox getLootMessage()
        {
            return LootMessage;
        }
        public void setLootMessage(System.Windows.Forms.ListBox lootMessage)
        {
            LootMessage = lootMessage;
        }
        public defaultLoot getLoot()
        {
            return loot;
        }
        public void setLoot(defaultLoot loot)
        {
            this.loot = loot;
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
