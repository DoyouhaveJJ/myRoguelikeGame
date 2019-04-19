using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;
using myRougelikeGame.Function;
using myRougelikeGame.Player.Body;
using myRougelikeGame.Map;
using myRougelikeGame.Action;
namespace myRougelikeGame.Player
{
    class theHero : man
    {
        private System.Windows.Forms.ListBox MessageBox;
        private HeroLevelUp HLU = new HeroLevelUp();
        private defaultBlock standBlock;


        private Chest hero_Chest = new Chest();
        private Head hero_Head = new Head();
        private LeftArm hero_LeftArm = new LeftArm();
        private LeftFoot hero_LeftFoot = new LeftFoot();
        private LeftLeg hero_LeftLeg = new LeftLeg();
        private LeftHand hero_LeftHand = new LeftHand();
        private Neck hero_Neck = new Neck();
        private RightArm hero_RightArm = new RightArm();
        private RightFoot hero_RightFoot = new RightFoot();
        private RightHand hero_RightHand = new RightHand();
        private RightLeg hero_RightLeg = new RightLeg();
        private Web hero_Web = new Web();

        private DIYRandom dr = new DIYRandom();


        private string hero_name;
        private int hero_sex;       //性别
        private int hero_height;    //身高
        private int hero_weight;    //体重
        private int hero_strength;  //力量
        private int hero_iq;        //智商
        private int hero_lucky;     //运气
        private int hero_agility;   //敏捷
        private int hero_group;     //种族
        private int hero_job;       //职业
        private int hero_charm;     //魅力
        private int hero_age;       //年龄
        private int hero_bloodtype; //血型
        private int hero_face;      //颜值
        private int hero_eq;        //情商
        private int hero_talk;      //说话
        private int hero_endurance; //耐力
        private int hero_eye;       //视力
        private int hero_hair;      //头发数量
        private int hero_money;     //金钱

        private int Hungry;         //饥饿度
        private int maxHungry;
        private int Thirsty;        //口渴度
        private int maxThirsty;
        private int Immunity;       //免疫力
        private int maxImmunity;
        private int Blood;          //血量值
        private int maxBlood;
        private int Pain;           //舒适度
        private int maxPain;
        private int Pee;            //尿液
        private int maxPee;
        private int Shit;           //屎量
        private int maxShit;
        private double minTemperature;
        private double Temperature; //体温
        private double maxTemperture;
        private double Burden;      //负重
        private double maxBurden;   
        private int Energy;         //精力
        private int maxEnergy;
        private int hero_Status;    //状况

        private int EnergyConsumeByAttack;
        private int EnergyConsumeByMove;
        private int EnergyConsumeByMagic;
        private int EnergyConsumeByCraft;
        private int EnergyConsumeByLoot;
        private int HungryIncreaseByTurn;
        private int ThristyIncreaseByTurn;
        private int PeeIncreaseIndex;
        private int ShitIncreaseIndex;





        private Bag theHeroBag = new Bag();

        public Bag getHeroBag() {
            return theHeroBag;
        }


        public bool addOneItem(defaultItem item){
            theHeroBag.addOneItem(item);
            return true;
        }

        public void destoryOneItem(defaultItem item) {
            theHeroBag.getItemArray().Remove(item);
        }

        private int loc_x;
        private int loc_y;
        public void SetName(string name) {
            this.hero_name = name;
        }
        public string GetName() {
            return this.hero_name;
        }




        public void move_N() {
            if (isOutOfEnergy(4)) return;
            if (this.loc_y == 399) return;
            this.loc_y++;
            moveCauseDecreaseEnergy();
            theHeroBag.causeEnduranceDecrease();
            
        }
        public void move_E() {
            if (isOutOfEnergy(4)) return;
            if (this.loc_x == 399) return;
            this.loc_x++;
            moveCauseDecreaseEnergy();
            theHeroBag.causeEnduranceDecrease();
        }
        public void move_W() {
            if (isOutOfEnergy(4)) return;
            if (this.loc_x == 0) return;
            this.loc_x--;
            moveCauseDecreaseEnergy();
            theHeroBag.causeEnduranceDecrease();
        }
        public void move_S() {
            if (isOutOfEnergy(4)) return;
            if (this.loc_y == 0) return;
            this.loc_y--;
            moveCauseDecreaseEnergy();
            theHeroBag.causeEnduranceDecrease();
        }

