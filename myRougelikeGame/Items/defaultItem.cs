using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Player;

namespace myRougelikeGame.Items
{
    abstract class defaultItem
    {//通常
        private Random randomNum = new Random();
        private System.Windows.Forms.ListBox MessageBox;
        private int ID;
        private double weight;
        private double endurance;
        private double maxEndurance;
        private double endurance_byStep;
        private int type;
        private string name;
        private string describe;
        private int level;
        private int cost;
        private string effecDescribe;
        private bool isEquited;


    //食物  耐久通过移动减少
        private int hungryDecrease;
        private int hungryIncrease;
        private int thristyDecrease;
        private int thristyIncrease;
        private int qualityIndex;
        private int immDecrease;
        private int immIncrease;
        private int peeIncrease;
        private int shitIncrease;
        private int energyIncrease;



    //武器 耐久通过使用,攻击,移动减少
        
        private double endurance_byAttack;
        private double endurance_byUse;
        private int minDamage;
        private int maxDamage;
        private int minMagicDamage;
        private int maxMagicDamage;
        private int greatDamageRate;
        private int greatDamageIndex;
        private int hitRate;

        public void decreaseEnduranceByUse(){
            if ((getEndurance() - getEndurance_byUse()) <= 0)
            {
                setEndurance(0);
            }
            setEndurance(getEndurance() - getEndurance_byUse());
            updataQuality();
        }
        public void decreaseEnduranceByAttack(){
            if ((getEndurance() - getEndurance_byAttack()) <= 0)
            {
                setEndurance(0);
            }
            setEndurance(getEndurance() - getEndurance_byAttack());
            updataQuality();
        }


        //可穿戴物品
        private int Defense;
        private int magicDefense;
        private int Room;
        private int Plus_1;
        private int Plus_2;
        private int Plus_3;
        private int Plus_4;
        
        private int Add_strength;  //力量
        private int Add_iq;        //智商
        private int Add_lucky;     //运气
        private int Add_agility;   //敏捷
        private int Add_charm;     //魅力
        private int Add_face;      //颜值
        private int Add_eq;        //情商
        private int Add_talk;      //说话
        private int Add_endurance; //耐力
        private int Add_eye;       //视力
        



        public int getRandomNum(int a, int b) {
            return randomNum.Next(a, b+1);
        }





        public bool getIsEquited()
        {
            return isEquited;
        }

