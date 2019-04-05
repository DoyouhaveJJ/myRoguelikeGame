using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Map;
using myRougelikeGame.Items;

namespace myRougelikeGame.Action
{
    class HeroPickItems
    {
        private defaultBlock theBlock;
        private theHero hero;
        private defaultItem selectedItem;
        private System.Windows.Forms.ListBox heroBagList;
        private System.Windows.Forms.ListBox blockItemList;
        private System.Windows.Forms.ListBox heroBagListTrue;
        private System.Windows.Forms.ListBox blockItemListTrue;






        public void moveOneItemBlockToBag(){
            getHero().getHeroBag().updata(getHero());
            if (getHero().getHeroBag().isOutOfSpace()) return;
            if (getBlockItemList().SelectedItems.Count > 0)
            {
                int index = getBlockItemList().SelectedIndex;
                selectedItem = (defaultItem)getBlockItemListTrue().Items[index]; 
                getBlockItemList().Items.RemoveAt(index);
                getBlockItemListTrue().Items.RemoveAt(index);
                getHeroBagList().Items.Add(selectedItem.getName());
                getHeroBagListTrue().Items.Add(selectedItem);
                getHero().getHeroBag().addOneItem(selectedItem);
                getTheBlock().getItemInGround().Remove(selectedItem);
            }
            else 
                return;
        }
        public void moveAllItemBlockToBag() {
            
            if (getBlockItemList().Items.Count > 0) {
                for (int i = 0; i < getBlockItemList().Items.Count; i++) {
                    getHero().getHeroBag().updata(getHero());
                    if (getHero().getHeroBag().isOutOfSpace()) return;
                    selectedItem = (defaultItem)getBlockItemListTrue().Items[i];
                    getHero().getHeroBag().addOneItem(selectedItem);
                    getTheBlock().getItemInGround().Remove(selectedItem);
                
                }
            }
        
        }
        public void moveOneItemBagToBlock(){

            if (getHeroBagList().SelectedItems.Count > 0)
            {
                int index = getHeroBagList().SelectedIndex;
                selectedItem = (defaultItem)(getHeroBagListTrue().Items[index]);
                getHeroBagList().Items.RemoveAt(index);
                getHeroBagListTrue().Items.RemoveAt(index);
                
                getHero().getHeroBag().DestoryAnItem(selectedItem);
                getTheBlock().getItemInGround().Add(selectedItem);
            }
            else
                return;
        }


        public void updata() {
            getBlockItemList().Items.Clear();
            getBlockItemListTrue().Items.Clear();
            getHeroBagList().Items.Clear();
            getHeroBagListTrue().Items.Clear();
            for (int i = 0; i < getTheBlock().getItemInGround().Count;i++ )
            {
                selectedItem = (defaultItem)(getTheBlock().getItemInGround()[i]);
                getBlockItemList().Items.Add(selectedItem.getName());
                getBlockItemListTrue().Items.Add(selectedItem);
            }
            for (int i = 0; i <getHero().getHeroBag().getItemArrayCount(); i++) {
                if (((defaultItem)getHero().getHeroBag().getItemArray()[i]).getIsEquited()) continue;
                selectedItem = (defaultItem)getHero().getHeroBag().getItemArray()[i];
                getHeroBagList().Items.Add(selectedItem.getName());
                getHeroBagListTrue().Items.Add(selectedItem);
            }
            getHero().getHeroBag().updata(getHero());
        
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

        public System.Windows.Forms.ListBox getHeroBagList()
        {
            return heroBagList;
        }
        public void setHeroBagList(System.Windows.Forms.ListBox heroBagList)
        {
            this.heroBagList = heroBagList;
        }
        public System.Windows.Forms.ListBox getBlockItemList()
        {
            return blockItemList;
        }
        public void setBlockItemList(System.Windows.Forms.ListBox blockItemList)
        {
            this.blockItemList = blockItemList;
        }
        public System.Windows.Forms.ListBox getHeroBagListTrue()
        {
            return heroBagListTrue;
        }
        public void setHeroBagListTrue(System.Windows.Forms.ListBox heroBagListTrue)
        {
            this.heroBagListTrue = heroBagListTrue;
        }
        public System.Windows.Forms.ListBox getBlockItemListTrue()
        {
            return blockItemListTrue;
        }
        public void setBlockItemListTrue(System.Windows.Forms.ListBox blockItemListTrue)
        {
            this.blockItemListTrue = blockItemListTrue;
        }
    }
}
