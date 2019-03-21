using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Loot
{
    class ruinLoot:defaultLoot
    {
        public ruinLoot()
        {
            setLootIndex(getRandomNum(900,1200));
            setMaxLootIndex(10000);     
        }
        public override void initItemID_canLoot()
        {
            base.initItemID_canLoot();
            getItemID_canLoot().Add(4);//塑料袋
            getItemID_canLoot().Add(6);
            getItemID_canLoot().Add(7);
            getItemID_canLoot().Add(8);
            getItemID_canLoot().Add(9);
            getItemID_canLoot().Add(10);
            getItemID_canLoot().Add(11);
            getItemID_canLoot().Add(12);
            getItemID_canLoot().Add(13);
            getItemID_canLoot().Add(14);
            getItemID_canLoot().Add(15);
            getItemID_canLoot().Add(16);
            getItemID_canLoot().Add(17);
            getItemID_canLoot().Add(18);
            getItemID_canLoot().Add(19);
            getItemID_canLoot().Add(20);
            getItemID_canLoot().Add(21);
        }
        public override void initItemID_lootRate()
        {
/*帆布腰带
粗布上衣
跑步者耳机
无镜片眼镜
棉手套
绿帽子
廉价口罩
塑料项链
儿童书包
破短裤
小腰包
玩具戒指
拖鞋
姓名臂章
某纪念章
北极人保暖袜*/
            base.initItemID_lootRate();
            getItemID_lootRate().Add(100);//塑料袋
            getItemID_lootRate().Add(60);//
            getItemID_lootRate().Add(123);//
            getItemID_lootRate().Add(67);
            getItemID_lootRate().Add(88);
            getItemID_lootRate().Add(121);
            getItemID_lootRate().Add(231);
            getItemID_lootRate().Add(54);
            getItemID_lootRate().Add(76);
            getItemID_lootRate().Add(67);
            getItemID_lootRate().Add(98);
            getItemID_lootRate().Add(100);
            getItemID_lootRate().Add(121);
            getItemID_lootRate().Add(98);
            getItemID_lootRate().Add(121);
            getItemID_lootRate().Add(21);
            getItemID_lootRate().Add(81);

        } 
    }
}
