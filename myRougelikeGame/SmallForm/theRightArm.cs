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
    public partial class theRightArm : Form
    {
        public theRightArm()
        {
            InitializeComponent();
        }

        private void theRightArm_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_RightArm().getMaxEndurance();
            EnduranceBar.Value = my.getHero_RightArm().getEndurance();

            EnduranceShow.Text = my.getHero_RightArm().getEndurance() + "/" + my.getHero_RightArm().getMaxEndurance();

            injuredLevel.Text = my.getHero_RightArm().getInjuredLevel() + "";

            Defense.Text = my.getHero_RightArm().getDefense() + "";
            magicDefense.Text = my.getHero_RightArm().getMagicDefense() + "";


            if (my.getHero_RightArm().getIsEquipedSign())
                SignShow.Text = my.getHero_RightArm().getTakenSign().getName();

        }
    }
}
