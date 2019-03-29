using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Loot;
using myRougelikeGame.Action;

namespace myRougelikeGame
{
    public partial class theLoot : Form
    {
        /*  HeroLoot为英雄搜刮的动作类
         *  defaultLoot为默认的搜刮种类，每种地区都有不同的搜刮种类，搜刮种类包括了很多东西（可搜刮物，搜刮几率）
         *  TODO:
         *          实现隐蔽值
         *          实现安全值
         *          实现“利用英雄技能可以提高（降低）搜刮率、隐蔽值、安全值”的功能
         *          实现“利用各种物品可以提高（降低）搜刮率、隐蔽值、安全值”的功能
         *          实现搜刮的随机事件
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
        public theLoot()
        {
            InitializeComponent();
        }
        private HeroLoot HeroLootAction = new HeroLoot();
        private defaultLoot Lootage;
        private void theLoot_Load(object sender, EventArgs e)
        {
            //获取搜刮类，搜刮类从英雄当前的地区中获得
            Lootage = (defaultLoot)this.Tag;
            blockName.Text = Lootage.getTheBlock().getName();
            lootBar.Maximum = Lootage.getMaxLootIndex();
            lootBar.Value = Lootage.getLootIndex();
            //将搜刮类的引用给英雄动作
            HeroLootAction.setLoot(Lootage);
            HeroLootAction.setLootMessage(lootMsg);
            HeroLootAction.setAddItemAction(Lootage.getAddItemAction());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeroLootAction.Loot();
            updata();

        }
        private void updata() {
            lootBar.Maximum = Lootage.getMaxLootIndex();
            lootBar.Value = Lootage.getLootIndex();

        }

















      
    }
}
