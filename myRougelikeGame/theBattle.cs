using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Mob.Enemy;
using myRougelikeGame.Mob;
using myRougelikeGame.Action;
using myRougelikeGame.Player;
using myRougelikeGame.Battle;
using myRougelikeGame.Function;

namespace myRougelikeGame
{
    public partial class theBattle : Form
    {
        BattleSeeEachOther BSEO = new BattleSeeEachOther();
        HeroAttack HeroAttackAction = new HeroAttack();
        EnemyAttack EnemyAttackAction = new EnemyAttack();
        BattleField BF;
        DIYRandom dr = new DIYRandom();
        public int theDistence;
        public string EnemylastMove;
        public string HeroLastMove;
        public theBattle()
        {
            InitializeComponent();
        }
        private void BattleMsg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void theBattle_Load(object sender, EventArgs e)
        {
            BSEO.init();
            BF = (BattleField)this.Tag;
            EnemyAttackAction.setMessageBox(this.BattleMsg);
            HeroAttackAction.setMessageBox(this.BattleMsg);
            BF.getTheMob().getAI().setEA(EnemyAttackAction);
            BF.getTheMob().getAI().setBf(BF);
            BF.getTheMob().getAI().setHero(BF.getMyHero());
            heroName.Text = BF.getMyHero().GetName();
            BSEO.judgeOnce(BF.getMyHero(), BF.getTheMob());
            updata();
        }
        public void EndTurn() {
            BF.getTheMob().getAI().setDistenceNow(theDistence);
            BF.getTheMob().getAI().JudgeOnce();
            BF.getBseo().judgeOnce(BF.getMyHero(), BF.getTheMob());
            BSEO.judgeOnce(BF.getMyHero(), BF.getTheMob());
            updata();
        }
        public void updata(){
            if (BF.getTheMob().isDead())
            {
                chargeBtn.Visible = false;
                moveTowardBtn.Visible = false;
                escapeBtn.Visible = false;
                fallBackBtn.Visible = false;
                attackBtn.Visible = false;
                waitBtn.Visible = false;
                WinBtn.Visible = true;
                return;
            }
            if (BSEO.getIsEnemySeeHero())
                enemyVisable.Text = "是";
            else
                enemyVisable.Text = "否";
            if (BSEO.getIsHeroSeeEnemy())
            {
                heroVisable.Text = "是";
                hero_search.Visible = false;
                enemyName.Text = BF.getTheMob().getMob_Name();
                enemyLevel.Text = BF.getTheMob().getMob_Level() + "";
            }
            else
            {
                heroVisable.Text = "否";
                hero_search.Visible = true;
                enemyName.Text = "???";
                enemyLevel.Text = "???";
                
            }
            Distence.Text = BF.getDistence() + "";
            enemyLastAction.Text = BF.getEnemyLastMove();
            heroLastAction.Text = BF.getHeroLastMove();
            if (BF.getDistence() > 3)
            {
                attack_aimless.Visible = false;
                attackBtn.Visible = false;
            }
            else {
                if (BSEO.getIsHeroSeeEnemy())
                {
                    attackBtn.Visible = true;
                    attack_aimless.Visible = false;
                }
                else {
                    attackBtn.Visible = false;
                    attack_aimless.Visible = true;
                }
                
               }  
        }

        private defaultMob initAnEnemy() {
            return new enemy_Slime();
        }
        private void fallBackBtn_Click(object sender, EventArgs e)
        {
            BF.setDistence(BF.getDistence() + 1);
            BF.setHeroLastMove("后退");
            EndTurn();
        }
        private void moveTowardBtn_Click(object sender, EventArgs e)
        {
            BF.setDistence(BF.getDistence() - 1);
            BF.setHeroLastMove("前进");
            EndTurn();
        }
        private void chargeBtn_Click(object sender, EventArgs e)
        {
            BF.setDistence(BF.getDistence() - 2);
            BF.setHeroLastMove("冲锋");
            EndTurn();
        }

        private void escapeBtn_Click(object sender, EventArgs e)
        {
            BF.setDistence(BF.getDistence() + 2);
            BF.setHeroLastMove("逃跑");
            EndTurn();
        }

        private void attackBtn_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                HeroAttackAction.AttackEnemy(BF.getMyHero(), BF.getTheMob(), 1);
            else if(radioButton2.Checked)
                HeroAttackAction.AttackEnemy(BF.getMyHero(), BF.getTheMob(), 2);
            else if(radioButton3.Checked)
                HeroAttackAction.AttackEnemy(BF.getMyHero(), BF.getTheMob(), 5);
            BF.setHeroLastMove("攻击");
            EndTurn();
        }

        private void waitBtn_Click(object sender, EventArgs e)
        {
            BF.getMyHero().setEnergy(BF.getMyHero().getEnergy()+18);
            EndTurn();
        }

        private void WinBtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("你打赢了" + BF.getTheMob().getMob_Name() + "获得" + BF.getTheMob().getMob_Level() * 100 + "经验值");
            BF.getMyHero().gainExp(BF.getTheMob().getMob_Level() * 100);
            BF.clearBattle();
            this.Close();
        }

        private void heroStatus_Click(object sender, EventArgs e)
        {

        }

        public void checkedWeapon(){
            
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                if (BF.getMyHero().getHero_LeftHand().getIsEquipedSomething())
                {
                    weapon.Text = BF.getMyHero().getHero_LeftHand().getTakeInHand().getName();
                }
                else {
                    weapon.Text = "无";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (BF.getMyHero().getHero_RightHand().getIsEquipedSomething())
            {
                weapon.Text = BF.getMyHero().getHero_RightHand().getTakeInHand().getName();
            }
            else
            {
                weapon.Text = "无";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (BF.getMyHero().getHero_LeftHand().getIsEquipedSomething() && BF.getMyHero().getHero_RightHand().getIsEquipedSomething())
            {
                if (BF.getMyHero().getHero_LeftHand().getTakeInHand() == BF.getMyHero().getHero_RightHand().getTakeInHand())
                    if (BF.getMyHero().getHero_LeftHand().getTakeInHand().getType() == 4)
                        weapon.Text = BF.getMyHero().getHero_LeftHand().getTakeInHand().getName();
            }
            else
            {
                weapon.Text = "无";
            }
        }

        private void hero_search_Click(object sender, EventArgs e)
        {
            BSEO.heroSearchEnemy(BF.getMyHero(),BF.getDistence());
            EndTurn();
        }

        private void attack_aimless_Click(object sender, EventArgs e)
        {
            if (dr.startBet(1, 7))
            {
                if (radioButton1.Checked)
                    HeroAttackAction.AttackEnemy(BF.getMyHero(), BF.getTheMob(), 1);
                else if (radioButton2.Checked)
                    HeroAttackAction.AttackEnemy(BF.getMyHero(), BF.getTheMob(), 2);
                else if (radioButton3.Checked)
                    HeroAttackAction.AttackEnemy(BF.getMyHero(), BF.getTheMob(), 5);
                BF.setHeroLastMove("乱打");
                BSEO.setIsHeroSeeEnemy(true);
                EndTurn();
            }
            else{
                this.BattleMsg.Items.Add("你没打中什么");
                BF.setHeroLastMove("乱打");
                EndTurn();
            }
        }
    }
}
