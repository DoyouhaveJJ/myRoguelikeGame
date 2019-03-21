using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Loot;

namespace myRougelikeGame.Map.block
{
    class blockLake:defaultBlock
    {
        public blockLake() {
            setName("湖泊");
            setType(3);
            setBlockLoot(new lakeLoot());
            getBlockLoot().initItemID_canLoot();
            getBlockLoot().initItemID_lootRate();
            getBlockLoot().setTheBlock(this);
        }
    }
}