        public void setIsEquited(bool isEquited)
        {
            this.isEquited = isEquited;
        }
        public int getMinDamage()
        {
            return minDamage;
        }
        public void setMinDamage(int minDamage)
        {
            this.minDamage = minDamage;
        }
        public int getMaxDamage()
        {
            return maxDamage;
        }
        public void setMaxDamage(int maxDamage)
        {
            this.maxDamage = maxDamage;
        }
        public int getMinMagicDamage()
        {
            return minMagicDamage;
        }
        public void setMinMagicDamage(int minMagicDamage)
        {
            this.minMagicDamage = minMagicDamage;
        }
        public int getMaxMagicDamage()
        {
            return maxMagicDamage;
        }
        public void setMaxMagicDamage(int maxMagicDamage)
        {
            this.maxMagicDamage = maxMagicDamage;
        }
        public int getGreatDamageRate()
        {
            return greatDamageRate;
        }
        public void setGreatDamageRate(int greatDamageRate)
        {
            this.greatDamageRate = greatDamageRate;
        }
        public int getGreatDamageIndex()
        {
            return greatDamageIndex;
        }
        public void setGreatDamageIndex(int greatDamageIndex)
        {
            this.greatDamageIndex = greatDamageIndex;
        }
        public int getHitRate()
        {
            return hitRate;
        }
        public void setHitRate(int hitRate)
        {
            this.hitRate = hitRate;
        }
        public int getHungryDecrease()
        {
            return hungryDecrease;
        }
        public void setHungryDecrease(int hungryDecrease)
        {
            this.hungryDecrease = hungryDecrease;
        }
        public int getHungryIncrease()
        {
            return hungryIncrease;
        }
        public void setHungryIncrease(int hungryIncrease)
        {
            this.hungryIncrease = hungryIncrease;
        }
        public int getThristyDecrease()
        {
            return thristyDecrease;
        }
        public void setThristyDecrease(int thristyDecrease)
        {
            this.thristyDecrease = thristyDecrease;
        }
        public int getThristyIncrease()
        {
            return thristyIncrease;
        }
        public void setThristyIncrease(int thristyIncrease)
        {
            this.thristyIncrease = thristyIncrease;
        }
        public int getQualityIndex()
        {
            return qualityIndex;
        }
        public void setQualityIndex(int qualityIndex)
        {
            this.qualityIndex = qualityIndex;
        }
        public int getImmDecrease()
        {
            return immDecrease;
        }
        public void setImmDecrease(int immDecrease)
        {
            this.immDecrease = immDecrease;
        }
        public int getImmIncrease()
        {
            return immIncrease;
        }
        public void setImmIncrease(int immIncrease)
        {
            this.immIncrease = immIncrease;
        }
        public int getPeeIncrease()
        {
            return peeIncrease;
        }
        public void setPeeIncrease(int peeIncrease)
        {
            this.peeIncrease = peeIncrease;
        }
        public int getShitIncrease()
        {
            return shitIncrease;
        }
        public void setShitIncrease(int shitIncrease)
        {
            this.shitIncrease = shitIncrease;
        }
        public int getEnergyIncrease()
        {
            return energyIncrease;
        }
        public void setEnergyIncrease(int energyIncrease)
        {
            this.energyIncrease = energyIncrease;
        }
        public double getMaxEndurance()
        {
            return maxEndurance;
        }
        public void setMaxEndurance(double maxEndurance)
        {
            this.maxEndurance = maxEndurance;
        }
        public int getID()
        {
            return ID;
        }
        public void setID(int iD)
        {
            ID = iD;
        }
        public double getWeight()
        {
            return weight;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }
        public double getEndurance()
        {
            return endurance;
        }
        public void setEndurance(double endurance)
        {
            this.endurance = endurance;
        }
        public double getEndurance_byStep()
        {
            return endurance_byStep;
        }
        public void setEndurance_byStep(double endurance_byStep)
        {
            this.endurance_byStep = endurance_byStep;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getDescribe()
        {
            return describe;
        }
        public void setDescribe(string describe)
        {
            this.describe = describe;
        }
        public int getLevel()
        {
            return level;
        }
        public void setLevel(int level)
        {
            this.level = level;
        }
        public int getCost()
        {
            return cost;
        }
        public void setCost(int cost)
        {
            this.cost = cost;
        }
        public string getEffecDescribe()
        {
            return effecDescribe;
        }
        public void setEffecDescribe(string effecDescribe)
        {
            this.effecDescribe = effecDescribe;
        }

        public int getDefense()
        {
            return Defense;
        }
        public void setDefense(int defense)
        {
            Defense = defense;
        }
        public int getMagicDefense()
        {
            return magicDefense;
        }
        public void setMagicDefense(int magicDefense)
        {
            this.magicDefense = magicDefense;
        }
        public int getRoom()
        {
            return Room;
        }
        public void setRoom(int room)
        {
            Room = room;
        }
        public int getPlus_1()
        {
            return Plus_1;
        }
        public void setPlus_1(int plus_1)
        {
            Plus_1 = plus_1;
        }
        public int getPlus_2()
        {
            return Plus_2;
        }
        public void setPlus_2(int plus_2)
        {
            Plus_2 = plus_2;
        }
        public int getPlus_3()
        {
            return Plus_3;
        }
        public void setPlus_3(int plus_3)
        {
            Plus_3 = plus_3;
        }
        public int getPlus_4()
        {
            return Plus_4;
        }
        public void setPlus_4(int plus_4)
        {
            Plus_4 = plus_4;
        }
        public double getEndurance_byAttack()
        {
            return endurance_byAttack;
        }
        public void setEndurance_byAttack(double endurance_byAttack)
        {
            this.endurance_byAttack = endurance_byAttack;
        }
        public double getEndurance_byUse()
        {
            return endurance_byUse;
        }
        public void setEndurance_byUse(double endurance_byUse)
        {
            this.endurance_byUse = endurance_byUse;
        }
        public System.Windows.Forms.ListBox getMessageBox()
        {
            return MessageBox;
        }

        public void setMessageBox(System.Windows.Forms.ListBox messageBox)
        {
            MessageBox = messageBox;
        }
        public int getAdd_strength()
        {
            return Add_strength;
        }
        public void setAdd_strength(int add_strength)
        {
            Add_strength = add_strength;
        }
        public int getAdd_iq()
        {
            return Add_iq;
        }
        public void setAdd_iq(int add_iq)
        {
            Add_iq = add_iq;
        }
        public int getAdd_lucky()
        {
            return Add_lucky;
        }
        public void setAdd_lucky(int add_lucky)
        {
            Add_lucky = add_lucky;
        }
        public int getAdd_agility()
        {
            return Add_agility;
        }
        public void setAdd_agility(int add_agility)
        {
            Add_agility = add_agility;
        }
        public int getAdd_charm()
        {
            return Add_charm;
        }
        public void setAdd_charm(int add_charm)
        {
            Add_charm = add_charm;
        }
        public int getAdd_face()
        {
            return Add_face;
        }
        public void setAdd_face(int add_face)
        {
            Add_face = add_face;
        }
        public int getAdd_eq()
        {
            return Add_eq;
        }
        public void setAdd_eq(int add_eq)
        {
            Add_eq = add_eq;
        }
        public int getAdd_talk()
        {
            return Add_talk;
        }
        public void setAdd_talk(int add_talk)
        {
            Add_talk = add_talk;
        }
        public int getAdd_endurance()
        {
            return Add_endurance;
        }
        public void setAdd_endurance(int add_endurance)
        {
            Add_endurance = add_endurance;
        }
        public int getAdd_eye()
        {
            return Add_eye;
        }
        public void setAdd_eye(int add_eye)
        {
            Add_eye = add_eye;
        }








        virtual public void UnEquipItem(theHero user) { }
        virtual public void EquipItem(theHero user) { }
        virtual public void UseItem(theHero user){return ;}
        virtual public void updataQuality()
        {
        }

        public void DecreaseEndurance() {
            if ((getEndurance() - getEndurance_byStep()) <= 0)
            {
                setEndurance(0);
            }
            setEndurance(getEndurance() - getEndurance_byStep());
            updataQuality();
        }




        virtual public bool isDestoryed() {return false; }
    }
}
