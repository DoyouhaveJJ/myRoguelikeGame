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
    public partial class theRightFoot : Form
    {
        public theRightFoot()
        {
            InitializeComponent();
        }

        private void theRightFoot_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_RightFoot().getMaxEndurance();
            EnduranceBar.Value = my.getHero_RightFoot().getEndurance();

            EnduranceShow.Text = my.getHero_RightFoot().getEndurance() + "/" + my.getHero_RightFoot().getMaxEndurance();

            injuredLevel.Text = my.getHero_RightFoot().getInjuredLevel() + "";

            Defense.Text = my.getHero_RightFoot().getDefense() + "";
            magicDefense.Text = my.getHero_RightFoot().getMagicDefense() + "";


            if (my.getHero_RightFoot().getIsEquipedStock())
                StockShow.Text = my.getHero_RightFoot().getTakenStock().getName();
            if (my.getHero_RightFoot().getIsEquipedShoes())
                ShoesShow.Text = my.getHero_RightFoot().getTakenShoes().getName();
  
        }
    }
}