        public int getEnergyConsumeByAttack()
        {
            return EnergyConsumeByAttack;
        }
        public void setEnergyConsumeByAttack(int energyConsumeByAttack)
        {
            EnergyConsumeByAttack = energyConsumeByAttack;
        }
        public int getEnergyConsumeByMove()
        {
            return EnergyConsumeByMove;
        }
        public void setEnergyConsumeByMove(int energyConsumeByMove)
        {
            EnergyConsumeByMove = energyConsumeByMove;
        }
        public int getEnergyConsumeByMagic()
        {
            return EnergyConsumeByMagic;
        }
        public void setEnergyConsumeByMagic(int energyConsumeByMagic)
        {
            EnergyConsumeByMagic = energyConsumeByMagic;
        }
        public int getEnergyConsumeByCraft()
        {
            return EnergyConsumeByCraft;
        }
        public void setEnergyConsumeByCraft(int energyConsumeByCraft)
        {
            EnergyConsumeByCraft = energyConsumeByCraft;
        }
        public int getHungryIncreaseByTurn()
        {
            return HungryIncreaseByTurn;
        }
        public void setHungryIncreaseByTurn(int hungryIncreaseByTurn)
        {
            HungryIncreaseByTurn = hungryIncreaseByTurn;
        }
        public int getThristyIncreaseByTurn()
        {
            return ThristyIncreaseByTurn;
        }
        public void setThristyIncreaseByTurn(int thristyIncreaseByTurn)
        {
            ThristyIncreaseByTurn = thristyIncreaseByTurn;
        }
        public int getPeeIncreaseIndex()
        {
            return PeeIncreaseIndex;
        }
        public void setPeeIncreaseIndex(int peeIncreaseIndex)
        {
            PeeIncreaseIndex = peeIncreaseIndex;
        }
        public int getShitIncreaseIndex()
        {
            return ShitIncreaseIndex;
        }
        public void setShitIncreaseIndex(int shitIncreaseIndex)
        {
            ShitIncreaseIndex = shitIncreaseIndex;
        }
        public int getLoc_x()
        {
            return loc_x;
        }
        public void setLoc_x(int loc_x)
        {
            this.loc_x = loc_x;
        }
        public int getLoc_y()
        {
            return loc_y;
        }
        public void setLoc_y(int loc_y)
        {
            this.loc_y = loc_y;
        }
        public int getHero_sex()
        {
            return hero_sex;
        }
        public void setHero_sex(int hero_sex)
        {
            this.hero_sex = hero_sex;
        }
        public int getHero_height()
        {
            return hero_height;
        }
        public void setHero_height(int hero_height)
        {
            this.hero_height = hero_height;
        }
        public int getHero_weight()
        {
            return hero_weight;
        }
        public void setHero_weight(int hero_weight)
        {
            this.hero_weight = hero_weight;
        }
        public int getHero_strength()
        {
            return hero_strength;
        }
        public void setHero_strength(int hero_strength)
        {
            this.hero_strength = hero_strength;
        }
        public int getHero_iq()
        {
            return hero_iq;
        }
        public void setHero_iq(int hero_iq)
        {
            this.hero_iq = hero_iq;
        }
        public int getHero_lucky()
        {
            return hero_lucky;
        }
        public void setHero_lucky(int hero_lucky)
        {
            this.hero_lucky = hero_lucky;
        }
        public int getHero_agility()
        {
            return hero_agility;
        }
        public void setHero_agility(int hero_agility)
        {
            this.hero_agility = hero_agility;
        }
        public int getHero_group()
        {
            return hero_group;
        }
        public void setHero_group(int hero_group)
        {
            this.hero_group = hero_group;
        }
        public int getHero_job()
        {
            return hero_job;
        }
        public void setHero_job(int hero_job)
        {
            this.hero_job = hero_job;
        }
        public int getHero_charm()
        {
            return hero_charm;
        }
        public void setHero_charm(int hero_charm)
        {
            this.hero_charm = hero_charm;
        }
        public int getHero_age()
        {
            return hero_age;
        }
        public void setHero_age(int hero_age)
        {
            this.hero_age = hero_age;
        }
        public int getHero_bloodtype()
        {
            return hero_bloodtype;
        }
        public void setHero_bloodtype(int hero_bloodtype)
        {
            this.hero_bloodtype = hero_bloodtype;
        }
        public int getHero_face()
        {
            return hero_face;
        }
        public void setHero_face(int hero_face)
        {
            this.hero_face = hero_face;
        }
        public int getHero_eq()
        {
            return hero_eq;
        }
        public void setHero_eq(int hero_eq)
        {
            this.hero_eq = hero_eq;
        }
        public int getHero_talk()
        {
            return hero_talk;
        }
        public void setHero_talk(int hero_talk)
        {
            this.hero_talk = hero_talk;
        }
        public int getHero_endurance()
        {
            return hero_endurance;
        }
        public void setHero_endurance(int hero_endurance)
        {
            this.hero_endurance = hero_endurance;
        }
        public int getHero_eye()
        {
            return hero_eye;
        }
        public void setHero_eye(int hero_eye)
        {
            this.hero_eye = hero_eye;
        }
        public int getHero_hair()
        {
            return hero_hair;
        }
        public void setHero_hair(int hero_hair)
        {
            this.hero_hair = hero_hair;
        }
        public int getHero_money()
        {
            return hero_money;
        }
        public void setHero_money(int hero_money)
        {
            this.hero_money = hero_money;
        }
        public int getHungry()
        {
            return Hungry;
        }
        public void setHungry(int hungry)
        {
            Hungry = hungry;
        }
        public int getMaxHungry()
        {
            return maxHungry;
        }
        public void setMaxHungry(int maxHungry)
        {
            this.maxHungry = maxHungry;
        }
        public int getThirsty()
        {
            return Thirsty;
        }
        public void setThirsty(int thirsty)
        {
            Thirsty = thirsty;
        }
        public int getMaxThirsty()
        {
            return maxThirsty;
        }
        public void setMaxThirsty(int maxThirsty)
        {
            this.maxThirsty = maxThirsty;
        }
        public int getImmunity()
        {
            return Immunity;
        }
        public void setImmunity(int immunity)
        {
            Immunity = immunity;
        }
        public int getMaxImmunity()
        {
            return maxImmunity;
        }
        public void setMaxImmunity(int maxImmunity)
        {
            this.maxImmunity = maxImmunity;
        }
        public int getBlood()
        {
            return Blood;
        }
        public void setBlood(int blood)
        {
            Blood = blood;
        }
        public int getMaxBlood()
        {
            return maxBlood;
        }
        public void setMaxBlood(int maxBlood)
        {
            this.maxBlood = maxBlood;
        }
        public int getPain()
        {
            return Pain;
        }
        public void setPain(int pain)
        {
            Pain = pain;
        }
        public int getMaxPain()
        {
            return maxPain;
        }
        public void setMaxPain(int maxPain)
        {
            this.maxPain = maxPain;
        }
        public int getPee()
        {
            return Pee;
        }
        public void setPee(int pee)
        {
            Pee = pee;
        }
        public int getMaxPee()
        {
            return maxPee;
        }
        public void setMaxPee(int maxPee)
        {
            this.maxPee = maxPee;
        }
        public int getShit()
        {
            return Shit;
        }
        public void setShit(int shit)
        {
            Shit = shit;
        }
        public int getMaxShit()
        {
            return maxShit;
        }
        public void setMaxShit(int maxShit)
        {
            this.maxShit = maxShit;
        }
        public double getTemperature()
        {
            return Temperature;
        }
        public void setTemperature(double temperature)
        {
            Temperature = temperature;
        }       
        public void setBurden(double burden)
        {
            Burden = burden;
        }
        public int getEnergy()
        {
            return Energy;
        }
        public void setEnergy(int energy)
        {
            Energy = energy;
        }
        public int getMaxEnergy()
        {
            return maxEnergy;
        }
        public void setMaxEnergy(int maxEnergy)
        {
            this.maxEnergy = maxEnergy;
        }
        public double getMinTemperature()
        {
            return minTemperature;
        }
        public void setMinTemperature(double minTemperature)
        {
            this.minTemperature = minTemperature;
        }
        public double getMaxTemperture()
        {
            return maxTemperture;
        }
        public void setMaxTemperture(double maxTemperture)
        {
            this.maxTemperture = maxTemperture;
        }
        public double getBurden()
        {
            return Burden;
        }
        
