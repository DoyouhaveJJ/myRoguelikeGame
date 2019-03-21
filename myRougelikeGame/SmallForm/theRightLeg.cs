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
    public partial class theRightLeg : Form
    {
        public theRightLeg()
        {
            InitializeComponent();
        }

        private void theRightLeg_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_RightLeg().getMaxEndurance();
            EnduranceBar.Value = my.getHero_RightLeg().getEndurance();

            EnduranceShow.Text = my.getHero_RightLeg().getEndurance() + "/" + my.getHero_RightLeg().getMaxEndurance();

            injuredLevel.Text = my.getHero_RightLeg().getInjuredLevel() + "";

            Defense.Text = my.getHero_RightLeg().getDefense() + "";
            magicDefense.Text = my.getHero_RightLeg().getMagicDefense() + "";


            if (my.getHero_RightLeg().getIsEquipedPants())
                PantsShow.Text = my.getHero_RightLeg().getTakenPants().getName();

        }
    }
}
