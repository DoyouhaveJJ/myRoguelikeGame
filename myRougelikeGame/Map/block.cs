using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Map;

namespace myRougelikeGame
{
    class block
    {
        private string name;
        private int ID;
        private int type;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public int getID()
        {
            return ID;
        }
        public void setID(int iD)
        {
            ID = iD;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int type)
        {
            this.type = type;
        }
    }
}
