using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Loot
{
    class forestLoot:defaultLoot
    {
        public forestLoot() {
            setLootIndex(getRandomNum(300,600));
            setMaxLootIndex(10000);     
        }


        
        public override void initItemID_canLoot()
        {
            base.initItemID_canLoot();
            getItemID_canLoot().Add(1);//苹果
            getItemID_canLoot().Add(3);//木棍
            getItemID_canLoot().Add(5);//长棍
        }
        public override void initItemID_lootRate()
        {
            base.initItemID_lootRate();
            getItemID_lootRate().Add(1000);//苹果搜刮率
            getItemID_lootRate().Add(600);//木棍搜刮率
            getItemID_lootRate().Add(400);//长棍搜刮率
        } 
         
    }
}
