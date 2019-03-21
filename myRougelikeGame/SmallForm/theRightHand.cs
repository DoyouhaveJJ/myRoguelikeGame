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
    public partial class theRightHand : Form
    {
        public theRightHand()
        {
            InitializeComponent();
        }

        private void theRightHand_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_RightHand().getMaxEndurance();
            EnduranceBar.Value = my.getHero_RightHand().getEndurance();
            
            EnduranceShow.Text = my.getHero_RightHand().getEndurance() + "/" + my.getHero_RightHand().getMaxEndurance();

            injuredLevel.Text = my.getHero_RightHand().getInjuredLevel() + "";

            Defense.Text = my.getHero_RightHand().getDefense() + "";
            magicDefense.Text = my.getHero_RightHand().getMagicDefense() + "";

            if (my.getHero_RightHand().getIsEquipedSomething())
                TakenShow.Text = my.getHero_RightHand().getTakeInHand().getName();
            if (my.getHero_RightHand().getIsEquipedGlove())
                GloveShow.Text = my.getHero_RightHand().getTakenGlove().getName();
            if (my.getHero_RightHand().getIsEquipedRing())
               RingShow.Text = my.getHero_RightHand().getTakenRing().getName();

        }
    }
}
