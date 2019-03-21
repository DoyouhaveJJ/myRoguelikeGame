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
    public partial class theLeftLeg : Form
    {
        public theLeftLeg()
        {
            InitializeComponent();
        }

        private void theLeftLeg_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_LeftLeg().getMaxEndurance();
            EnduranceBar.Value = my.getHero_LeftLeg().getEndurance();

            EnduranceShow.Text = my.getHero_LeftLeg().getEndurance() + "/" + my.getHero_LeftLeg().getMaxEndurance();

            injuredLevel.Text = my.getHero_LeftLeg().getInjuredLevel() + "";

            Defense.Text = my.getHero_LeftLeg().getDefense() + "";
            magicDefense.Text = my.getHero_LeftLeg().getMagicDefense() + "";


            if (my.getHero_LeftLeg().getIsEquipedPants())
                PantsShow.Text = my.getHero_LeftLeg().getTakenPants().getName();

        }
    }
}