        public double getMaxBurden()
        {
            return maxBurden;
        }
        public void setMaxBurden(double maxBurden)
        {
            this.maxBurden = maxBurden;
        }

        public Chest getHero_Chest()
        {
            return hero_Chest;
        }
        public void setHero_Chest(Chest hero_Chest)
        {
            this.hero_Chest = hero_Chest;
        }
        public Head getHero_Head()
        {
            return hero_Head;
        }
        public void setHero_Head(Head hero_Head)
        {
            this.hero_Head = hero_Head;
        }
        public LeftArm getHero_LeftArm()
        {
            return hero_LeftArm;
        }
        public void setHero_LeftArm(LeftArm hero_LeftArm)
        {
            this.hero_LeftArm = hero_LeftArm;
        }
        public LeftFoot getHero_LeftFoot()
        {
            return hero_LeftFoot;
        }
        public void setHero_LeftFoot(LeftFoot hero_LeftFoot)
        {
            this.hero_LeftFoot = hero_LeftFoot;
        }
        public LeftLeg getHero_LeftLeg()
        {
            return hero_LeftLeg;
        }
        public void setHero_LeftLeg(LeftLeg hero_LeftLeg)
        {
            this.hero_LeftLeg = hero_LeftLeg;
        }
        public LeftHand getHero_LeftHand()
        {
            return hero_LeftHand;
        }
        public void setHero_LeftHand(LeftHand hero_LeftHand)
        {
            this.hero_LeftHand = hero_LeftHand;
        }
        public Neck getHero_Neck()
        {
            return hero_Neck;
        }
        public void setHero_Neck(Neck hero_Neck)
        {
            this.hero_Neck = hero_Neck;
        }
        public RightArm getHero_RightArm()
        {
            return hero_RightArm;
        }
        public void setHero_RightArm(RightArm hero_RightArm)
        {
            this.hero_RightArm = hero_RightArm;
        }
        public RightFoot getHero_RightFoot()
        {
            return hero_RightFoot;
        }
        public void setHero_RightFoot(RightFoot hero_RightFoot)
        {
            this.hero_RightFoot = hero_RightFoot;
        }
        public RightHand getHero_RightHand()
        {
            return hero_RightHand;
        }
        public void setHero_RightHand(RightHand hero_RightHand)
        {
            this.hero_RightHand = hero_RightHand;
        }
        public RightLeg getHero_RightLeg()
        {
            return hero_RightLeg;
        }
        public void setHero_RightLeg(RightLeg hero_RightLeg)
        {
            this.hero_RightLeg = hero_RightLeg;
        }
        public Web getHero_Web()
        {
            return hero_Web;
        }
        public void setHero_Web(Web hero_Web)
        {
            this.hero_Web = hero_Web;
        }
        public System.Windows.Forms.ListBox getMessageBox()
        {
            return MessageBox;
        }

