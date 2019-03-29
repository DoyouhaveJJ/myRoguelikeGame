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
using myRougelikeGame.Help;

namespace myRougelikeGame
{
    public partial class setMyHero : Form
    {   /**设置随机英雄界面
         * 初始化变量
         * tl为翻译，将数值化的属性翻译成字符串
         * darn为自定义随机函数
         * 设置最大随机次数 M=input-1
         * 创建英雄。
         * 
         * 
         * */
        Translate tl = new Translate();
        DIYRandom dran = new DIYRandom();
        int MaxRandomTimes = 4;
        theHero myHero = new theHero();
        public setMyHero()
        {
            InitializeComponent();
        }

        private void setMyHero_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {   //若没有输入名字，则不行
            if (hero_name.Text == "") {
                MessageBox.Show("你的名字是？", "必须要有一个名字", MessageBoxButtons.OK);
                return;
            }
            hero_name.Enabled = false;
            button2.Visible = false;
            randomBtn.Visible = true;
            confirmBtn.Visible = true;
            //确定一次则需要第一次随机生成
            RandomOnce();
            show();
            myHero.SetName(hero_name.Text);
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            //就决定是你了
            this.Tag = myHero;
            theGame tg = new theGame();
            tg.ShowDialog(this);
            this.Close();
        }
        //随机生成
        void RandomOnce() {
            int[] baseNum = GetRandomInt(20, 1, 50); //随机生成的基数
            myHero.setHero_age(baseNum[0]*2);       //随机生成2~100岁
            myHero.setHero_sex(baseNum[1]%2+1);     //性别 只有1和2 1=男 2=女
            myHero.setHero_agility(baseNum[2]);     //敏捷 1~50
            myHero.setHero_bloodtype(baseNum[3]%4+1);//血型 1=A血 2=B血 3=O血 4=AB血
            //稀有血型概率1/1000的概率 5=RH血
            if (dran.startBet(1, 1000)) {
                myHero.setHero_bloodtype(5);
            }
            myHero.setHero_charm(baseNum[4]);       //魅力 1~50
            myHero.setHero_endurance(baseNum[5]);   //耐力 1~50
            myHero.setHero_eq(baseNum[6]);          //情商 1~50
            myHero.setHero_eye(baseNum[7]*10);         //视力 10~500
            myHero.setHero_face(baseNum[8]);        //颜值 1~50
            myHero.setHero_group(baseNum[9]%6+1);   //种族 1=人类，2=兽人，3=恶魔，4=精灵，5=不死族 6=龙人
            //稀有种族概率 1/2000 7=未来人
            if (dran.startBet(1, 2000)) {
                myHero.setHero_group(7);
            }
            //稀有种族概率 1/5000 8=灵魂
            if (dran.startBet(1, 5000)) {
                myHero.setHero_group(8);
            }
            myHero.setHero_hair(baseNum[10] * 100);  //发量 100~5000
            myHero.setHero_height(baseNum[11]%5*10+150);//身高 160~200
            myHero.setHero_iq(baseNum[12]);         //智商 1~50
            myHero.setHero_job(baseNum[13]%10+1);   //职业 1=无职业 2=程序员 3=会计 4=建筑工 5=厨师 6=警察 7=教师 8=科学家 9=语言学家 10=律师
            //稀有职业概率 1/1000 11=军人
            if (dran.startBet(1, 1000))
            {
                myHero.setHero_job(11);
            }
            //稀有职业概率 1/2000 12=格斗家
            if (dran.startBet(1, 1000))
            {
                myHero.setHero_job(12);
            }
            myHero.setHero_lucky(baseNum[14]);          //运气 1~50
            myHero.setHero_money(baseNum[15]*100);      //金钱 100~5000
            myHero.setHero_strength(baseNum[16]);       //力量 1~50
            myHero.setHero_talk(baseNum[17]);           //口才 1~50
            myHero.setHero_weight(baseNum[18]+50);      //体重 51~100
            MaxRandomTimes--;                           
            randomBtn.Text = "还能随机" + MaxRandomTimes + "次";
            if (MaxRandomTimes == 0)
                randomBtn.Enabled = false;
        }


        void show() {
            //打印
            hero_age.Text = myHero.getHero_age().ToString()+"岁";
            hero_agility.Text = myHero.getHero_agility().ToString();
            hero_bloodtype.Text = tl.BloodTypeToString(myHero.getHero_bloodtype());
            hero_charm.Text = myHero.getHero_charm().ToString();
            hero_endurance.Text = myHero.getHero_endurance().ToString();
            hero_eq.Text = myHero.getHero_eq().ToString();
            hero_eye.Text = myHero.getHero_eye().ToString()+"度";
            hero_face.Text = myHero.getHero_face().ToString();
            hero_group.Text = tl.GroupToString(myHero.getHero_group());            
            hero_hair.Text = myHero.getHero_hair().ToString()+"根";
            hero_height.Text = myHero.getHero_height().ToString()+"厘米";
            hero_iq.Text = myHero.getHero_iq().ToString();
            hero_job.Text = tl.JobToString(myHero.getHero_job());
            hero_lucky.Text = myHero.getHero_lucky().ToString();
            hero_money.Text = myHero.getHero_money().ToString()+"元";
            hero_sex.Text = tl.SexToString(myHero.getHero_sex());
            hero_strength.Text = myHero.getHero_strength().ToString();
            hero_talk.Text = myHero.getHero_talk().ToString();
            hero_weight.Text = myHero.getHero_weight().ToString()+"千克";

        }


        // Number随机数个数
        // minNum随机数下限
        // maxNum随机数上限
        public int[] GetRandomInt(int Number, int minNum, int maxNum)
        {   //获取随机数组
            int j,k;
            int[] b = new int[Number];
            Random r = new Random();
            for (j = 0; j < Number; j++)
            {
                int i = r.Next(minNum, maxNum + 1);
                int num = 0;
                for (k = 0; k < j; k++)
                {
                    if (b[k] == i)
                    {
                        num = num + 1;
                    }
                }
                if (num == 0)
                {
                    b[j] = i;
                }
                else
                {
                    j = j - 1;
                }
            }
            
            return b;
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {   
            //随机一次
            RandomOnce();
            show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //帮助按钮
            aboutHeroSetting ahs = new aboutHeroSetting();
            ahs.ShowDialog();
        }
    }
}
