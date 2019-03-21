using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Function;
using myRougelikeGame.Items;
using myRougelikeGame.Items.Food;
using myRougelikeGame.Items.Weapon;
using myRougelikeGame.Items.Wearable.BagForHand;
using myRougelikeGame.Items.Wearable.Belts;
using myRougelikeGame.Items.Wearable.Clothes;
using myRougelikeGame.Items.Wearable.Earplugs;
using myRougelikeGame.Items.Wearable.Glasses;
using myRougelikeGame.Items.Wearable.Gloves;
using myRougelikeGame.Items.Wearable.Hats;
using myRougelikeGame.Items.Wearable.Masks;
using myRougelikeGame.Items.Wearable.NeckLace;
using myRougelikeGame.Items.Wearable.Packback;
using myRougelikeGame.Items.Wearable.Pants;
using myRougelikeGame.Items.Wearable.Pocked;
using myRougelikeGame.Items.Wearable.Rings;
using myRougelikeGame.Items.Wearable.Shoes;
using myRougelikeGame.Items.Wearable.SignsForArm;
using myRougelikeGame.Items.Wearable.SignsForChest;
using myRougelikeGame.Items.Wearable.Stocks;
using myRougelikeGame.Map;


namespace myRougelikeGame.Action
{
    class AddItem
    {
        private System.Windows.Forms.ListBox MessageBox;

	    public System.Windows.Forms.ListBox getMessageBox() {
		return MessageBox;
	}

	    public void setMessageBox(System.Windows.Forms.ListBox messageBox) {
		MessageBox = messageBox;
	}




        public void AddOneItemByID(string item_ID,theHero myHero){
            if (item_ID == "") return;
            defaultItem a;
            switch (item_ID)
            {
                case "1":
                    {
                        a = new food_Apple();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "2":
                    {
                        a = new food_rawWater();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;

                    }
                case "3":
                    {
                        a = new weapon_Stick();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "4":
                    {
                        a = new bagforhand_PlasticBag();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "5":
                    {
                        a = new weapon_LongStick();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "6": {
                    a = new belt_WovenBelt();
                    a.setMessageBox(getMessageBox());
                    myHero.addOneItem(a);
                    break;
                }
                case "7":
                    {
                        a = new clothes_SackCloth();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "8":
                    {
                        a = new earplug_Runner();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "9":
                    {
                        a = new glass_NoGlass();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "10":
                    {
                        a = new glove_CottonGlove();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "11":
                    {
                        a = new hat_GreenHat();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "12":
                    {
                        a = new mask_CheapMask();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "13":
                    {
                        a = new necklace_PlasticNeckLace();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "14":
                    {
                        a = new backpack_KidBackPack();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "15":
                    {
                        a = new pants_BadPants();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "16":
                    {
                        a = new pocked_SmallPocked();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "17":
                    {
                        a = new ring_ToyRing();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "18":
                    {
                        a = new shoes_Slippers();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "19":
                    {
                        a = new signforarm_NameBrand();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "20":
                    {
                        a = new signforchest_MarkSign();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case "21":
                    {
                        a = new stock_WarmStock();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                default:
                    {
                        getMessageBox().Items.Add("不存在ID为" + item_ID + "的物品");
                      //System.Console.WriteLine("不存在ID为" + item_ID.Text + "的物品");
                        return;
                    }

            }
        
        }



        public void AddOneItemByID(int item_ID, theHero myHero)
        {
      
            defaultItem a;
            switch (item_ID)
            {
                case 1:
                    {
                        a = new food_Apple();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 2:
                    {
                        a = new food_rawWater();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;

                    }
                case 3:
                    {
                        a = new weapon_Stick();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 4:
                    {
                        a = new bagforhand_PlasticBag();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 5:
                    {
                        a = new weapon_LongStick();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 6:
                    {
                        a = new belt_WovenBelt();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 7:
                    {
                        a = new clothes_SackCloth();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 8:
                    {
                        a = new earplug_Runner();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 9:
                    {
                        a = new glass_NoGlass();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 10:
                    {
                        a = new glove_CottonGlove();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 11:
                    {
                        a = new hat_GreenHat();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 12:
                    {
                        a = new mask_CheapMask();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 13:
                    {
                        a = new necklace_PlasticNeckLace();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 14:
                    {
                        a = new backpack_KidBackPack();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 15:
                    {
                        a = new pants_BadPants();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 16:
                    {
                        a = new pocked_SmallPocked();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 17:
                    {
                        a = new ring_ToyRing();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 18:
                    {
                        a = new shoes_Slippers();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 19:
                    {
                        a = new signforarm_NameBrand();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 20:
                    {
                        a = new signforchest_MarkSign();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                case 21:
                    {
                        a = new stock_WarmStock();
                        a.setMessageBox(getMessageBox());
                        myHero.addOneItem(a);
                        break;
                    }
                default:
                    {
                        getMessageBox().Items.Add("不存在ID为" + item_ID + "的物品");
                        //System.Console.WriteLine("不存在ID为" + item_ID.Text + "的物品");
                        return;
                    }

            }

        }
        public void AddOneItemByIDToBlock(int item_ID, defaultBlock myBlock)
        {

            defaultItem a;
            switch (item_ID)
            {
                case 1:
                    {
                        a = new food_Apple();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 2:
                    {
                        a = new food_rawWater();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;

                    }
                case 3:
                    {
                        a = new weapon_Stick();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 4:
                    {
                        a = new bagforhand_PlasticBag();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 5:
                    {
                        a = new weapon_LongStick();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 6:
                    {
                        a = new belt_WovenBelt();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 7:
                    {
                        a = new clothes_SackCloth();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 8: {
                    a = new earplug_Runner();
                    a.setMessageBox(getMessageBox());
                    myBlock.getItemInGround().Add(a);
                    break;
                }
                case 9:
                    {
                        a = new glass_NoGlass();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 10:
                    {
                        a = new glove_CottonGlove();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 11:
                    {
                        a = new hat_GreenHat();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 12:
                    {
                        a = new mask_CheapMask();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 13:
                    {
                        a = new necklace_PlasticNeckLace();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 14:
                    {
                        a = new backpack_KidBackPack();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 15:
                    {
                        a = new pants_BadPants();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 16:
                    {
                        a = new pocked_SmallPocked();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 17:
                    {
                        a = new ring_ToyRing();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 18:
                    {
                        a = new shoes_Slippers();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 19:
                    {
                        a = new signforarm_NameBrand();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 20:
                    {
                        a = new signforchest_MarkSign();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                case 21:
                    {
                        a = new stock_WarmStock();
                        a.setMessageBox(getMessageBox());
                        myBlock.getItemInGround().Add(a);
                        break;
                    }
                default:
                    {
                        getMessageBox().Items.Add("不存在ID为" + item_ID + "的物品");
                        //System.Console.WriteLine("不存在ID为" + item_ID.Text + "的物品");
                        return;
                    }

            }

        }
    }
}
