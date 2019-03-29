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
        /*  HE为英雄穿装备的动作
         *  tl为翻译
         *  selectedItem为当前选中的物品
         *  owner为英雄
         *  Bag为英雄的背包
         *  MessageBoxShow为输出信息的窗口
         * 
         * 
         * TODO:实现物品整理功能
         *      实现物品丢弃功能  
         *      实现物品自由排序功能    
         *      实现物品拖拽排序功能
         * 
         * 
         * 
         * */
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
            //此时向listBox2中填入物品数据，listBox1中填入物品名
            //listBox1中的物品名是供用户观看的，真正的操作是在listBox2中运行的
            for(int i=0;i<heroBag.getItemArrayCount();i++){
                listBox2.Items.Add(heroBag.getItemByIndex(i));
                listBox1.Items.Add(heroBag.getItemByIndex(i).getName());
            }
            heroBag.updata(owner);
            updata();
            
            
        }
        //更新函数，主要是对窗口显示，按钮显示
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
   

        //当选择的物品改变
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems.Count > 0)
            {
                //获取选中的物品，根据物品的特性选择显示按钮
                //TODO 代码量太大，可以实现简单的函数来控制按钮的显示与否
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
            //隐藏表
        }

        private void UseButton_Click(object sender, EventArgs e)
        {
            selectedItem.UseItem(owner);
            updata();
        }
        //显示数据
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
            HE.HeroEquipItem(owner, selectedItem);
            updata();
        }
    }
}