        public void setMessageBox(System.Windows.Forms.ListBox messageBox)
        {
            MessageBox = messageBox;
        }


        public defaultBlock getStandBlock()
        {
            return standBlock;
        }

        public void setStandBlock(defaultBlock standBlock)
        {
            this.standBlock = standBlock;
        }
        public int getHero_Status()
        {
            return hero_Status;
        }

        public void setHero_Status(int hero_Status)
        {
            this.hero_Status = hero_Status;
        }

        public int getEnergyConsumeByLoot()
        {
            return EnergyConsumeByLoot;
        }

        public void setEnergyConsumeByLoot(int energyConsumeByLoot)
        {
            EnergyConsumeByLoot = energyConsumeByLoot;
        }











        public theHero() {
            init();
            this.getHero_LeftHand().setIsEquipedSomething(false);
            this.getHero_RightHand().setIsEquipedSomething(false);
        }
        public bool isLevelUp()
        {
            return getExp() >= getMaxExp();
        }
        public void getDamage(int damage)
        {
            if (getHp() - damage <= 0)
            {
                setHp(0);
            }
            else
            {
                setHp(getHp() - damage);
            }
            if (isDead())
            {
                theGameOver over = new theGameOver();
                over.Tag = this;
                over.ShowDialog();
            }
        }

        public bool isDead()
        {
            return getHp() <= 0;
        }
        public void LevelUp() {
            if (isLevelUp())
            {

                setExp(0);
                int nextExp = (int)(getMaxExp() + getLevel() * 100 + 555 - hero_iq * 0.5 - hero_eq * 0.75 - hero_age * 0.25);//下一等级计算公式
                setMaxExp(nextExp);
                setLevel(getLevel()+1);
                HLU.LevelUp(this,getMessageBox());
                
            }
            else
                return;
        }
        public void gainExp(int expIncome) {
            setExp(getExp() + expIncome);
            LevelUp();
        }

