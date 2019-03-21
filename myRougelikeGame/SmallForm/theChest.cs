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
    public partial class theChest : Form
    {
        public theChest()
        {
            InitializeComponent();
        }

        private void theChest_Load(object sender, EventArgs e)
        {
            theHero my = (theHero)this.Tag;
            EnduranceBar.Maximum = my.getHero_Chest().getMaxEndurance();
            EnduranceBar.Value = my.getHero_Chest().getEndurance();

            EnduranceShow.Text = my.getHero_Chest().getEndurance() + "/" + my.getHero_Chest().getMaxEndurance();

            injuredLevel.Text = my.getHero_Chest().getInjuredLevel() + "";

            Defense.Text = my.getHero_Chest().getDefense() + "";
            magicDefense.Text = my.getHero_Chest().getMagicDefense() + "";


            if (my.getHero_Chest().getIsEquipedBackpack())
                BackPackShow.Text = my.getHero_Chest().getTakenBackpack().getName();
            if (my.getHero_Chest().getIsEquipedCloth())
                ClothShow.Text = my.getHero_Chest().getTakenCloth().getName();
            if (my.getHero_Chest().getIsEquipedSign())
                SignShow.Text = my.getHero_Chest().getTakenSign().getName();

        }
    }
}
