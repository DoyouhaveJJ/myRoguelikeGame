using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Items.Wearable.Stocks
{
    class stock_WarmStock:defaultItem
    {
        public stock_WarmStock()
        {
            setType(20);//20=袜子
            setName("北极人保暖袜");
            setID(21);
            setWeight(0.015);
            setMaxEndurance(getRandomNum(200, 320));
            setEndurance(getRandomNum(120, 199));
            setEndurance_byStep(0.007);
            setLevel(1);
            setDescribe("我觉得这是盗版");
            setCost(getRandomNum(62, 92));
            setEffecDescribe("淘宝包邮\n耐力+5运气+1");
            setQualityIndex((int)(getEndurance() * 100 / getMaxEndurance()));
            setIsEquited(false);



            setIsEquited(false);
            setMagicDefense(1);
            setDefense(getRandomNum(5, 10));

            setAdd_endurance(5);
            setAdd_lucky(1);
        }


        public override void updataQuality()
        {
            base.updataQuality();
            if (getIsEquited()) { setName("北极人保暖袜(已装备)"); }
            else { setName("北极人保暖袜"); }
        }

        public override bool isDestoryed()
        {
            if (getEndurance() <= 0)
            {
                getMessageBox().Items.Add(getName() + "破掉了，你把臭袜子扔了");
                //System.Console.WriteLine(getName() + "破掉了，不能用啦");
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void EquipItem(Player.theHero user)
        {
            base.EquipItem(user);
           
            user.setHero_lucky(user.getHero_lucky() + getAdd_lucky());
            user.setHero_endurance(user.getHero_endurance() + getAdd_endurance());
          
        }
        public override void UnEquipItem(Player.theHero user)
        {
            base.UnEquipItem(user);
           
            user.setHero_lucky(user.getHero_lucky() - getAdd_lucky());
            user.setHero_endurance(user.getHero_endurance() + getAdd_endurance());


        }
    }
}