        public void setTheHeroMaxValue(bool isFrist) {
            
            this.maxBlood = 200+(int)(this.hero_endurance*0.5);
            if (isFrist)
            {
                if (this.hero_sex == 2) this.maxBlood += 20;//girl + 20 blood
                if (this.hero_group == 2) this.maxBlood += 50;
                //if (this.hero_group == 5 || this.hero_group == 8) this.maxBlood = 0;
            }
            if (this.hero_group == 5 || this.hero_group == 8) this.maxBlood = 0;
            this.maxHungry = 100 + (int)(150 / this.hero_age) + (int)(this.hero_endurance * 0.7) - (int)(this.hero_weight * 0.2);

            this.maxThirsty = 100 + (int)(100 / this.hero_age) + (int)(this.hero_endurance * 0.5) - (int)(this.hero_weight * 0.1);

            this.maxImmunity = 100 - (int)(this.hero_age*0.5)+(int)(this.hero_endurance*0.2);
            if (isFrist)
            {
                if (this.hero_group == 3) this.maxImmunity += 50;
                if (this.hero_group == 4 || this.hero_group == 7) this.maxImmunity -= 10;
               
            }
            if (this.hero_group == 8) this.maxImmunity = 0;
            this.maxPain = 100 + (int)(this.hero_endurance * 0.3);
            if (isFrist)
            {
                if (this.hero_group == 4) this.maxPain -= 5;
                if (this.hero_group == 5 || this.hero_group == 8) this.maxPain += 30;
            }
            this.maxPee = 100 + (int)(this.hero_age*0.3)+(int)(this.hero_endurance*0.22);
            
                if (this.hero_group == 8) this.maxPee = 0;
            
            this.maxShit = 100 + (int)(this.hero_age * 0.5) + (int)(this.hero_endurance * 0.44);
            
                if (this.hero_group == 8) this.maxShit = 0;
            
            this.maxBurden = 30 + this.hero_strength * 0.35 - this.hero_age * 0.2;
            if (isFrist)
            {
                if (this.hero_sex == 2) this.maxBurden -= 10;
                if (this.hero_group == 2) this.maxBurden += 5;
                if (this.hero_group == 4) this.maxBurden -= 5;
            }
            if (isFrist)
            {
                switch (this.hero_group)
                {
                    case 1: { this.maxTemperture = 40; this.Temperature = 37; this.minTemperature = 35; break; }
                    case 2: { this.maxTemperture = 42; this.Temperature = 38; this.minTemperature = 33; break; }
                    case 3: { this.maxTemperture = 1000; this.Temperature = 500; this.minTemperature = 50; break; }
                    case 4: { this.maxTemperture = 40; this.Temperature = 37; this.minTemperature = 35; break; }
                    case 5: { this.maxTemperture = 0; this.Temperature = 0; this.minTemperature = 0; break; }
                    case 6: { this.maxTemperture = 40; this.Temperature = 37; this.minTemperature = 35; break; }
                    case 7: { this.maxTemperture = 40; this.Temperature = 37; this.minTemperature = 35; break; }
                    case 8: { this.maxTemperture = 10000; this.Temperature = 5000; this.minTemperature = 2000; break; }
                }
            }
            this.maxEnergy = 50 + (int)(this.hero_endurance * 0.9)-(int)(this.hero_age*0.3);

        }



        public void rebuildTheHero() {
            this.Hungry = 0;
            this.Thirsty = 0;
            this.Pee = 0;
            this.Shit = 0;
            this.Blood = this.maxBlood;
            this.Burden = 0;
            this.Energy = this.maxEnergy;
            this.Immunity = this.maxImmunity;
            this.Pain = 0;
        }



        public void buildConsumeIndex() { //消耗量
            setEnergyConsumeByAttack(5);//攻击能量消耗量
            setEnergyConsumeByCraft(10);//合成能量消耗量
            setEnergyConsumeByMagic(10);//魔法能量消耗量
            setEnergyConsumeByMove(4);//移动能量消耗量
            setHungryIncreaseByTurn(2);//每回合增加的饥饿度
            setEnergyConsumeByLoot(15);//搜刮消耗量
            setThristyIncreaseByTurn(3);//每回合口渴增加量
            setPeeIncreaseIndex(0);//每次增加的尿
            setShitIncreaseIndex(0);//每次增加的屎
        }


        public void heroRest() {
            getMessageBox().Items.Add("你休息了一下，感觉精力充沛！");
           // System.Console.WriteLine("你休息了一下，感觉精力充沛！");
            setEnergy(getMaxEnergy());
            heroIncreaseHungry();
            heroIncreasePee();
            heroIncreaseShit();
            heroIncreaseThristy();
        }

        public void heroIncreaseHungry() {//增加饥饿
            if (getHungry() + getHungryIncreaseByTurn() >= getMaxHungry()) {
                setHungry(getMaxHungry());
                return;
            }
            setHungry(getHungry() + getHungryIncreaseByTurn());
            return;
        }

