using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Items.Wearable.Hats;
using myRougelikeGame.Items.Wearable.Masks;
using myRougelikeGame.Items.Wearable.Glasses;
using myRougelikeGame.Items.Wearable.Earplugs;
using myRougelikeGame.Player;

namespace myRougelikeGame.SmallForm
{
    public partial class theHead : Form
    {
        public theHead()
        {
            InitializeComponent();
        }
        private void theHead_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_Head().getMaxEndurance();
            EnduranceBar.Value = my.getHero_Head().getEndurance();
            
            EnduranceShow.Text = my.getHero_Head().getEndurance() + "/" + my.getHero_Head().getMaxEndurance();

            injuredLevel.Text = my.getHero_Head().getInjuredLevel()+"";

            Defense.Text = my.getHero_Head().getDefense() + "";
            magicDefense.Text = my.getHero_Head().getMagicDefense() + "";


            if (my.getHero_Head().getIsEquipedHat())
                HatShow.Text = my.getHero_Head().getTakenHat().getName();
            if (my.getHero_Head().getIsEquipedMask())
                MaskShow.Text = my.getHero_Head().getTakenMask().getName();
            if (my.getHero_Head().getIsEquipedGlass())
                GlassesShow.Text = my.getHero_Head().getTakenGlass().getName();
            if (my.getHero_Head().getIsEquipedEarplug())
                EarplugShow.Text = my.getHero_Head().getTakenEarplug().getName();

        }


    }
}
