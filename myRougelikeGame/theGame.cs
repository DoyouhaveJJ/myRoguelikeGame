using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Map;
using myRougelikeGame.Player;
using myRougelikeGame.Function;
using myRougelikeGame.Items;
using myRougelikeGame.Items.Food;
using myRougelikeGame.Items.Weapon;
using myRougelikeGame.Items.Wearable.BagForHand;
using myRougelikeGame.Help;
using myRougelikeGame.Action;
using myRougelikeGame.Battle;
using myRougelikeGame.Loot;
namespace myRougelikeGame
{
    public partial class theGame : Form
    {
        HeroPickItems HeroPickItemsAction = new HeroPickItems();
        MeetEnemy ME = new MeetEnemy();
        BattleField BF = new BattleField();
        theHero myHero = new theHero();
        world myWorld = new world();
        DIYRandom dr = new DIYRandom();
        AddItem AddItemAction = new AddItem();
        HeroAttack HeroAttackAction = new HeroAttack();
        public theGame()
        {
            InitializeComponent();
            myHero.setLoc_x(0);
            myHero.setLoc_y(0);
            myHero.setMessageBox(this.SystemMsg);
            AddItemAction.setMessageBox(this.SystemMsg);
            HeroAttackAction.setMessageBox(this.SystemMsg);
            BF.clearBattle();
        }

        private void theGame_Load(object sender, EventArgs e)
        {   
            this.Owner.Hide();
            myHero = (theHero)this.Owner.Tag;
            this.Tag = myHero;
            myWorld.init();
            this.myHero.setTheHeroMaxValue(true);
            this.myHero.rebuildTheHero();
            this.myHero.buildConsumeIndex();
            this.myHero.buildBodyIndex();
            this.myHero.initBodyIndex();

            updata();
            updataMap();
            myHero.getHeroBag().setOwner(myHero);
            myHero.setMessageBox(this.SystemMsg);
            myHero.getHeroBag().updata(myHero);
            
           //myWorld.showWorld();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myHero.gainExp(200);
            updata();
        }

        void updata() {

            Exp.Text = myHero.getExp().ToString();
            maxExp.Text = myHero.getMaxExp().ToString();
            Level.Text = myHero.getLevel().ToString();
        
        }
        void updataMap() {
            int x = myHero.getLoc_x();
            int y = myHero.getLoc_y();
            locationLabel.Text = x + "," + y;
            updataBlock1_1(x - 2,y + 2);
            updataBlock1_2(x - 1, y + 2);
            updataBlock1_3(x, y + 2);
            updataBlock1_4(x + 1, y + 2);
            updataBlock1_5(x + 2, y + 2);

            updataBlock2_1(x - 2, y + 1);
            updataBlock2_2(x - 1, y + 1);
            updataBlock2_3(x, y + 1);
            updataBlock2_4(x + 1, y + 1);
            updataBlock2_5(x + 2, y + 1);

            updataBlock3_1(x - 2, y);
            updataBlock3_2(x - 1, y);
            updataBlock3_3(x, y);
            myHero.setStandBlock(myWorld.getBlockByXY(x, y));

            updataBlock3_4(x + 1, y);
            updataBlock3_5(x + 2, y);

            updataBlock4_1(x - 2, y - 1);
            updataBlock4_2(x - 1, y - 1);
            updataBlock4_3(x, y - 1);
            updataBlock4_4(x + 1, y - 1);
            updataBlock4_5(x + 2, y - 1);

            updataBlock5_1(x - 2, y - 2);
            updataBlock5_2(x - 1, y - 2);
            updataBlock5_3(x, y - 2);
            updataBlock5_4(x + 1, y - 2);
            updataBlock5_5(x + 2, y - 2);


        }


