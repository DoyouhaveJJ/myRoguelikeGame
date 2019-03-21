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

        private void TakeAllBtn_Click(object sender, EventArgs e)
        {
            HPI.moveAllItemBlockToBag();
            updata();
        }

        private void TakeOne_Click(object sender, EventArgs e)
        {
            HPI.moveOneItemBlockToBag();
            updata();
        }

        private void giveBackOne_Click(object sender, EventArgs e)
        {
            HPI.moveOneItemBagToBlock();
            updata();
        }
    }
}
