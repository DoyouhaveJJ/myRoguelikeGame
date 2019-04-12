using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items;

namespace myRougelikeGame.Player.Body
{
    class RightFoot
    {
        private int Endurance;
        private int maxEndurance;
        private int InjuredLevel;
        private int maxInjuredLevel;
        private int Defense;
        private int magicDefense;



        //右脚
        private bool isEquipedStock;
        private bool isEquipedShoes;

        //佩戴物

        private defaultItem takenStock;
        private defaultItem takenShoes;

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
        public bool getIsEquipedStock()
        {
            return isEquipedStock;
        }
        public void setIsEquipedStock(bool isEquipedStock)
        {
            this.isEquipedStock = isEquipedStock;
        }
        public bool getIsEquipedShoes()
        {
            return isEquipedShoes;
        }
        public void setIsEquipedShoes(bool isEquipedShoes)
        {
            this.isEquipedShoes = isEquipedShoes;
        }
        public defaultItem getTakenStock()
        {
            return takenStock;
        }
        public void setTakenStock(defaultItem takenStock)
        {
            this.takenStock = takenStock;
        }
        public defaultItem getTakenShoes()
        {
            return takenShoes;
        }
        public void setTakenShoes(defaultItem takenShoes)
        {
            this.takenShoes = takenShoes;
        }
    }
}
