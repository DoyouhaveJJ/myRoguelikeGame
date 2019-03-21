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

        public void LootOnce() {
            
            for (int i = 0; i < loot.getItemID_canLoot().Count; i++) { 
                if(dr.startBet((int)loot.getItemID_lootRate()[i]+loot.getLootIndex(),loot.getMaxLootIndex())){
                    AddItemAction.AddOneItemByIDToBlock((int)loot.getItemID_canLoot()[i], loot.getTheBlock());
                    Thread.Sleep(10);
                    getLootMessage().Items.Add("你搜刮到了一个东西");
                }
            }
        }
        public void Loot() {
            if (loot.getLootIndex() == 0) { getLootMessage().Items.Add("没搜刮到什么东西"); return; }
            for (int i = 0; i < loot.getHero().getHero_lucky(); i++) {
                LootOnce();
            }
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
