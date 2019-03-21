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
    public partial class theLeftHand : Form
    {
        public theLeftHand()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void theLeftHand_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_LeftHand().getMaxEndurance();
            EnduranceBar.Value = my.getHero_LeftHand().getEndurance();
            
            EnduranceShow.Text = my.getHero_LeftHand().getEndurance() + "/" + my.getHero_LeftHand().getMaxEndurance();

            injuredLevel.Text = my.getHero_LeftHand().getInjuredLevel() + "";

            Defense.Text = my.getHero_LeftHand().getDefense() + "";
            magicDefense.Text = my.getHero_LeftHand().getMagicDefense() + "";

            if (my.getHero_LeftHand().getIsEquipedSomething())
                TakenShow.Text = my.getHero_LeftHand().getTakeInHand().getName();
            if (my.getHero_LeftHand().getIsEquipedGlove())
                GloveShow.Text = my.getHero_LeftHand().getTakenGlove().getName();
            if (my.getHero_LeftHand().getIsEquipedRing())
                RingsShow.Text = my.getHero_LeftHand().getTakenRing().getName();


           }

        private void injuredLevel_Click(object sender, EventArgs e)
        {

        }

        private void Defense_Click(object sender, EventArgs e)
        {

        }

        private void magicDefense_Click(object sender, EventArgs e)
        {

        }

        private void GloveShow_Click(object sender, EventArgs e)
        {

        }

        private void TakenShow_Click(object sender, EventArgs e)
        {

        }

        private void EnduranceShow_Click(object sender, EventArgs e)
        {

        }

        private void RingsShow_Click(object sender, EventArgs e)
        {

        }
    }
}
