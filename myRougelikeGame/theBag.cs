using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using myRougelikeGame.Player;
using myRougelikeGame.Items.Food;
using myRougelikeGame.Items;
using myRougelikeGame.Function;
using myRougelikeGame.Action;

namespace myRougelikeGame
{
    public partial class theBag : Form
    {
        
        public theBag()
        {
            InitializeComponent();
        }
        HeroEquip HE = new HeroEquip();
        Translate tl = new Translate();
        defaultItem selectedItem;
        theHero owner;
        Bag heroBag ;
        private System.Windows.Forms.ListBox MessageBoxShow;
        public System.Windows.Forms.ListBox getMessageBoxShow()
        {
            return MessageBoxShow;
        }
        public void setMessageBoxShow(System.Windows.Forms.ListBox messageBox)
        {
            MessageBoxShow = messageBox;
        }
        private void theBag_Load(object sender, EventArgs e)
        {
            
            this.Tag = (theHero)this.Owner.Tag;
            owner = (theHero)this.Tag;
            heroBag = owner.getHeroBag();
            heroBag.setOwner(owner);
            for(int i=0;i<heroBag.getItemArrayCount();i++){
                listBox2.Items.Add(heroBag.getItemByIndex(i));
                listBox1.Items.Add(heroBag.getItemByIndex(i).getName());
            }
            heroBag.updata(owner);
            updata();
            
            
        }

        public void updata() {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            heroBag.checkItems();
            heroBag.updata(owner);
            if (listBox1.SelectedItems.Count == 0) {
                UseButton.Visible = false;
                EquipButton.Visible = false;

            }
            for (int i = 0; i < heroBag.getItemArrayCount(); i++)
            {
                listBox2.Items.Add(heroBag.getItemByIndex(i));
                listBox1.Items.Add(heroBag.getItemByIndex(i).getName());
            }
            burdenInfo.Text = heroBag.getBurdenNow() + "/" + heroBag.getMaxBurden()+"千克";
            spaceInfo.Text = heroBag.getSpaceNow() + "/" + heroBag.getMaxSpace();
        }
   


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems.Count > 0)
            {
                //获取选中的值
                int index = this.listBox1.SelectedIndex;

                selectedItem = (defaultItem)listBox2.Items[index];
                showItemInfo(selectedItem);
                switch (selectedItem.getType())
                {
                    case 1: { UseButton.Visible = true;EquipButton.Visible = false ; break; }
                    case 2: { UseButton.Visible = true; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 3: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 4: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 5: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 6: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 7: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 8: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 9: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 10: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 11: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 12: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 13: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 14: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 15: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 16: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 17: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 18: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 19: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }
                    case 20: { UseButton.Visible = false; EquipButton.Visible = true; if (selectedItem.getIsEquited()) EquipButton.Text = "卸下"; else EquipButton.Text = "装备"; break; }


                }
            }
            else {

                
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            selectedItem.UseItem(owner);
            updata();
        }

        private void showItemInfo(defaultItem item) {
            itemName.Text = item.getName();
            itemLevel.Text = item.getLevel() + "级";
            itemEnduranceBar.Maximum = (int)item.getMaxEndurance();
            itemEnduranceBar.Value = (int)item.getEndurance();
            itemEnduranceShow.Text = (int)item.getEndurance() + "/" + (int)item.getMaxEndurance();
            itemCost.Text = item.getCost() + "元";
            itemDescribe.Text = item.getDescribe();
            itemEffectDescribe.Text = item.getEffecDescribe();
            itemType.Text = tl.ItemTypeToString(item.getType());
            itemWeight.Text = item.getWeight() + "千克";

            switch (item.getType()) {
                case 1: { DIYLabel_1.Text = "新鲜程度:"+item.getQualityIndex()+"%";break; }
                case 2: { DIYLabel_1.Text = "攻击力:" + item.getMinDamage() + "~" + item.getMaxDamage()+"\n魔法攻击力:"+item.getMinMagicDamage()+"~"+item.getMaxMagicDamage()+"\n命中率:"+item.getHitRate()+"%"+"\n暴击率:"+item.getGreatDamageRate(); break; }
                case 3: {  DIYLabel_1.Text = "容量:" +item.getRoom() ; break;  }
                case 4: { DIYLabel_1.Text = "攻击力:" + item.getMinDamage() + "~" + item.getMaxDamage() + "\n魔法攻击力:" + item.getMinMagicDamage() + "~" + item.getMaxMagicDamage() + "\n命中率:" + item.getHitRate() + "%" + "\n暴击率:" + item.getGreatDamageRate(); break; }
            }
        }

        private void EquipButton_Click(object sender, EventArgs e)
        {
            HE.HeroEquipItem(owner,selectedItem);
            
            updata();
         /*   if (selectedItem.getIsEquited())//已装备的话则卸下
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
                        //新的种类
                }
                selectedItem.setIsEquited(true);
            }
            selectedItem.updataQuality(); */
            
        }
    }
}
