using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;
using myRougelikeGame.Player;
using System.Windows.Forms;

namespace myRougelikeGame.Action
{
    class HeroEquip
    {
        public void HeroEquipItem(theHero owner,defaultItem selectedItem){
        {

            if (selectedItem.getIsEquited())//已装备的话则卸下
            {
                selectedItem.setIsEquited(false);
                switch (selectedItem.getType())
                {
                    case 2:
                        {
                            if (selectedItem == owner.getHero_LeftHand().getTakeInHand())
                            {
                                owner.getHero_LeftHand().setIsEquipedSomething(false);
                                owner.getHero_LeftHand().setTakeInHand(null);
                            }
                            else
                            {
                                owner.getHero_RightHand().setIsEquipedSomething(false);
                                owner.getHero_RightHand().setTakeInHand(null);
                            }
                            break;
                        }
                    case 3:
                        {
                            if (selectedItem == owner.getHero_LeftHand().getTakeInHand())
                            {
                                owner.getHero_LeftHand().setIsEquipedSomething(false);
                                owner.getHero_LeftHand().setTakeInHand(null);
                            }
                            else
                            {
                                owner.getHero_RightHand().setIsEquipedSomething(false);
                                owner.getHero_RightHand().setTakeInHand(null);
                            }
                            break;
                        }
                    case 4:
                        {
                            if (owner.getHero_LeftHand().getTakeInHand() == selectedItem && owner.getHero_RightHand().getTakeInHand() == selectedItem)
                            {
                                owner.getHero_LeftHand().setIsEquipedSomething(false);
                                owner.getHero_RightHand().setIsEquipedSomething(false);
                                owner.getHero_LeftHand().setTakeInHand(null);
                                owner.getHero_RightHand().setTakeInHand(null);
                            }
                            break;
                        }
                    case 5:
                        {
                            if (owner.getHero_Web().getTakenBelt() == selectedItem)
                            {
                                owner.getHero_Web().getTakenBelt().UnEquipItem(owner);
                                owner.getHero_Web().setIsEquipBelt(false);
                                owner.getHero_Web().setTakenBelt(null);
                              
                            }
                            break;
                        }
                    case 6:
                        {
                            if (owner.getHero_Chest().getTakenCloth() == selectedItem)
                            {
                                owner.getHero_Chest().getTakenCloth().UnEquipItem(owner);
                                owner.getHero_Chest().setIsEquipedCloth(false);
                                owner.getHero_Chest().setTakenCloth(null);

                            }
                            break;
                        }
                    case 7:
                        {
                            if (owner.getHero_Head().getTakenEarplug() == selectedItem)
                            {
                                owner.getHero_Head().getTakenEarplug().UnEquipItem(owner);
                                owner.getHero_Head().setIsEquipedEarplug(false);
                                owner.getHero_Head().setTakenEarplug(null);

                            }
                            break;
                        }
                    case 8:
                        {
                            if (owner.getHero_Head().getTakenGlass() == selectedItem)
                            {
                                owner.getHero_Head().getTakenGlass().UnEquipItem(owner);
                                owner.getHero_Head().setIsEquipedGlass(false);
                                owner.getHero_Head().setTakenGlass(null);

                            }
                            break;
                        }
                    case 9:
                        {
                            if (owner.getHero_LeftHand().getTakenGlove() == selectedItem && owner.getHero_RightHand().getTakenGlove() == selectedItem)
                            {
                                owner.getHero_LeftHand().getTakenGlove().UnEquipItem(owner);
                                owner.getHero_LeftHand().setIsEquipedGlove(false);
                                owner.getHero_RightHand().setIsEquipedGlove(false);
                                owner.getHero_LeftHand().setTakenGlove(null);
                                owner.getHero_RightHand().setTakenGlove(null);
                            }
                            break;
                        }
                    case 10:
                        {
                            if (owner.getHero_Head().getTakenHat() == selectedItem)
                            {
                                owner.getHero_Head().getTakenHat().UnEquipItem(owner);
                                owner.getHero_Head().setIsEquipedHat(false);
                                owner.getHero_Head().setTakenHat(null);

                            }
                            break;
                        }
                    case 11:
                        {
                            if (owner.getHero_Head().getTakenMask() == selectedItem)
                            {
                                owner.getHero_Head().getTakenMask().UnEquipItem(owner);
                                owner.getHero_Head().setIsEquipedMask(false);
                                owner.getHero_Head().setTakenMask(null);

                            }
                            break;
                        }
                    case 12:
                        {
                            if (owner.getHero_Neck().getTakenNecklace() == selectedItem)
                            {
                                owner.getHero_Neck().getTakenNecklace().UnEquipItem(owner);
                                owner.getHero_Neck().setIsEquipedNecklace(false);
                                owner.getHero_Neck().setTakenNecklace(null);

                            }
                            break;
                        }
                    case 13:
                        {
                            if (owner.getHero_Chest().getTakenBackpack() == selectedItem)
                            {
                                owner.getHero_Chest().getTakenBackpack().UnEquipItem(owner);
                                owner.getHero_Chest().setIsEquipedBackpack(false);
                                owner.getHero_Chest().setTakenBackpack(null);

                            }
                            break;
                        }
                    case 14:
                        {
                            if (owner.getHero_LeftLeg().getTakenPants() == selectedItem && owner.getHero_RightLeg().getTakenPants() == selectedItem)
                            {
                                owner.getHero_LeftLeg().getTakenPants().UnEquipItem(owner);
                                owner.getHero_LeftLeg().setIsEquipedPants(false);
                                owner.getHero_RightLeg().setIsEquipedPants(false);
                                owner.getHero_LeftLeg().setTakenPants(null);
                                owner.getHero_RightLeg().setTakenPants(null);
                            }
                            break;
                        }
                    case 15:
                        {
                            if (owner.getHero_Web().getTakenPocked() == selectedItem)
                            {
                                owner.getHero_Web().getTakenPocked().UnEquipItem(owner);
                                owner.getHero_Web().setIsEquipPocked(false);
                                owner.getHero_Web().setTakenPocked(null);

                            }
                            break;
                        }
                    case 16:
                        {
                            if (selectedItem == owner.getHero_LeftHand().getTakenRing())
                            {
                                owner.getHero_LeftHand().getTakenRing().UnEquipItem(owner);
                                owner.getHero_LeftHand().setIsEquipedRing(false);
                                owner.getHero_LeftHand().setTakenRing(null);
                               
                            }
                            else
                            {
                                owner.getHero_RightHand().getTakenRing().UnEquipItem(owner);
                                owner.getHero_RightHand().setIsEquipedRing(false);
                                owner.getHero_RightHand().setTakenRing(null);
                                
                            }
                            break;
                        }
                    case 17:
                        {
                            if (owner.getHero_LeftFoot().getTakenShoes() == selectedItem && owner.getHero_RightFoot().getTakenShoes() == selectedItem)
                            {
                                owner.getHero_LeftFoot().getTakenShoes().UnEquipItem(owner);
                                owner.getHero_LeftFoot().setIsEquipedShoes(false);
                                owner.getHero_RightFoot().setIsEquipedShoes(false);
                                owner.getHero_LeftFoot().setTakenShoes(null);
                                owner.getHero_RightFoot().setTakenShoes(null);
                            }
                            break;
                        }
                    case 18:
                        {
                            if (selectedItem == owner.getHero_LeftArm().getTakenSign())
                            {
                                owner.getHero_LeftArm().getTakenSign().UnEquipItem(owner);
                                owner.getHero_LeftArm().setIsEquipedSign(false);
                                owner.getHero_LeftArm().setTakenSign(null);
                            }
                            else
                            {
                                owner.getHero_RightArm().getTakenSign().UnEquipItem(owner);
                                owner.getHero_RightArm().setIsEquipedSign(false);
                                owner.getHero_RightArm().setTakenSign(null);
                            }
                            break;
                        }
                    case 19:
                        {
                            if (owner.getHero_Chest().getTakenSign() == selectedItem)
                            {
                                owner.getHero_Chest().getTakenSign().UnEquipItem(owner);
                                owner.getHero_Chest().setIsEquipedSign(false);
                                owner.getHero_Chest().setTakenSign(null);

                            }
                            break;
                        }
                    case 20:
                        {
                            if (owner.getHero_LeftFoot().getTakenStock() == selectedItem && owner.getHero_RightFoot().getTakenStock() == selectedItem)
                            {
                                owner.getHero_LeftFoot().getTakenStock().UnEquipItem(owner);
                                owner.getHero_LeftFoot().setIsEquipedStock(false);
                                owner.getHero_RightFoot().setIsEquipedStock(false);
                                owner.getHero_LeftFoot().setTakenStock(null);
                                owner.getHero_RightFoot().setTakenStock(null);
                            }
                            break;
                        }

                }

                
            }
            else
            {
                switch (selectedItem.getType()) {
                    case 2: {
                        if (MessageBox.Show("想用左手拿吗？不想左手拿就右手拿", "哪只手拿？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            if (owner.getHero_LeftHand().getIsEquipedSomething())
                            {
                                MessageBox.Show("左手已经有东西了", "拿不了", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                owner.getHero_LeftHand().setIsEquipedSomething(true);
                                owner.getHero_LeftHand().setTakeInHand(selectedItem);
                            }
                        }
                        else
                        {
                            if (owner.getHero_RightHand().getIsEquipedSomething())
                            {
                                MessageBox.Show("右手已经有东西了", "拿不了", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                owner.getHero_RightHand().setIsEquipedSomething(true);
                                owner.getHero_RightHand().setTakeInHand(selectedItem);
                            }
                        }
                        break;
                    }

                    case 3:
                        {
                            if (MessageBox.Show("想用左手拿吗？不想左手拿就右手拿", "哪只手拿？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                if (owner.getHero_LeftHand().getIsEquipedSomething())
                                {
                                    MessageBox.Show("左手已经有东西了", "拿不了", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                    owner.getHero_LeftHand().setIsEquipedSomething(true);
                                    owner.getHero_LeftHand().setTakeInHand(selectedItem);
                                }
                            }
                            else
                            {
                                if (owner.getHero_RightHand().getIsEquipedSomething())
                                {
                                    MessageBox.Show("右手已经有东西了", "拿不了", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                    owner.getHero_RightHand().setIsEquipedSomething(true);
                                    owner.getHero_RightHand().setTakeInHand(selectedItem);
                                }
                            }
                            break;
                        }
                    case 4: {
                        if (owner.getHero_LeftHand().getIsEquipedSomething() || owner.getHero_RightHand().getIsEquipedSomething())
                        {
                            MessageBox.Show("这玩意儿必须双手拿", "拿不了", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                            owner.getHero_LeftHand().setIsEquipedSomething(true);
                            owner.getHero_LeftHand().setTakeInHand(selectedItem);
                            owner.getHero_RightHand().setIsEquipedSomething(true);
                            owner.getHero_RightHand().setTakeInHand(selectedItem);
                        }
                        break;
                    }
                    case 5: {
                        if (owner.getHero_Web().getIsEquipBelt())
                        {
                            MessageBox.Show("你的腰上已经有腰带了", "带两个腰带？", MessageBoxButtons.OK);
                            return;
                        }
                        else
                        {
                           
                            owner.getHero_Web().setIsEquipBelt(true);
                            owner.getHero_Web().setTakenBelt(selectedItem);
                            owner.getHero_Web().getTakenBelt().EquipItem(owner);
                            
                        }
                        break;
                    }
                    case 6:
                        {
                            if (owner.getHero_Chest().getIsEquipedCloth())
                            {
                                MessageBox.Show("你已经穿了衣服了", "只能穿一件？", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                               
                                owner.getHero_Chest().setIsEquipedCloth(true);
                                owner.getHero_Chest().setTakenCloth(selectedItem);
                                owner.getHero_Chest().getTakenCloth().EquipItem(owner);

                            }
                            break;
                        }
                    case 7:
                        {
                            if (owner.getHero_Head().getIsEquipedEarplug())
                            {
                                MessageBox.Show("你已经戴了耳部挂件了", "你耳朵很累", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Head().setIsEquipedEarplug(true);
                                owner.getHero_Head().setTakenEarplug(selectedItem);
                                owner.getHero_Head().getTakenEarplug().EquipItem(owner);

                            }
                            break;
                        }
                    case 8:
                        {
                            if (owner.getHero_Head().getIsEquipedGlass())
                            {
                                MessageBox.Show("你已经戴了眼镜了", "戴不了", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Head().setIsEquipedGlass(true);
                                owner.getHero_Head().setTakenGlass(selectedItem);
                                owner.getHero_Head().getTakenGlass().EquipItem(owner);

                            }
                            break;
                        }

                    case 9:
                        {
                            if (owner.getHero_LeftHand().getIsEquipedGlove() || owner.getHero_RightHand().getIsEquipedGlove())
                            {
                                MessageBox.Show("你只能戴一双手套", "热得慌", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                owner.getHero_LeftHand().setIsEquipedGlove(true);
                                owner.getHero_LeftHand().setTakenGlove(selectedItem);
                                owner.getHero_RightHand().setIsEquipedGlove(true);
                                owner.getHero_RightHand().setTakenGlove(selectedItem);
                                owner.getHero_LeftHand().getTakenGlove().EquipItem(owner);

                            }
                            break;
                        }
                    case 10:
                        {
                            if (owner.getHero_Head().getIsEquipedHat())
                            {
                                MessageBox.Show("你已经戴了帽子了", "戴不了", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Head().setIsEquipedHat(true);
                                owner.getHero_Head().setTakenHat(selectedItem);
                                owner.getHero_Head().getTakenHat().EquipItem(owner);

                            }
                            break;
                        }
                    case 11:
                        {
                            if (owner.getHero_Head().getIsEquipedMask())
                            {
                                MessageBox.Show("你已经戴了面具了", "戴不了", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Head().setIsEquipedMask(true);
                                owner.getHero_Head().setTakenMask(selectedItem);
                                owner.getHero_Head().getTakenMask().EquipItem(owner);

                            }
                            break;
                        }
                    case 12:
                        {
                            if (owner.getHero_Neck().getIsEquipedNecklace())
                            {
                                MessageBox.Show("你已经戴了项链了", "一条就够了", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Neck().setIsEquipedNecklace(true);
                                owner.getHero_Neck().setTakenNecklace(selectedItem);
                                owner.getHero_Neck().getTakenNecklace().EquipItem(owner);

                            }
                            break;
                        }
                    case 13:
                        {
                            if (owner.getHero_Chest().getIsEquipedBackpack())
                            {
                                MessageBox.Show("你已经有一个背包了了", "别想戴两个", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Chest().setIsEquipedBackpack(true);
                                owner.getHero_Chest().setTakenBackpack(selectedItem);
                                owner.getHero_Chest().getTakenBackpack().EquipItem(owner);

                            }
                            break;
                        }
                    case 14:
                        {
                            if (owner.getHero_LeftLeg().getIsEquipedPants() || owner.getHero_RightLeg().getIsEquipedPants())
                            {
                                MessageBox.Show("你只能穿一条裤子", "啊，没有秋裤的世界", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                owner.getHero_LeftLeg().setIsEquipedPants(true);
                                owner.getHero_LeftLeg().setTakenPants(selectedItem);
                                owner.getHero_RightLeg().setIsEquipedPants(true);
                                owner.getHero_RightLeg().setTakenPants(selectedItem);
                                owner.getHero_LeftLeg().getTakenPants().EquipItem(owner);

                            }
                            break;
                        }
                    case 15:
                        {
                            if (owner.getHero_Web().getIsEquipPocked())
                            {
                                MessageBox.Show("你已经有一个背包了了", "别想戴两个", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Web().setIsEquipPocked(true);
                                owner.getHero_Web().setTakenPocked(selectedItem);
                                owner.getHero_Web().getTakenPocked().EquipItem(owner);

                            }
                            break;
                        }
                    case 16:
                        {
                            if (MessageBox.Show("想戴在左手上吗？不想戴左手戴就右手", "戴在哪只手？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                if (owner.getHero_LeftHand().getIsEquipedRing())
                                {
                                    MessageBox.Show("左手已经有戒指了", "戴不了", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                    owner.getHero_LeftHand().setIsEquipedRing(true);
                                    owner.getHero_LeftHand().setTakenRing(selectedItem);
                                    owner.getHero_LeftHand().getTakenRing().EquipItem(owner);
                                }
                            }
                            else
                            {
                                if (owner.getHero_RightHand().getIsEquipedRing())
                                {
                                    MessageBox.Show("右手已经有戒指了", "戴不了", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                    owner.getHero_RightHand().setIsEquipedRing(true);
                                    owner.getHero_RightHand().setTakenRing(selectedItem);
                                    owner.getHero_RightHand().getTakenRing().EquipItem(owner);
                                }
                            }
                            break;
                        }
                    case 17:
                        {
                            if (owner.getHero_LeftFoot().getIsEquipedShoes() || owner.getHero_RightFoot().getIsEquipedShoes())
                            {
                                MessageBox.Show("你只能穿一双鞋", "啊，常识", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                owner.getHero_LeftFoot().setIsEquipedShoes(true);
                                owner.getHero_LeftFoot().setTakenShoes(selectedItem);
                                owner.getHero_RightFoot().setIsEquipedShoes(true);
                                owner.getHero_RightFoot().setTakenShoes(selectedItem);
                                owner.getHero_LeftFoot().getTakenShoes().EquipItem(owner);

                            }
                            break;
                        }
                    case 18:
                        {
                            if (MessageBox.Show("想戴在左臂上吗？不想戴左臂就戴在右臂", "戴在哪只手臂？", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                if (owner.getHero_LeftArm().getIsEquipedSign())
                                {
                                    MessageBox.Show("左臂已经有臂章了", "戴不了", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                    owner.getHero_LeftArm().setIsEquipedSign(true);
                                    owner.getHero_LeftArm().setTakenSign(selectedItem);
                                    owner.getHero_LeftArm().getTakenSign().EquipItem(owner);
                                }
                            }
                            else
                            {
                                if (owner.getHero_RightArm().getIsEquipedSign())
                                {
                                    MessageBox.Show("右臂已经有臂章了", "戴不了", MessageBoxButtons.OK);
                                    return;
                                }
                                else
                                {
                                    owner.getHero_RightArm().setIsEquipedSign(true);
                                    owner.getHero_RightArm().setTakenSign(selectedItem);
                                    owner.getHero_RightArm().getTakenSign().EquipItem(owner);
                                }
                            }
                            break;
                        }
                    case 19:
                        {
                            if (owner.getHero_Chest().getIsEquipedSign())
                            {
                                MessageBox.Show("你已经戴了一个臂章了", "别想戴两个", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {

                                owner.getHero_Chest().setIsEquipedSign(true);
                                owner.getHero_Chest().setTakenSign(selectedItem);
                                owner.getHero_Chest().getTakenSign().EquipItem(owner);

                            }
                            break;
                        }
                    case 20:
                        {
                            if (owner.getHero_LeftFoot().getIsEquipedStock() || owner.getHero_RightFoot().getIsEquipedStock())
                            {
                                MessageBox.Show("你只能穿一双袜子", "。。", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                owner.getHero_LeftFoot().setIsEquipedStock(true);
                                owner.getHero_LeftFoot().setTakenStock(selectedItem);
                                owner.getHero_RightFoot().setIsEquipedStock(true);
                                owner.getHero_RightFoot().setTakenStock(selectedItem);
                                owner.getHero_LeftFoot().getTakenStock().EquipItem(owner);

                            }
                            break;
                        }
                        //新的种类

                }
                selectedItem.setIsEquited(true);
            }
            selectedItem.updataQuality();
        }
        }
    }
}
