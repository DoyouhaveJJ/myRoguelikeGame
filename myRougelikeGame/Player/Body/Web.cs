using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;
namespace myRougelikeGame.Player.Body
{
    class Web
    {
        private int Endurance;
        private int maxEndurance;
        private int InjuredLevel;
        private int maxInjuredLevel;
        private int Defense;
        private int magicDefense;

        //腹部
        private bool isEquipPocked;
        private bool isEquipBelt;

        //佩戴物
        private defaultItem takenPocked;
        private defaultItem takenBelt;





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
        public bool getIsEquipPocked()
        {
            return isEquipPocked;
        }
        public void setIsEquipPocked(bool isEquipPocked)
        {
            this.isEquipPocked = isEquipPocked;
        }
        public bool getIsEquipBelt()
        {
            return isEquipBelt;
        }
        public void setIsEquipBelt(bool isEquipBelt)
        {
            this.isEquipBelt = isEquipBelt;
        }
        public defaultItem getTakenPocked()
        {
            return takenPocked;
        }
        public void setTakenPocked(defaultItem takenPocked)
        {
            this.takenPocked = takenPocked;
        }
        public defaultItem getTakenBelt()
        {
            return takenBelt;
        }
        public void setTakenBelt(defaultItem takenBelt)
        {
            this.takenBelt = takenBelt;
        }
    }
}
