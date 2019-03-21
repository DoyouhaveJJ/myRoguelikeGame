using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Player;

namespace myRougelikeGame.SmallForm
{
    public partial class theLeftFoot : Form
    {
        public theLeftFoot()
        {
            InitializeComponent();
        }

        private void theLeftFoot_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_LeftFoot().getMaxEndurance();
            EnduranceBar.Value = my.getHero_LeftFoot().getEndurance();

            EnduranceShow.Text = my.getHero_LeftFoot().getEndurance() + "/" + my.getHero_LeftFoot().getMaxEndurance();

            injuredLevel.Text = my.getHero_LeftFoot().getInjuredLevel() + "";

            Defense.Text = my.getHero_LeftFoot().getDefense() + "";
            magicDefense.Text = my.getHero_LeftFoot().getMagicDefense() + "";


            if (my.getHero_LeftFoot().getIsEquipedStock())
                StockShow.Text = my.getHero_LeftFoot().getTakenStock().getName();
            if (my.getHero_LeftFoot().getIsEquipedShoes())
                ShoesShow.Text = my.getHero_LeftFoot().getTakenShoes().getName();
  
        }
    }
}