        void updataBlock1_1(int x, int y) {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block1_1.Text = "X"; return; }
            block1_1.Text = myWorld.showBlock(x,y);
            setColorByType(block1_1, myWorld.getBlockType(x, y));
        }
        void updataBlock1_2(int x, int y)
        {
            if (x < 0 || y < 0 || x>399 ||y>399) { block1_2.Text = "X"; return; }
            block1_2.Text = myWorld.showBlock(x, y);
            setColorByType(block1_2, myWorld.getBlockType(x, y));
        }
        void updataBlock1_3(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block1_3.Text = "X"; return; }
            block1_3.Text = myWorld.showBlock(x, y);
            setColorByType(block1_3, myWorld.getBlockType(x, y));
        }
        void updataBlock1_4(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block1_4.Text = "X"; return; }
            block1_4.Text = myWorld.showBlock(x, y);
            setColorByType(block1_4, myWorld.getBlockType(x, y));
        }
        void updataBlock1_5(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block1_5.Text = "X"; return; }
            block1_5.Text = myWorld.showBlock(x, y);
            setColorByType(block1_5, myWorld.getBlockType(x, y));
        }

        void updataBlock2_1(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block2_1.Text = "X"; return; }
            block2_1.Text = myWorld.showBlock(x, y);
            setColorByType(block2_1, myWorld.getBlockType(x, y));
        }
        void updataBlock2_2(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block2_2.Text = "X"; return; }
            block2_2.Text = myWorld.showBlock(x, y);
            setColorByType(block2_2, myWorld.getBlockType(x, y));
        }
        void updataBlock2_3(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block2_3.Text = "X"; return; }
            block2_3.Text = myWorld.showBlock(x, y);
            setColorByType(block2_3, myWorld.getBlockType(x, y));
        }
        void updataBlock2_4(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block2_4.Text = "X"; return; }
            block2_4.Text = myWorld.showBlock(x, y);
            setColorByType(block2_4, myWorld.getBlockType(x, y));
        }
        void updataBlock2_5(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block2_5.Text = "X"; return; }
            block2_5.Text = myWorld.showBlock(x, y);
            setColorByType(block2_5, myWorld.getBlockType(x, y));
        }


        void updataBlock3_1(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block3_1.Text = "X"; return; }
            block3_1.Text = myWorld.showBlock(x, y);
            setColorByType(block3_1, myWorld.getBlockType(x, y));
        }
        void updataBlock3_2(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block3_2.Text = "X"; return; }
            block3_2.Text = myWorld.showBlock(x, y);
            setColorByType(block3_2, myWorld.getBlockType(x, y));
        }
        void updataBlock3_3(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block3_3.Text = "X"; return; }
            block3_3.Text = myWorld.showBlock(x, y);
            
        }
        void updataBlock3_4(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block3_4.Text = "X"; return; }
            block3_4.Text = myWorld.showBlock(x, y);
            setColorByType(block3_4, myWorld.getBlockType(x, y));
        }
        void updataBlock3_5(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block3_5.Text = "X"; return; }
            block3_5.Text = myWorld.showBlock(x, y);
            setColorByType(block3_5, myWorld.getBlockType(x, y));
        }


        void updataBlock4_1(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block4_1.Text = "X"; return; }
            block4_1.Text = myWorld.showBlock(x, y);
            setColorByType(block4_1, myWorld.getBlockType(x, y));
        }
        void updataBlock4_2(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block4_2.Text = "X"; return; }
            block4_2.Text = myWorld.showBlock(x, y);
            setColorByType(block4_2, myWorld.getBlockType(x, y));
        }
        void updataBlock4_3(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block4_3.Text = "X"; return; }
            block4_3.Text = myWorld.showBlock(x, y);
            setColorByType(block4_3, myWorld.getBlockType(x, y));
        }
        void updataBlock4_4(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block4_4.Text = "X"; return; }
            block4_4.Text = myWorld.showBlock(x, y);
            setColorByType(block4_4, myWorld.getBlockType(x, y));
        }
        void updataBlock4_5(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block4_5.Text = "X"; return; }
            block4_5.Text = myWorld.showBlock(x, y);
            setColorByType(block4_5, myWorld.getBlockType(x, y));
        }


        void updataBlock5_1(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block5_1.Text = "X"; return; }
            block5_1.Text = myWorld.showBlock(x, y);
            setColorByType(block5_1, myWorld.getBlockType(x, y));
        }
        void updataBlock5_2(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block5_2.Text = "X"; return; }
            block5_2.Text = myWorld.showBlock(x, y);
            setColorByType(block5_2, myWorld.getBlockType(x, y));
        }
        void updataBlock5_3(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block5_3.Text = "X"; return; }
            block5_3.Text = myWorld.showBlock(x, y);
            setColorByType(block5_3, myWorld.getBlockType(x, y));
        }
        void updataBlock5_4(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block5_4.Text = "X"; return; }
            block5_4.Text = myWorld.showBlock(x, y);
            setColorByType(block5_4, myWorld.getBlockType(x, y));
        }
        void updataBlock5_5(int x, int y)
        {
            if (x < 0 || y < 0 || x > 399 || y > 399) { block5_5.Text = "X"; return; }
            block5_5.Text = myWorld.showBlock(x, y);
            setColorByType(block5_5, myWorld.getBlockType(x, y));
        }

        private void Move_N_Click(object sender, EventArgs e)
        {
            myHero.move_N();
            updataMap();
        }

        private void Move_E_Click(object sender, EventArgs e)
        {
            myHero.move_E();
            updataMap();
        }

        private void Move_S_Click(object sender, EventArgs e)
        {
            myHero.move_S();
            updataMap();
        }

        private void Move_W_Click(object sender, EventArgs e)
        {
            myHero.move_W();
            updataMap();
        }

        void setColorByType(Label lb, int type){
            switch(type){
                case 1: { lb.ForeColor = System.Drawing.Color.Green; break; }
                case 2: { lb.ForeColor = System.Drawing.Color.DarkGreen; break; }
                case 3: { lb.ForeColor = System.Drawing.Color.Blue; break; }
                case 4: { lb.ForeColor = System.Drawing.Color.SaddleBrown; break; }
         }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thePlayer p = new thePlayer();
            p.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            theBag b = new theBag();
            b.setMessageBoxShow(this.SystemMsg);
            b.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }


        private void button6_Click(object sender, EventArgs e)
        {
            myHero.heroRest();
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;
        }

        private void item_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void getItem_Click(object sender, EventArgs e)
        {
            AddItemAction.AddOneItemByID(item_ID.Text, myHero);
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            HeroAttackAction.AttackByLeftHand(myHero);
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            HeroAttackAction.AttackByRightHand(myHero);
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HeroAttackAction.AttackByBothHand(myHero);
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            HelpItem hi = new HelpItem();
            hi.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HeroAttackAction.AttackByLeftHandByMagic(myHero);
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HeroAttackAction.AttackByRightHandByMagic(myHero);
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HeroAttackAction.AttackByBothHandByMagic(myHero);
            SystemMsg.SelectedIndex = SystemMsg.Items.Count - 1;
        }

        private void SystemMsg_Change(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ME.MeetAnEnemy(myHero,BF);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            theLoot tl = new theLoot();
            tl.Tag = myHero.getStandBlock().getBlockLoot();
            myHero.getStandBlock().getBlockLoot().setAddItemAction(this.AddItemAction);
            myHero.getStandBlock().getBlockLoot().setHero(myHero);
            tl.ShowDialog(this);

        }

        private void cheeckBlock_Click(object sender, EventArgs e)
        {
            theBlock tb = new theBlock();
            HeroPickItemsAction.setHero(myHero);
            HeroPickItemsAction.setTheBlock(myHero.getStandBlock());
            tb.Tag = HeroPickItemsAction;
            tb.ShowDialog(this);
        }




        public System.Windows.Forms.ListBox getSystemMsg() {
            return this.SystemMsg;
        }
        
            

    }
}
