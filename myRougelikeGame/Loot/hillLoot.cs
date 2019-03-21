using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Loot
{
    class hillLoot:defaultLoot
    {
         public hillLoot() {
            setLootIndex(getRandomNum(700,1000));
            setMaxLootIndex(10000);     
        }


        
        public override void initItemID_canLoot()
        {
            base.initItemID_canLoot();
            getItemID_canLoot().Add(3);//木棍
            getItemID_canLoot().Add(5);//长棍
        }
        public override void initItemID_lootRate()
        {
            base.initItemID_lootRate();
            getItemID_lootRate().Add(400);//木棍搜刮率
            getItemID_lootRate().Add(100);//长棍搜刮率
        } 
    }
}