        public void heroIncreaseThristy() {//增加口渴
            if (getThirsty() + getThristyIncreaseByTurn() >= getMaxThirsty()) {
                setThirsty(getMaxThirsty());
                return;
            }
            setThirsty(getThirsty() + getThristyIncreaseByTurn());
            return;
        }

        public void heroIncreasePee() {//增加尿量
            if (getPee() + getPeeIncreaseIndex() >= getMaxPee()) {
                setPee(getMaxPee());
                return;
            }
            setPee(getPee() + getPeeIncreaseIndex());
            if (getPeeIncreaseIndex() <= 0) {
                setPeeIncreaseIndex(0);
                return;
            }
            setPeeIncreaseIndex((int)getPeeIncreaseIndex() / dr.getRandomNum(1, 3));
            return;
        }

        public void heroIncreaseShit() {//增加屎量
            if (getShit() + getShitIncreaseIndex() >= getMaxShit())
            {
                setShit(getMaxShit());
                return;
            }
            setShit(getShit() + getShitIncreaseIndex());
            if (getShitIncreaseIndex() <= 0)
            {
                setShitIncreaseIndex(0);
                return;
            }
            setShitIncreaseIndex((int)getShitIncreaseIndex() / dr.getRandomNum(1, 4));
            return;
        }
        public void moveCauseDecreaseEnergy(){//移动造成精力消耗
            if (getEnergy() - getEnergyConsumeByMove() <= 0)
            {
                setEnergy(0);
                return;
            }
            else {
                setEnergy(getEnergy() - getEnergyConsumeByMove());
                return;
            }
        }

        public void lootCauseDecreaseEnergy() {//搜刮造成精力消耗
            if (getEnergy() - getEnergyConsumeByLoot() <= 0)
            {
                setEnergy(0);
                return;
            }
            else
            {
                setEnergy(getEnergy() - getEnergyConsumeByLoot());
                return;
            }   
        }

        public void attackCauseDecreaseEnergy()//攻击造成精力消耗
        {
            if (getEnergy() - getEnergyConsumeByAttack() <= 0)
            {
                setEnergy(0);
                return;
            }
            else
            {
                setEnergy(getEnergy() - getEnergyConsumeByAttack());
                return;
            }
        }

        public void magicCauseDecreaseEnergy()//魔法造成精力消耗
        {
            if (getEnergy() - getEnergyConsumeByMagic() <= 0)
            {
                setEnergy(0);
                return;
            }
            else
            {
                setEnergy(getEnergy() - getEnergyConsumeByMagic());
                return;
            }
        }
        public void craftCauseDecreaseEnergy()//合成造成精力消耗
        {
            if (getEnergy() - getEnergyConsumeByCraft() <= 0)
            {
                setEnergy(0);
                return;
            }
            else
            {
                setEnergy(getEnergy() - getEnergyConsumeByCraft());
                return;
            }
        }

