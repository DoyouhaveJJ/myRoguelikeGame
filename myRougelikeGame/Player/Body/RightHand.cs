using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;
namespace myRougelikeGame.Player.Body
{
    class RightHand
    {
        private int Endurance;
        private int maxEndurance;
        private int InjuredLevel;
        private int maxInjuredLevel;
        private int Defense;
        private int magicDefense;


        //右手
        private bool isEquipedSomething;
        private bool isEquipedGlove;
        private bool isLeftHand;
        private bool isStrongHand;
        private bool isEquipedRing;

        //佩戴物
        private defaultItem takeInHand;
        private defaultItem takenRing;
        private defaultItem takenGlove;


        public void getDamage(int damage)
        {
            if (getEndurance() - damage <= 0)
            {
                setEndurance(0);
            }
            else
            {
                setEndurance(getEndurance() - damage);
            }
        }


        public defaultItem getTakenGlove()
        {
            return takenGlove;
        }

        public void setTakenGlove(defaultItem takenGlove)
        {
            this.takenGlove = takenGlove;
        }
        public defaultItem getTakeInHand()
        {
            return takeInHand;
        }


        public defaultItem getTakenRing()
        {
            return takenRing;
        }

        public void setTakenRing(defaultItem takenRing)
        {
            this.takenRing = takenRing;
        }
        public void setTakeInHand(defaultItem takeInHand)
        {
            this.takeInHand = takeInHand;
        }


        public int getEndurance()
        {
            return Endurance;
        }
        public void setEndurance(int endurance)
        {
            Endurance = endurance;
        }
        public int getMaxEndurance()
        {
            return maxEndurance;
        }
        public void setMaxEndurance(int maxEndurance)
        {
            this.maxEndurance = maxEndurance;
        }
        public int getInjuredLevel()
        {
            return InjuredLevel;
        }
        public void setInjuredLevel(int injuredLevel)
        {
            InjuredLevel = injuredLevel;
        }
        public int getMaxInjuredLevel()
        {
            return maxInjuredLevel;
        }
        public void setMaxInjuredLevel(int maxInjuredLevel)
        {
            this.maxInjuredLevel = maxInjuredLevel;
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
        public bool getIsEquipedSomething()
        {
            return isEquipedSomething;
        }
        public void setIsEquipedSomething(bool isEquipedSomething)
        {
            this.isEquipedSomething = isEquipedSomething;
        }
        public bool getIsEquipedGlove()
        {
            return isEquipedGlove;
        }
        public void setIsEquipedGlove(bool isEquipedGlove)
        {
            this.isEquipedGlove = isEquipedGlove;
        }
        public bool getIsLeftHand()
        {
            return isLeftHand;
        }
        public void setIsLeftHand(bool isLeftHand)
        {
            this.isLeftHand = isLeftHand;
        }
        public bool getIsStrongHand()
        {
            return isStrongHand;
        }
        public void setIsStrongHand(bool isStrongHand)
        {
            this.isStrongHand = isStrongHand;
        }
        public bool getIsEquipedRing()
        {
            return isEquipedRing;
        }
        public void setIsEquipedRing(bool isEquipedRing)
        {
            this.isEquipedRing = isEquipedRing;
        }
    }
}
