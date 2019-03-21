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
    public partial class theLeftArm : Form
    {
        public theLeftArm()
        {
            InitializeComponent();
        }

        private void theLeftArm_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_LeftArm().getMaxEndurance();
            EnduranceBar.Value = my.getHero_LeftArm().getEndurance();

            EnduranceShow.Text = my.getHero_LeftArm().getEndurance() + "/" + my.getHero_LeftArm().getMaxEndurance();

            injuredLevel.Text = my.getHero_LeftArm().getInjuredLevel() + "";

            Defense.Text = my.getHero_LeftArm().getDefense() + "";
            magicDefense.Text = my.getHero_LeftArm().getMagicDefense() + "";


            if (my.getHero_LeftArm().getIsEquipedSign())
                SignShow.Text = my.getHero_LeftArm().getTakenSign().getName();

        }
    }
}
