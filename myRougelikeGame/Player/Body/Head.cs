using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;

namespace myRougelikeGame.Player.Body
{
    class Head
    {
        private int Endurance;
        private int maxEndurance;
        private int InjuredLevel;
        private int maxInjuredLevel;
        private int Defense;
        private int magicDefense;

        //头
        private bool isEquipedHat;
        private bool isEquipedGlass;
        private bool isEquipedMask;
        private bool isEquipedEarplug;

        //佩戴物
        private defaultItem takenHat;
        private defaultItem takenGlass;
        private defaultItem takenMask;
        private defaultItem takenEarplug;




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
        public bool getIsEquipedHat()
        {
            return isEquipedHat;
        }
        public void setIsEquipedHat(bool isEquipedHat)
        {
            this.isEquipedHat = isEquipedHat;
        }
        public bool getIsEquipedGlass()
        {
            return isEquipedGlass;
        }
        public void setIsEquipedGlass(bool isEquipedGlass)
        {
            this.isEquipedGlass = isEquipedGlass;
        }
        public bool getIsEquipedMask()
        {
            return isEquipedMask;
        }
        public void setIsEquipedMask(bool isEquipedMask)
        {
            this.isEquipedMask = isEquipedMask;
        }
        public bool getIsEquipedEarplug()
        {
            return isEquipedEarplug;
        }
        public void setIsEquipedEarplug(bool isEquipedEarplug)
        {
            this.isEquipedEarplug = isEquipedEarplug;
        }
        public defaultItem getTakenHat()
        {
            return takenHat;
        }
        public void setTakenHat(defaultItem takenHat)
        {
            this.takenHat = takenHat;
        }
        public defaultItem getTakenGlass()
        {
            return takenGlass;
        }
        public void setTakenGlass(defaultItem takenGlass)
        {
            this.takenGlass = takenGlass;
        }
        public defaultItem getTakenMask()
        {
            return takenMask;
        }
        public void setTakenMask(defaultItem takenMask)
        {
            this.takenMask = takenMask;
        }
        public defaultItem getTakenEarplug()
        {
            return takenEarplug;
        }
        public void setTakenEarplug(defaultItem takenEarplug)
        {
            this.takenEarplug = takenEarplug;
        }

    }
}
