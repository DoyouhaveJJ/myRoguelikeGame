using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Loot
{
    class lakeLoot:defaultLoot
    {
         public lakeLoot() {
            setLootIndex(getRandomNum(200,400));
            setMaxLootIndex(10000);     
        }


        
        public override void initItemID_canLoot()
        {
            base.initItemID_canLoot();
            getItemID_canLoot().Add(2);//生水
            getItemID_canLoot().Add(4);//塑料袋
        }
        public override void initItemID_lootRate()
        {
            base.initItemID_lootRate();
            getItemID_lootRate().Add(3000);//生水搜刮率
            getItemID_lootRate().Add(700);//塑料袋搜刮率
        } 
    }
}
