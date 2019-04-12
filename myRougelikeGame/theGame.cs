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
using myRougelikeGame.Craft;
namespace myRougelikeGame
{
    public partial class theGame : Form
    {
        /*  主游戏界面
         * HeroPickItemsAction是英雄拾取物品的动作，这里new一个，整个游戏就一个。后面的拾取只要作为引用传入即可
         * ME为遇见敌人的动作，这里new一个，以后就不再new了
         * BF为战场，只new一个
         * myHero，这里new第二个，后面可能要用到最初的hero
         * myWorld为世界，这里只new一个
         * dr为随机数生成器，还能实现概率的功能
         * AddItemAction为添加物品的动作，这里只new一个
         * HeroAttackAction为英雄攻击的动作，这里只new一个，以后都作为引用传入
         * TODO:
         *      实现英雄更多的活动：撒尿拉屎吃饭等
         *      实现更多的随机事件
         *      实现市场系统
         *      实现经济系统
         *      实现天气系统
         *      实现气温四季变化系统
         *      实现大地图敌人随机生成和随机移动系统
         *      实现合成系统DONE
         *      实现载具系统
         *      实现敌人互相斗殴系统
         *      实现昼夜交替系统
         *      实现疾病系统
         *      …………………………………………
         * 
         * */
        DoCraft doCraft = new DoCraft();
        AddMob AddMobAction = new AddMob();
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
            AddMobAction.setMessageBox(this.SystemMsg);
            HeroAttackAction.setMessageBox(this.SystemMsg);
        }

        private void theGame_Load(object sender, EventArgs e)
        {   
            this.Owner.Hide();
            myHero = (theHero)this.Owner.Tag;
            this.Tag = myHero;
            myWorld.init();
            //初始化英雄的数据
            this.myHero.setTheHeroMaxValue(true);
            this.myHero.rebuildTheHero();
            this.myHero.buildConsumeIndex();
            this.myHero.buildBodyIndex();
            this.myHero.initBodyIndex();
            //更新地图
            
            //初始化背包
            myHero.getHeroBag().setOwner(myHero);
            //设置消息栏
            myHero.setMessageBox(this.SystemMsg);
            //背包初始化
            myHero.getHeroBag().updata(myHero);
            //敌人生成器初始化
            AddMobAction.setMyHero(myHero);
            AddMobAction.setMyWorld(myWorld);
           //myWorld.showWorld();
            //初始化合成器
            doCraft.setMyHero(myHero);

            updata();
            updataMap();


            //测试模式
            setTestMode(false);
            
        }
        private void setTestMode(bool a)
        {
            item_ID.Visible = a;
            getItem.Visible = a;
            button14.Visible = a;
            button8.Visible = a;
            button12.Visible = a;
            button4.Visible = a;
            button5.Visible = a;
            button7.Visible = a;
            button9.Visible = a;
            button10.Visible = a;
            button11.Visible = a;
            button1.Visible = a;
        }




        private void button1_Click(object sender, EventArgs e)
        {   //辣鸡代码
            myHero.gainExp(200);
            
        }

        void updata() {
            //更新数据
            AddMobAction.AddAnMobOnRandomBlockNearbyHero(5, 1, 20);
            myHero.setStandBlock(myWorld.getBlockByXY(myHero.getLoc_x(), myHero.getLoc_y()));
            label1.Text = myHero.getStandBlock().getName();
            ME.MeetEnemyAtBlock(myHero,BF);
        
        }
        void updataMap() {
            //更新地图,以3,3点为中心，英雄移动会影响各个区域
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
   //         myHero.setStandBlock(myWorld.getBlockByXY(x, y));

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
        //一下一大堆代码，就是更新函数
        
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
            updata();
        }

        private void Move_E_Click(object sender, EventArgs e)
        {
            myHero.move_E();
            updataMap();
            updata();
        }

        private void Move_S_Click(object sender, EventArgs e)
        {
            myHero.move_S();
            updataMap();
            updata();
        }

        private void Move_W_Click(object sender, EventArgs e)
        {
            myHero.move_W();
            updataMap();
            updata();
        }

        void setColorByType(Label lb, int type){
            switch(type){
                case 1: { lb.ForeColor = System.Drawing.Color.Green; break; }
                case 2: { lb.ForeColor = System.Drawing.Color.DarkGreen; break; }
                case 3: { lb.ForeColor = System.Drawing.Color.Blue; break; }
                case 4: { lb.ForeColor = System.Drawing.Color.SaddleBrown; break; }
                case 5: { lb.ForeColor = System.Drawing.Color.Gray; break; }
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
            myHero.addOneItem(AddItemAction.AddOneItemByID(int.Parse(item_ID.Text)));
          //AddItemAction.AddOneItemByID(item_ID.Text, myHero);
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
            ME.MeetEnemyAtBlock(myHero,BF);
        }

        private void button13_Click(object sender, EventArgs e)
        {   //生成“搜刮”窗口
            theLoot tl = new theLoot();
            tl.Tag = myHero.getStandBlock().getBlockLoot();
            myHero.getStandBlock().getBlockLoot().setAddItemAction(this.AddItemAction);
            myHero.getStandBlock().getBlockLoot().setHero(myHero);
            tl.ShowDialog(this);

        }

        private void cheeckBlock_Click(object sender, EventArgs e)
        {   //生成“检查地面”窗口
            theBlock tb = new theBlock();
            HeroPickItemsAction.setHero(myHero);
            HeroPickItemsAction.setTheBlock(myHero.getStandBlock());
            tb.Tag = HeroPickItemsAction;
            tb.ShowDialog(this);
        }




        public System.Windows.Forms.ListBox getSystemMsg() {
            return this.SystemMsg;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddMobAction.AddAnMobOnRandomBlockNearbyHero(3, 4, 8);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            theCraft tc = new theCraft();
            tc.Tag = doCraft;
            tc.ShowDialog(this);
        }
        
            

    }
}
