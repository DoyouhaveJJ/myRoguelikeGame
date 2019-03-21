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
        public theLoot()
        {
            InitializeComponent();
        }
        private HeroLoot HeroLootAction = new HeroLoot();
        private defaultLoot Lootage;
        private void theLoot_Load(object sender, EventArgs e)
        {
            
            Lootage = (defaultLoot)this.Tag;
            blockName.Text = Lootage.getTheBlock().getName();
            lootBar.Maximum = Lootage.getMaxLootIndex();
            lootBar.Value = Lootage.getLootIndex();
            HeroLootAction.setLoot(Lootage);
            HeroLootAction.setLootMessage(lootMsg);
            HeroLootAction.setAddItemAction(Lootage.getAddItemAction());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeroLootAction.Loot();

        }


















      
    }
}
