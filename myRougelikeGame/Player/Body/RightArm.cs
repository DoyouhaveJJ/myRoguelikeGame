using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;

namespace myRougelikeGame.Player.Body
{
    class RightArm
    {
        private int Endurance;
        private int maxEndurance;
        private int InjuredLevel;
        private int maxInjuredLevel;
        private int Defense;
        private int magicDefense;

        //右臂
        private bool isEquipedSign;


        //佩戴物
        private defaultItem takenSign;






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

        public bool getIsEquipedSign()
        {
            return isEquipedSign;
        }

        public void setIsEquipedSign(bool isEquipedSign)
        {
            this.isEquipedSign = isEquipedSign;
        }

        public defaultItem getTakenSign()
        {
            return takenSign;
        }

        public void setTakenSign(defaultItem takenSign)
        {
            this.takenSign = takenSign;
        }
        
    }
}
