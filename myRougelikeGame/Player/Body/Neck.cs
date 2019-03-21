using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;

namespace myRougelikeGame.Player.Body
{
    class Neck
    {
        private int Endurance;
        private int maxEndurance;
        private int InjuredLevel;
        private int maxInjuredLevel;
        private int Defense;
        private int magicDefense;

        //脖子
        private bool isEquipedNecklace;

        //穿戴物
        private defaultItem takenNecklace;




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

        public bool getIsEquipedNecklace()
        {
            return isEquipedNecklace;
        }

        public void setIsEquipedNecklace(bool isEquipedNecklace)
        {
            this.isEquipedNecklace = isEquipedNecklace;
        }

        public defaultItem getTakenNecklace()
        {
            return takenNecklace;
        }

        public void setTakenNecklace(defaultItem takenNecklace)
        {
            this.takenNecklace = takenNecklace;
        }
    }
}
