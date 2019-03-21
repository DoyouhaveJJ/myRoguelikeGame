using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Loot
{
    class painLoot:defaultLoot
    {
         public painLoot() {
            setLootIndex(getRandomNum(50,100));
            setMaxLootIndex(10000);     
        }


        
        public override void initItemID_canLoot()
        {
            base.initItemID_canLoot();
            getItemID_canLoot().Add(4);//塑料袋
          //  getItemID_canLoot().Add(5);//长棍
        }
        public override void initItemID_lootRate()
        {
            base.initItemID_lootRate();
            getItemID_lootRate().Add(100);//塑料袋
          //  getItemID_lootRate().Add(100);//长棍搜刮率
        } 
    }
}
