using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;
using myRougelikeGame.Items;
using System.Collections;
namespace myRougelikeGame.Action
{
    class HeroDestoryItem
    {
        public void DestoryAnItem(theHero owner,defaultItem item,ArrayList itemArray)
        {
            int i = itemArray.IndexOf(item);
            itemArray.RemoveAt(i);
            if (item.getIsEquited())
            {
                switch (item.getType())
                {
                    case 2:
                        {
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
                    case 3:
                        {
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
                    case 4:
                        {
                            if (owner.getHero_LeftHand().getTakeInHand() == item && owner.getHero_RightHand().getTakeInHand() == item)
                            {
                                owner.getHero_LeftHand().setTakeInHand(null);
                                owner.getHero_LeftHand().setIsEquipedSomething(false);
                                owner.getHero_RightHand().setTakeInHand(null);
                                owner.getHero_RightHand().setIsEquipedSomething(false);
                            }
                            break;
                        }
                    case 5:
                        {
                            if (owner.getHero_Web().getTakenBelt() == item)
                            {
                                owner.getHero_Web().setTakenBelt(null);
                                owner.getHero_Web().setIsEquipBelt(false);

                            }
                            break;
                        }
                    case 6:
                        {
                            if (owner.getHero_Chest().getTakenCloth() == item)
                            {
                                owner.getHero_Chest().setTakenCloth(null);
                                owner.getHero_Chest().setIsEquipedCloth(false);

                            }
                            break;
                        }
                    case 7:
                        {
                            if (owner.getHero_Chest().getTakenCloth() == item)
                            {
                                owner.getHero_Chest().setTakenCloth(null);
                                owner.getHero_Chest().setIsEquipedCloth(false);

                            }
                            break;
                        }
                    case 8:
                        {
                            if (owner.getHero_Head().getTakenGlass() == item)
                            {
                                owner.getHero_Head().setTakenGlass(null);
                                owner.getHero_Head().setIsEquipedGlass(false);

                            }
                            break;
                        }
                    case 9:
                        {
                            if (owner.getHero_LeftHand().getTakenGlove() == item && owner.getHero_RightHand().getTakenGlove() == item)
                            {
                                owner.getHero_LeftHand().setTakenGlove(null);
                                owner.getHero_LeftHand().setIsEquipedGlove(false);
                                owner.getHero_RightHand().setTakenGlove(null);
                                owner.getHero_RightHand().setIsEquipedGlove(false);

                            }
                            break;
                        }
                    case 10:
                        {
                            if (owner.getHero_Head().getTakenHat() == item)
                            {
                                owner.getHero_Head().setTakenHat(null);
                                owner.getHero_Head().setIsEquipedHat(false);

                            }
                            break;
                        }
                    case 11:
                        {
                            if (owner.getHero_Head().getTakenMask() == item)
                            {
                                owner.getHero_Head().setTakenMask(null);
                                owner.getHero_Head().setIsEquipedMask(false);

                            }
                            break;
                        }
                    case 12:
                        {
                            if (owner.getHero_Neck().getTakenNecklace() == item)
                            {
                                owner.getHero_Neck().setTakenNecklace(null);
                                owner.getHero_Neck().setIsEquipedNecklace(false);

                            }
                            break;
                        }
                    case 13:
                        {
                            if (owner.getHero_Chest().getTakenBackpack() == item)
                            {
                                owner.getHero_Chest().setTakenBackpack(null);
                                owner.getHero_Chest().setIsEquipedBackpack(false);

                            }
                            break;
                        }
                    case 14:
                        {
                            if (owner.getHero_LeftLeg().getTakenPants() == item && owner.getHero_RightLeg().getTakenPants() == item)
                            {
                                owner.getHero_LeftLeg().setTakenPants(null);
                                owner.getHero_LeftLeg().setIsEquipedPants(false);
                                owner.getHero_RightLeg().setTakenPants(null);
                                owner.getHero_RightLeg().setIsEquipedPants(false);

                            }
                            break;
                        }
                    case 15:
                        {
                            if (owner.getHero_Web().getTakenPocked() == item)
                            {
                                owner.getHero_Web().setTakenPocked(null);
                                owner.getHero_Web().setIsEquipPocked(false);

                            }
                            break;
                        }
                    case 16:
                        {
                            if (owner.getHero_LeftHand().getTakenRing() == item)
                            {
                                owner.getHero_LeftHand().setTakenRing(null);
                                owner.getHero_LeftHand().setIsEquipedRing(false);
                            }
                            else
                            {
                                owner.getHero_RightHand().setTakenRing(null);
                                owner.getHero_RightHand().setIsEquipedRing(false);
                            }
                            break;
                        }
                    case 17:
                        {
                            if (owner.getHero_LeftFoot().getTakenShoes() == item && owner.getHero_RightFoot().getTakenShoes() == item)
                            {
                                owner.getHero_LeftFoot().setTakenShoes(null);
                                owner.getHero_LeftFoot().setIsEquipedShoes(false);
                                owner.getHero_RightFoot().setTakenShoes(null);
                                owner.getHero_RightFoot().setIsEquipedShoes(false);

                            }
                            break;
                        }
                    case 18:
                        {
                            if (owner.getHero_LeftArm().getTakenSign () == item)
                            {
                                owner.getHero_LeftArm().setTakenSign (null);
                                owner.getHero_LeftArm().setIsEquipedSign (false);
                            }
                            else
                            {
                                owner.getHero_RightArm().setTakenSign (null);
                                owner.getHero_RightArm().setIsEquipedSign (false);
                            }
                            break;
                        }
                    case 19:
                        {
                            if (owner.getHero_Chest().getTakenSign() == item)
                            {
                                owner.getHero_Chest().setTakenSign(null);
                                owner.getHero_Chest().setIsEquipedSign(false);

                            }
                            break;
                        }
                    case 20:
                        {
                            if (owner.getHero_LeftFoot().getTakenStock() == item && owner.getHero_RightFoot().getTakenStock() == item)
                            {
                                owner.getHero_LeftFoot().setTakenStock(null);
                                owner.getHero_LeftFoot().setIsEquipedStock(false);
                                owner.getHero_RightFoot().setTakenStock(null);
                                owner.getHero_RightFoot().setIsEquipedStock(false);

                            }
                            break;
                        }
                    
                   

                }

            }
        }
    }

}
