using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Player;
using myRougelikeGame.Function;
using myRougelikeGame.SmallForm;

namespace myRougelikeGame
{
    public partial class thePlayer : Form
    {
        /*  tl为翻译，翻译，翻译
         *  这里是英雄的个人信息界面，大多数代码都是现实数据用的，所以说，看上去很多，其实都是辣鸡代码
         * 
         *  TODO:
         *          实现“英雄身着的衣服会改变部位防御力”的功能
         *          实现“衣服给技能”的功能
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * */
        Translate tl = new Translate();
        public thePlayer()
        {
            InitializeComponent();
        }
        theHero myHero = new theHero();
        private void thePlayer_Load(object sender, EventArgs e)
        {   
            
            myHero = (theHero)this.Owner.Tag;
            this.Text = myHero.GetName();
            updata();

        }

        public void updata() {
            myHero.getHeroBag().updata(myHero);

            HpBar.Maximum = myHero.getMaxHp();
            HpBar.Value = myHero.getHp();
            HpBarShow.Text = HpBar.Value + "/" + HpBar.Maximum;

            HungryBar.Maximum = myHero.getMaxHungry();
            HungryBar.Value = myHero.getHungry();
            HungryShow.Text = HungryBar.Value + "/" + HungryBar.Maximum;

            ThirstyBar.Maximum = myHero.getMaxThirsty();
            ThirstyBar.Value = myHero.getThirsty();
            ThirstyShow.Text = ThirstyBar.Value + "/" + ThirstyBar.Maximum;

            PeeBar.Maximum = myHero.getMaxPee();
            PeeBar.Value = myHero.getPee();
            PeeeShow.Text = PeeBar.Value + "/" + PeeBar.Maximum;

            ShitBar.Maximum = myHero.getMaxShit();
            ShitBar.Value = myHero.getShit();
            ShitShow.Text = ShitBar.Value + "/" + ShitBar.Maximum;

            TemperBar.Maximum = (int)myHero.getMaxTemperture();
            TemperBar.Value = (int)myHero.getTemperature();
            TemperShow.Text = myHero.getTemperature() + "/" + myHero.getMaxTemperture() + "摄氏度";

            ImmBar.Maximum = myHero.getMaxImmunity();
            ImmBar.Value = myHero.getImmunity();
            ImmShow.Text = ImmBar.Value + "/" + ImmBar.Maximum;

            BloodBar.Maximum = myHero.getMaxBlood();
            BloodBar.Value = myHero.getBlood();
            BloodShow.Text = BloodBar.Value + "/" + BloodBar.Maximum;

            PainBar.Maximum = myHero.getMaxPain();
            PainBar.Value = myHero.getPain();
            PainShow.Text = PainBar.Value + "/" + PainBar.Maximum;

            EnergyBar.Maximum = myHero.getMaxEnergy();
            EnergyBar.Value = myHero.getEnergy();
            EnergyShow.Text = EnergyBar.Value + "/" + EnergyBar.Maximum;

            BurdenBar.Maximum = (int)myHero.getMaxBurden();
            BurdenBar.Value = (int)myHero.getBurden();
            BurdenShow.Text = myHero.getBurden() + "/" + myHero.getMaxBurden() + "千克";

            ExpBar.Maximum = myHero.getMaxExp();
            ExpBar.Value = myHero.getExp();
            ExpBarShow.Text = ExpBar.Value + "/" + ExpBar.Maximum;

            hero_level.Text = myHero.getLevel().ToString();
            hero_age.Text = myHero.getHero_age().ToString() + "岁";
            hero_agility.Text = myHero.getHero_agility().ToString();
            hero_bloodtype.Text = tl.BloodTypeToString(myHero.getHero_bloodtype());
            hero_charm.Text = myHero.getHero_charm().ToString();
            hero_endurance.Text = myHero.getHero_endurance().ToString();
            hero_eq.Text = myHero.getHero_eq().ToString();
            hero_eye.Text = myHero.getHero_eye().ToString() + "度";
            hero_face.Text = myHero.getHero_face().ToString();
            hero_group.Text = tl.GroupToString(myHero.getHero_group());
            hero_hair.Text = myHero.getHero_hair().ToString() + "根";
            hero_height.Text = myHero.getHero_height().ToString() + "厘米";
            hero_iq.Text = myHero.getHero_iq().ToString();
            hero_job.Text = tl.JobToString(myHero.getHero_job());
            hero_lucky.Text = myHero.getHero_lucky().ToString();
            hero_money.Text = myHero.getHero_money().ToString() + "元";
            hero_sex.Text = tl.SexToString(myHero.getHero_sex());
            hero_strength.Text = myHero.getHero_strength().ToString();
            hero_talk.Text = myHero.getHero_talk().ToString();
            hero_weight.Text = myHero.getHero_weight().ToString() + "千克";




        }

        private void button1_Click(object sender, EventArgs e)
        {
            theHead head = new theHead();
            head.Tag = myHero;
            head.ShowDialog(this);

        }

        private void button11_Click(object sender, EventArgs e)
        {

            theRightHand rh = new theRightHand();
            rh.Tag = myHero;
            rh.ShowDialog(this);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            theLeftHand lh = new theLeftHand();
            lh.Tag = myHero;
            lh.ShowDialog(this);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            theNeck n = new theNeck();
            n.Tag = myHero;
            n.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            theChest c = new theChest();
            c.Tag = myHero;
            c.ShowDialog(this);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            theRightArm ra = new theRightArm();
            ra.Tag = myHero;
            ra.ShowDialog(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            theLeftArm la = new theLeftArm();
            la.Tag = myHero;
            la.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            theWeb w = new theWeb();
            w.Tag = myHero;
            w.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            theRightLeg rl = new theRightLeg();
            rl.Tag = myHero;
            rl.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            theRightFoot rf = new theRightFoot();
            rf.Tag = myHero;
            rf.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            theLeftLeg ll = new theLeftLeg();
            ll.Tag = myHero;
            ll.ShowDialog(this);
        }

        private void button8_Click(object sendel, EventArgs e)
        {
            theLeftFoot lf = new theLeftFoot();
            lf.Tag = myHero;
            lf.ShowDialog(this);
        }

        
    }
}
