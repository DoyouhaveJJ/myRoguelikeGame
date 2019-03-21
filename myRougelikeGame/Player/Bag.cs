using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using myRougelikeGame.Items;
using myRougelikeGame.Action;

namespace myRougelikeGame.Player
{    

    class Bag
    {
        private HeroDestoryItem HDI = new HeroDestoryItem();
        private ArrayList itemArray = new ArrayList();
        private double burdenNow;
        private double maxBurden;
        private int maxSpace;
        private int spaceNow;
      //  static int itemNo = 1;
        private theHero owner;
        private Judge judgeAction = new Judge();

        
        
        public Bag() {
            
        }
        public void addOneItem(defaultItem item) {
            if (isBurden(item)) {
                owner.getMessageBox().Items.Add("超重啦，不能拿下" + item.getName() + "啦");
                //System.Console.WriteLine("超重啦，不能拿下" + item.getName() + "啦");
                return;
            }
            if (isOutOfSpace()) {
                owner.getMessageBox().Items.Add("背包放不下啦，不能拿下" + item.getName() + "啦");
                //System.Console.WriteLine("背包放不下啦，不能拿下" + item.getName() + "啦");
                return;
            }
            itemArray.Add(item);


        }
        public void useOneItem(int i) {
            
        }
        public void updata(theHero owner) {
            setSpaceNow();
            setBurdenNow();
            setMaxBurden(owner.getMaxBurden());
            setMaxSpace(6 + getExtarRoom());//容量6==无背包
            owner.setBurden(owner.getHeroBag().getBurdenNow());
            if (getSpaceNow() > getMaxSpace()) {
                int count = 0, aim = getSpaceNow() - getMaxSpace();
                for (int i = 0; i < itemArray.Count; i++) {
                    if (((defaultItem)itemArray[i]).getIsEquited()) {
                        continue;
                    }
                    if (count==aim) {
                        break;
                    }
                    owner.getStandBlock().getItemInGround().Add(((defaultItem)itemArray[i]));
                    owner.getMessageBox().Items.Add(((defaultItem)itemArray[i]).getName() + "掉在地上了！");
                    count++;
                    itemArray.RemoveAt(i);
                    i--;
                }
            }

        }
        public int getExtarRoom() {
            int i,count=0;
            for (i = 0; i < itemArray.Count; i++)
            {
                if (((defaultItem)itemArray[i]).getIsEquited())
                    if (judgeAction.checkTypeIsGetRoom(((defaultItem)itemArray[i]).getType()))
                        count += ((defaultItem)itemArray[i]).getRoom();
            }
            return count;
        }


        public ArrayList getItemArray() {
            return this.itemArray;
        }

        public int getItemArrayCount() {
            return itemArray.Count;
        }
        public int getEquitedItem() {
            int i, count = 0;
            for (i = 0; i < itemArray.Count; i++) {
                if (((defaultItem)itemArray[i]).getIsEquited())
                    count++;
            }
            return count;
        }

        public defaultItem getItemByIndex(int i) {
            return (defaultItem)itemArray[i];
        }

        public void DestoryAnItem(defaultItem item){
            
            HDI.DestoryAnItem(owner,item,itemArray);
            updata(owner);
            /*
            int i = itemArray.IndexOf(item);
            itemArray.RemoveAt(i);
            if (item.getIsEquited()) {
                switch (item.getType()) {
                    case 2: {
                        if (owner.getHero_LeftHand().getTakeInHand() == item)
                        {
                            owner.getHero_LeftHand().setTakeInHand(null);
                            owner.getHero_LeftHand().setIsEquipedSomething(false);
                        }
                        else
                        {
                            owner.getHero_RightHand().setTakeInHand(null);
                            owner.getHero_RightHand().setIsEquipedSomething(false);
                        }
                        break;
                    }
                    case 3: {
                        if (owner.getHero_LeftHand().getTakeInHand() == item)
                        {
                            owner.getHero_LeftHand().setTakeInHand(null);
                            owner.getHero_LeftHand().setIsEquipedSomething(false);
                        }
                        else
                        {
                            owner.getHero_RightHand().setTakeInHand(null);
                            owner.getHero_RightHand().setIsEquipedSomething(false);
                        }
                        break;
                    }
                    case 4: {
                        if (owner.getHero_LeftHand().getTakeInHand() == item && owner.getHero_RightHand().getTakeInHand() == item)
                        {
                            owner.getHero_LeftHand().setTakeInHand(null);
                            owner.getHero_LeftHand().setIsEquipedSomething(false);
                            owner.getHero_RightHand().setTakeInHand(null);
                            owner.getHero_RightHand().setIsEquipedSomething(false);
                        }
                        break;
                    }
                
                }
                
            }*/
        }

        public void checkItems() {
            for (int i = 0; i < itemArray.Count; i++) {
                if (getItemByIndex(i).isDestoryed()) {
                    DestoryAnItem(getItemByIndex(i));
                }
            }
        }




        public void causeEnduranceDecrease() {
            for (int i = 0; i < itemArray.Count; i++) {
                getItemByIndex(i).DecreaseEndurance();
            }
            checkItems();
        }

        public bool isBurden(defaultItem item) {
            if (getBurdenNow() + item.getWeight() > getMaxBurden())
                return true;
            else
                return false;
        }

        public bool isOutOfSpace() {
            if (getSpaceNow() >= getMaxSpace())
                return true;
            else
                return false;
        }








        public double getBurdenNow()
        {
            return burdenNow;
        }
        public void setBurdenNow()
        {
            this.burdenNow = 0;
            for (int i = 0; i < itemArray.Count; i++)
            {
                this.burdenNow += getItemByIndex(i).getWeight();
            }

        }
        public double getMaxBurden()
        {
            return maxBurden;
        }
        public void setMaxBurden(double maxBurden)
        {
            this.maxBurden = maxBurden;
        }
        public int getMaxSpace()
        {
            return maxSpace;
        }
        public void setMaxSpace(int maxSpace)
        {
            this.maxSpace = maxSpace;
        }
        public int getSpaceNow()
        {
            setSpaceNow();
            return spaceNow;
        }
        public void setSpaceNow()
        {
            this.spaceNow = itemArray.Count - getEquitedItem();
        }


        public theHero getOwner()
        {
            return owner;
        }

        public void setOwner(theHero owner)
        {
            this.owner = owner;
        }

    }
}
