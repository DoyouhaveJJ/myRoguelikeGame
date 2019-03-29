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
        /*  BSEO为敌人与英雄的视野
         *  HeroAttackAction为英雄的攻击动作类
         *  EnemyAttackAction为敌人的攻击动作类
         *  ts为翻译，对双方的状态做 数据->文字 转化
         *  BF为战场类，一些判断就在这里实现
         *  dr为随机数据生成
         *  TODO:实现更多的动作
         *       实现英雄中途脱离战场
         *       实现英雄受到攻击时的一些随机事件：摔倒，流血，晕眩等
         *       实现3D化，每个敌人与英雄之间的距离不是独立的，而是有类似平面图的结构
         *       由于“英雄观察敌人”这个特性，由于代码是之前写的，没有将“一个战场可以有多个敌人”这个思想写进去，于是。。。
         *       英雄观察到一个敌人就判断为观察到所有敌人了，之后再改
         * 
         * 
         * 
         * 
         * 
         * */
        BattleSeeEachOther BSEO = new BattleSeeEachOther();
        HeroAttack HeroAttackAction = new HeroAttack();
        EnemyAttack EnemyAttackAction = new EnemyAttack();
        Translate ts = new Translate();
        BattleField BF;
        DIYRandom dr = new DIYRandom();
        private int index = 0;
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
            BF = (BattleField)this.Tag;
            BF.setBseo(BSEO);
            BF.getBseo().init();
            //将消息输出框给各个Action
            EnemyAttackAction.setMessageBox(this.BattleMsg);
            HeroAttackAction.setMessageBox(this.BattleMsg);
            BF.initAI(EnemyAttackAction);
            heroName.Text = BF.getMyHero().GetName();
            BF.initDistence();
                updata(index);
        }
        public void EndTurn()
        {
            //回合结束AI进行判断一次
            BF.JudgeOnce();
            updata(index);
        }
        public void updata(int index){
            //可视化数据更新，按钮判断更新 index为当前英雄作战的敌人索引
            if (BF.getMyHero().getStandBlock().getMob_Count() == 1)
            {
                before.Visible = false;
                after.Visible = false;
            }
            else if (BF.getMyHero().getStandBlock().getMob_Count() > 1)
            {
                if (index == 0)
                {
                    before.Visible = false;
                    after.Visible = true;

                }
                else if (index > 0 && index+1 < BF.getMyHero().getStandBlock().getMob_Count())
                {

                    before.Visible = true;
                    after.Visible = true;
                }
                else if (index+1 == BF.getMyHero().getStandBlock().getMob_Count()) {
                    before.Visible = true;
                    after.Visible = false;
                }

            }
            //敌人全部死亡，显示胜利按钮
            WinBtn.Visible = BF.isAllDead();
            if (BSEO.getIsEnemySeeHero())
                enemyVisable.Text = "是";
            else
                enemyVisable.Text = "否";
            if (BSEO.getIsHeroSeeEnemy())
            {
                heroVisable.Text = "是";
                hero_search.Visible = false;
                enemyName.Text = ((defaultMob)(BF.getTheMobList()[index])).getMob_Name();
                enemyLevel.Text = ((defaultMob)(BF.getTheMobList()[index])).getMob_Level() + "";
            }
            else
            {
                heroVisable.Text = "否";
                hero_search.Visible = true;
                enemyName.Text = "???";
                enemyLevel.Text = "???";
            }
            Distence.Text = (int)BF.getDistence()[index] + "";
            enemyLastAction.Text = BF.getEnemyLastMove();
            heroLastAction.Text = BF.getHeroLastMove();
            enemyStatus.Text = ts.MobStatusToString(((defaultMob)BF.getTheMobList()[index]).getMob_Status());
            if ((int)BF.getDistence()[index] > 3)
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
            BF.heroFallBack(index);
            EndTurn();
        }
        private void moveTowardBtn_Click(object sender, EventArgs e)
        {
            BF.heroMoveToward(index);
            EndTurn();
        }
        private void chargeBtn_Click(object sender, EventArgs e)
        {
            BF.heroCharge(index);
            EndTurn();
        }

        private void escapeBtn_Click(object sender, EventArgs e)
        {
            BF.heroEscape(index);
            EndTurn();
        }
        //这里是英雄攻击，根据选择的手的类别选择攻击方式，目前只有物理攻击，哎，又是一堆if if if if
        private void attackBtn_Click(object sender, EventArgs e)
        {
            if(((defaultMob)BF.getTheMobList()[index]).getMob_Status()==-1){
               BattleMsg.Items.Add("你打了打"+((defaultMob)BF.getTheMobList()[index]).getMob_Name()+"的尸体,并没有什么卵用");
               BF.setHeroLastMove("攻击");
               EndTurn();
               return;
            }
            if(radioButton1.Checked)
                HeroAttackAction.AttackEnemy(BF.getMyHero(), ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[index]), 1);
            else if(radioButton2.Checked)
                HeroAttackAction.AttackEnemy(BF.getMyHero(), ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[index]), 2);
            else if(radioButton3.Checked)
                HeroAttackAction.AttackEnemy(BF.getMyHero(), ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[index]), 5);
            BF.setHeroLastMove("攻击");
            EndTurn();
        }

        private void waitBtn_Click(object sender, EventArgs e)
        {
            //英雄休息一回合，恢复50%的精力
            BF.heroWait();
            EndTurn();
        }
        //胜利，从第一次就死亡的敌人中获取经验值 和敌人等级有关
        //TODO 不同的敌人有不同的经验值
        private void WinBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BF.getMyHero().getStandBlock().getMob_Count(); i++)
            {
                if (((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[i]).getIsFirstDead())
                {
                    MessageBox.Show("你打赢了" + ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[i]).getMob_Name() + "获得" + ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[i]).getMob_Level() * 100 + "经验值");
                    BF.getMyHero().gainExp(((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[i]).getMob_Level() * 100);
                    ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[i]).setIsFirstDead(false);
                }
            }
            BF.clearBattle();
            this.Close();
        }

        private void heroStatus_Click(object sender, EventArgs e)
        {

        }

        public void checkedWeapon(){
            
        
        }
        //下面是无聊的切换手的实现
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
            BF.getBseo().heroSearchEnemy(BF.getMyHero(),(int)BF.getDistence()[index]);
            BF.setHeroLastMove("寻找");
            EndTurn();
        }
        //当英雄没看到敌人时，就要乱打
        private void attack_aimless_Click(object sender, EventArgs e)
        {
            if (dr.startBet(1, 7))
            {
                if (radioButton1.Checked)
                    HeroAttackAction.AttackEnemy(BF.getMyHero(), ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[index]), 1);
                else if (radioButton2.Checked)
                    HeroAttackAction.AttackEnemy(BF.getMyHero(), ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[index]), 2);
                else if (radioButton3.Checked)
                    HeroAttackAction.AttackEnemy(BF.getMyHero(), ((defaultMob)BF.getMyHero().getStandBlock().getMob_list()[index]), 5);
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
        //切换敌人
        private void before_Click(object sender, EventArgs e)
        {
            index--;
            updata(index);
        }

        private void after_Click(object sender, EventArgs e)
        {
            index++;
            updata(index);
        }
    }
}
