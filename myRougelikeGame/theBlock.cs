using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Action;

namespace myRougelikeGame
{
    public partial class theBlock : Form
    {

        /*  HPI为英雄拾取物品的动作
         *  TODO:
         *          该地区已经死亡的敌人可以出现在“地面上的物品”中。
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * */
        public theBlock()
        {
            InitializeComponent();
        }
        private HeroPickItems HPI;
        private void theBlock_Load(object sender, EventArgs e)
        {
            HPI = (HeroPickItems)this.Tag;
            HPI.setBlockItemList(this.blockItemList);
            HPI.setBlockItemListTrue(this.blockItemListTrue);
            HPI.setHeroBagList(this.heroBagList);
            HPI.setHeroBagListTrue(this.heroBagListTrue);
            updata();
        }


        public void updata() {
            HPI.updata();
            leftSpace.Text = "" + (HPI.getHero().getHeroBag().getMaxSpace() - HPI.getHero().getHeroBag().getSpaceNow());
        }
        //拿走所有的，当容量不够时只能拿去前面的几个
        private void TakeAllBtn_Click(object sender, EventArgs e)
        {
            HPI.moveAllItemBlockToBag();
            updata();
        }
        //一个一个拿
        private void TakeOne_Click(object sender, EventArgs e)
        {
            HPI.moveOneItemBlockToBag();
            updata();
        }
        //一个一个扔
        private void giveBackOne_Click(object sender, EventArgs e)
        {
            HPI.moveOneItemBagToBlock();
            updata();
        }
    }
}
