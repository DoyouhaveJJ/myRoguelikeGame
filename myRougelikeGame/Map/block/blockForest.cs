using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Loot;
namespace myRougelikeGame.Map.block
{
    class blockForest:defaultBlock
    {
        public blockForest() {
            setName("森林");
            setType(2);
            setBlockLoot(new forestLoot());
            setMob_Count(0);
            getBlockLoot().initItemID_canLoot();
            getBlockLoot().initItemID_lootRate();
            getBlockLoot().setTheBlock(this);
        }
    }

}