        public bool isOutOfEnergy(int a) {
            switch (a)
            {
                case 1:
                    {
                        if (getEnergy() - getEnergyConsumeByAttack() <= 0)
                        {
                            getMessageBox().Items.Add("没有多余的精力来攻击了！");
                            //System.Console.WriteLine("没有多余的精力来攻击了！");
                            return true;
                        }
                        return false;
                    }
                case 2:
                    {
                        if (getEnergy() - getEnergyConsumeByCraft() <= 0)
                        {
                            getMessageBox().Items.Add("没有多余的精力来合成了！");
                            //System.Console.WriteLine("没有多余的精力来合成了！");
                            return true;
                        }
                        return false;

                    }
                case 3:
                    {
                        if (getEnergy() - getEnergyConsumeByMagic() <= 0)
                        {
                            getMessageBox().Items.Add("没有多余的精力来施展魔法了！");
                            //System.Console.WriteLine("没有多余的精力来施展魔法了！");
                            return true;
                        }
                        return false;
                    }
                case 4:
                    {
                        if (getEnergy() - getEnergyConsumeByMove() <= 0)
                        {
                            getMessageBox().Items.Add("没有多余的精力来移动了！");
                           // System.Console.WriteLine("没有多余的精力来移动了！");
                            return true;
                        }
                        return false;
                    }
                case 5: {
                    if (getEnergy() - getEnergyConsumeByLoot() <= 0)
                    {
                        getMessageBox().Items.Add("没有多余的精力来搜刮了！");
                        // System.Console.WriteLine("没有多余的精力来移动了！");
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        public void initBodyIndex() {
            //头
            getHero_Chest().setInjuredLevel(1);
            getHero_Chest().setIsEquipedBackpack(false);
            getHero_Chest().setIsEquipedCloth(false);
            getHero_Chest().setIsEquipedSign(false);
            getHero_Chest().setTakenBackpack(null);
            getHero_Chest().setTakenCloth(null);
            getHero_Chest().setTakenSign(null);
            getHero_Chest().setEndurance(this.getHero_Chest().getMaxEndurance());
            //胸
            getHero_Head().setInjuredLevel(1);
            getHero_Head().setIsEquipedHat(false);
            getHero_Head().setIsEquipedGlass(false);
            getHero_Head().setIsEquipedMask(false);
            getHero_Head().setIsEquipedEarplug(false);
            getHero_Head().setTakenEarplug(null);
            getHero_Head().setTakenHat(null);
            getHero_Head().setTakenGlass(null);
            getHero_Head().setTakenMask(null);
            getHero_Head().setEndurance(this.getHero_Head().getMaxEndurance());
            //左臂
            getHero_LeftArm().setInjuredLevel(1);
            getHero_LeftArm().setIsEquipedSign(false);
            getHero_LeftArm().setTakenSign(null);
            getHero_LeftArm().setEndurance(this.getHero_LeftArm().getMaxEndurance());
            //左脚
            getHero_LeftFoot().setInjuredLevel(1);
            getHero_LeftFoot().setIsEquipedStock(false);
            getHero_LeftFoot().setIsEquipedShoes(false);
            getHero_LeftFoot().setTakenStock(null);
            getHero_LeftFoot().setTakenShoes(null);
            getHero_LeftFoot().setEndurance(this.getHero_LeftFoot().getMaxEndurance());
            //左手
            getHero_LeftHand().setInjuredLevel(1);
            getHero_LeftHand().setIsEquipedSomething(false);
            getHero_LeftHand().setIsEquipedGlove(false);
            getHero_LeftHand().setIsEquipedRing(false);
            getHero_LeftHand().setTakeInHand(null);
            getHero_LeftHand().setTakenRing(null);
            getHero_LeftHand().setTakenGlove(null);
            getHero_LeftHand().setEndurance(this.getHero_LeftHand().getMaxEndurance());
            //左脚
            getHero_LeftLeg().setInjuredLevel(1);
            getHero_LeftLeg().setIsEquipedPants(false);
            getHero_LeftLeg().setTakenPants(null);
            getHero_LeftLeg().setEndurance(this.getHero_LeftLeg().getMaxEndurance());
            //脖子
            getHero_Neck().setInjuredLevel(1);
            getHero_Neck().setIsEquipedNecklace(false);
            getHero_Neck().setTakenNecklace(null);
            getHero_Neck().setEndurance(this.getHero_Neck().getMaxEndurance());
            //右臂
            getHero_RightArm().setInjuredLevel(1);
            getHero_RightArm().setIsEquipedSign(false);
            getHero_RightArm().setTakenSign(null);
            getHero_RightArm().setEndurance(this.getHero_RightArm().getMaxEndurance());
            //右脚
            getHero_RightFoot().setInjuredLevel(1);
            getHero_RightFoot().setIsEquipedStock(false);
            getHero_RightFoot().setIsEquipedShoes(false);
            getHero_RightFoot().setTakenStock(null);
            getHero_RightFoot().setTakenShoes(null);
            getHero_RightFoot().setEndurance(this.getHero_RightFoot().getMaxEndurance());
            //右手
            getHero_RightHand().setInjuredLevel(1);
            getHero_RightHand().setIsEquipedSomething(false);
            getHero_RightHand().setIsEquipedGlove(false);
            getHero_RightHand().setIsEquipedRing(false);
            getHero_RightHand().setTakeInHand(null);
            getHero_RightHand().setTakenRing(null);
            getHero_RightHand().setTakenGlove(null);
            getHero_RightHand().setEndurance(this.getHero_RightHand().getMaxEndurance());
            //右脚
            getHero_RightLeg().setInjuredLevel(1);
            getHero_RightLeg().setIsEquipedPants(false);
            getHero_RightLeg().setTakenPants(null);
            getHero_RightLeg().setEndurance(this.getHero_RightLeg().getMaxEndurance());
            //腹部
            getHero_Web().setInjuredLevel(1);
            getHero_Web().setIsEquipPocked(false);
            getHero_Web().setIsEquipBelt(false);
            getHero_Web().setTakenPocked(null);
            getHero_Web().setTakenBelt(null);
            getHero_Web().setEndurance(this.getHero_Web().getMaxEndurance());
        }


        public void buildBodyIndex(){
            //胸
            getHero_Chest().setMaxEndurance((150+(int)(getHero_endurance()*0.5)));
            getHero_Chest().setDefense(10 + (int)(getHero_strength() * 0.6));
            getHero_Chest().setMagicDefense((int)(getHero_eq() * 0.5));
            getHero_Chest().setMaxInjuredLevel(10);
            //头
            getHero_Head().setMaxEndurance((100 + (int)(getHero_endurance() * 0.4)));
            getHero_Head().setDefense(2 + (int)(getHero_strength() * 0.7));
            getHero_Head().setMagicDefense((int)(getHero_eq() * 0.9));
            getHero_Head().setMaxInjuredLevel(5);
            //左臂
            getHero_LeftArm().setMaxEndurance((120 + (int)(getHero_endurance() * 0.6)));
            getHero_LeftArm().setDefense(5 + (int)(getHero_strength() * 0.7));
            getHero_LeftArm().setMagicDefense((int)(getHero_eq() * 0.5));
            getHero_LeftArm().setMaxInjuredLevel(7);
            //左脚
            getHero_LeftFoot().setMaxEndurance((140 + (int)(getHero_endurance() * 0.6)));
            getHero_LeftFoot().setDefense(5 + (int)(getHero_strength() * 0.8));
            getHero_LeftFoot().setMagicDefense((int)(getHero_eq() * 0.3));
            getHero_LeftFoot().setMaxInjuredLevel(6);
            //左手
            getHero_LeftHand().setMaxEndurance((90 + (int)(getHero_endurance() * 0.7)));
            getHero_LeftHand().setDefense(3 + (int)(getHero_strength() * 0.5));
            getHero_LeftHand().setMagicDefense((int)(getHero_eq() * 0.5));
            getHero_LeftHand().setMaxInjuredLevel(5);
            //左脚
            getHero_LeftLeg().setMaxEndurance((120 + (int)(getHero_endurance() * 0.8)));
            getHero_LeftLeg().setDefense(6 + (int)(getHero_strength() * 0.4));
            getHero_LeftLeg().setMagicDefense((int)(getHero_eq() * 0.6));
            getHero_LeftLeg().setMaxInjuredLevel(7);
            //脖子
            getHero_Neck().setMaxEndurance((50 + (int)(getHero_endurance() * 0.3)));
            getHero_Neck().setDefense(3 + (int)(getHero_strength() * 0.5));
            getHero_Neck().setMagicDefense((int)(getHero_eq() * 1));
            getHero_Neck().setMaxInjuredLevel(3);
            //右臂
            getHero_RightArm().setMaxEndurance((120 + (int)(getHero_endurance() * 0.6)));
            getHero_RightArm().setDefense(5 + (int)(getHero_strength() * 0.7));
            getHero_RightArm().setMagicDefense((int)(getHero_eq() * 0.5));
            getHero_RightArm().setMaxInjuredLevel(7);
            //右脚
            getHero_RightFoot().setMaxEndurance((140 + (int)(getHero_endurance() * 0.6)));
            getHero_RightFoot().setDefense(5 + (int)(getHero_strength() * 0.8));
            getHero_RightFoot().setMagicDefense((int)(getHero_eq() * 0.3));
            getHero_RightFoot().setMaxInjuredLevel(6);
            //右手
            getHero_RightHand().setMaxEndurance((90 + (int)(getHero_endurance() * 0.7)));
            getHero_RightHand().setDefense(3 + (int)(getHero_strength() * 0.5));
            getHero_RightHand().setMagicDefense((int)(getHero_eq() * 0.5));
            getHero_RightHand().setMaxInjuredLevel(5);
            //右脚
            getHero_RightLeg().setMaxEndurance((120 + (int)(getHero_endurance() * 0.8)));
            getHero_RightLeg().setDefense(6 + (int)(getHero_strength() * 0.4));
            getHero_RightLeg().setMagicDefense((int)(getHero_eq() * 0.6));
            getHero_RightLeg().setMaxInjuredLevel(7);
            //腹部
            getHero_Web().setMaxEndurance((150 + (int)(getHero_endurance() * 0.5)));
            getHero_Web().setDefense(3 + (int)(getHero_strength() * 0.4));
            getHero_Web().setMagicDefense((int)(getHero_eq() * 0.6));
            getHero_Web().setMaxInjuredLevel(8);

        }

    }
}
