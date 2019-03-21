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
    public partial class theWeb : Form
    {
        public theWeb()
        {
            InitializeComponent();
        }

        private void theWeb_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_Web().getMaxEndurance();
            EnduranceBar.Value = my.getHero_Web().getEndurance();

            EnduranceShow.Text = my.getHero_Web().getEndurance() + "/" + my.getHero_Web().getMaxEndurance();

            injuredLevel.Text = my.getHero_Web().getInjuredLevel() + "";

            Defense.Text = my.getHero_Web().getDefense() + "";
            magicDefense.Text = my.getHero_Web().getMagicDefense() + "";


            if (my.getHero_Web().getIsEquipPocked())
                PockedShow.Text = my.getHero_Web().getTakenPocked().getName();
            if (my.getHero_Web().getIsEquipBelt())
                BeltShow.Text = my.getHero_Web().getTakenBelt().getName();
        }
    }
}
