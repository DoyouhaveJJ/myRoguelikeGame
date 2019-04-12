using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;

namespace myRougelikeGame.Player.Body
{
    class LeftLeg
    {
        private int Endurance;
        private int maxEndurance;
        private int InjuredLevel;
        private int maxInjuredLevel;
        private int Defense;
        private int magicDefense;

        //左腿
        private bool isEquipedPants;

        //穿戴物
        private defaultItem takenPants;



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

        public bool getIsEquipedPants()
        {
            return isEquipedPants;
        }

        public void setIsEquipedPants(bool isEquipedPants)
        {
            this.isEquipedPants = isEquipedPants;
        }

        public defaultItem getTakenPants()
        {
            return takenPants;
        }

        public void setTakenPants(defaultItem takenPants)
        {
            this.takenPants = takenPants;
        }

    }
}
