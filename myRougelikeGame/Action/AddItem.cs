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
using myRougelikeGame.Items.Body;
using myRougelikeGame.Items.Materials;
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




        //public void AddOneItemByID(string item_ID,theHero myHero){
        //    if (item_ID == "") return;
        //    defaultItem a;
        //    switch (item_ID)
        //    {
        //        case "1":
        //            {
        //                a = new food_Apple();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "2":
        //            {
        //                a = new food_rawWater();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;

        //            }
        //        case "3":
        //            {
        //                a = new weapon_Stick();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "4":
        //            {
        //                a = new bagforhand_PlasticBag();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "5":
        //            {
        //                a = new weapon_LongStick();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "6": {
        //            a = new belt_WovenBelt();
        //            a.setMessageBox(getMessageBox());
        //            
        //            return a;
        //        }
        //        case "7":
        //            {
        //                a = new clothes_SackCloth();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "8":
        //            {
        //                a = new earplug_Runner();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "9":
        //            {
        //                a = new glass_NoGlass();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "10":
        //            {
        //                a = new glove_CottonGlove();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "11":
        //            {
        //                a = new hat_GreenHat();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "12":
        //            {
        //                a = new mask_CheapMask();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "13":
        //            {
        //                a = new necklace_PlasticNeckLace();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "14":
        //            {
        //                a = new backpack_KidBackPack();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "15":
        //            {
        //                a = new pants_BadPants();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "16":
        //            {
        //                a = new pocked_SmallPocked();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "17":
        //            {
        //                a = new ring_ToyRing();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "18":
        //            {
        //                a = new shoes_Slippers();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "19":
        //            {
        //                a = new signforarm_NameBrand();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "20":
        //            {
        //                a = new signforchest_MarkSign();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        case "21":
        //            {
        //                a = new stock_WarmStock();
        //                a.setMessageBox(getMessageBox());
        //                
        //                return a;
        //            }
        //        default:
        //            {
        //                getMessageBox().Items.Add("不存在ID为" + item_ID + "的物品");
        //              //System.Console.WriteLine("不存在ID为" + item_ID.Text + "的物品");
        //                return;
        //            }

        //    }
        
        //}



        public defaultItem AddOneItemByID(int item_ID)
        {
      
            defaultItem a;
            switch (item_ID)
            {
                case 1:
                    {
                        a = new food_Apple();
                        a.setMessageBox(getMessageBox());

                        return a;
                    }
                case 2:
                    {
                        a = new food_rawWater();
                        a.setMessageBox(getMessageBox());
                        
                        return a;

                    }
                case 3:
                    {
                        a = new weapon_Stick();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 4:
                    {
                        a = new bagforhand_PlasticBag();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 5:
                    {
                        a = new weapon_LongStick();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 6:
                    {
                        a = new belt_WovenBelt();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 7:
                    {
                        a = new clothes_SackCloth();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 8:
                    {
                        a = new earplug_Runner();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 9:
                    {
                        a = new glass_NoGlass();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 10:
                    {
                        a = new glove_CottonGlove();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 11:
                    {
                        a = new hat_GreenHat();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 12:
                    {
                        a = new mask_CheapMask();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 13:
                    {
                        a = new necklace_PlasticNeckLace();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 14:
                    {
                        a = new backpack_KidBackPack();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 15:
                    {
                        a = new pants_BadPants();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 16:
                    {
                        a = new pocked_SmallPocked();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 17:
                    {
                        a = new ring_ToyRing();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 18:
                    {
                        a = new shoes_Slippers();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 19:
                    {
                        a = new signforarm_NameBrand();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 20:
                    {
                        a = new signforchest_MarkSign();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 21:
                    {
                        a = new stock_WarmStock();
                        a.setMessageBox(getMessageBox());
                        
                        return a;
                    }
                case 22:
                    {
                        a = new body_Slime();
                        a.setMessageBox(getMessageBox());

                        return a;
                    }
                case 23:
                    {
                        a = new body_Goblin();
                        a.setMessageBox(getMessageBox());

                        return a;
                    }
                case 24:
                    {
                        a = new material_Glue();
                        a.setMessageBox(getMessageBox());

                        return a;
                    }
                case 25:
                    {
                        a = new material_Bone();
                        a.setMessageBox(getMessageBox());

                        return a;
                    }
                case 26:
                    {
                        a = new material_GreenSkin();
                        a.setMessageBox(getMessageBox());

                        return a;
                    }
                case 27:
                    {
                        a = new weapon_BoneStick();
                        a.setMessageBox(getMessageBox());

                        return a;
                    }
                default:
                    {
                        getMessageBox().Items.Add("不存在ID为" + item_ID + "的物品");
                        //System.Console.WriteLine("不存在ID为" + item_ID.Text + "的物品");
                        return null;
                    }

            }

        }
        //public void AddOneItemByIDToBlock(int item_ID, defaultBlock myBlock)
        //{

        //    defaultItem a;
        //    switch (item_ID)
        //    {
        //        case 1:
        //            {
        //                a = new food_Apple();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 2:
        //            {
        //                a = new food_rawWater();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;

        //            }
        //        case 3:
        //            {
        //                a = new weapon_Stick();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 4:
        //            {
        //                a = new bagforhand_PlasticBag();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 5:
        //            {
        //                a = new weapon_LongStick();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 6:
        //            {
        //                a = new belt_WovenBelt();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 7:
        //            {
        //                a = new clothes_SackCloth();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 8: {
        //            a = new earplug_Runner();
        //            a.setMessageBox(getMessageBox());
        //            myBlock.getItemInGround().Add(a);
        //            return a;
        //        }
        //        case 9:
        //            {
        //                a = new glass_NoGlass();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 10:
        //            {
        //                a = new glove_CottonGlove();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 11:
        //            {
        //                a = new hat_GreenHat();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 12:
        //            {
        //                a = new mask_CheapMask();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 13:
        //            {
        //                a = new necklace_PlasticNeckLace();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 14:
        //            {
        //                a = new backpack_KidBackPack();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 15:
        //            {
        //                a = new pants_BadPants();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 16:
        //            {
        //                a = new pocked_SmallPocked();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 17:
        //            {
        //                a = new ring_ToyRing();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 18:
        //            {
        //                a = new shoes_Slippers();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 19:
        //            {
        //                a = new signforarm_NameBrand();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 20:
        //            {
        //                a = new signforchest_MarkSign();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        case 21:
        //            {
        //                a = new stock_WarmStock();
        //                a.setMessageBox(getMessageBox());
        //                myBlock.getItemInGround().Add(a);
        //                return a;
        //            }
        //        default:
        //            {
        //                getMessageBox().Items.Add("不存在ID为" + item_ID + "的物品");
        //                //System.Console.WriteLine("不存在ID为" + item_ID.Text + "的物品");
        //                return;
        //            }

        //    }

        }
    }

