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
    public partial class theNeck : Form
    {
        public theNeck()
        {
            InitializeComponent();
        }

        private void theNeck_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_Neck().getMaxEndurance();
            EnduranceBar.Value = my.getHero_Neck().getEndurance();

            EnduranceShow.Text = my.getHero_Neck().getEndurance() + "/" + my.getHero_Neck().getMaxEndurance();

            injuredLevel.Text = my.getHero_Neck().getInjuredLevel() + "";

            Defense.Text = my.getHero_Neck().getDefense() + "";
            magicDefense.Text = my.getHero_Neck().getMagicDefense() + "";


            if (my.getHero_Neck().getIsEquipedNecklace())
                NecklaceShow.Text = my.getHero_Neck().getTakenNecklace().getName();
        }
    }
}
