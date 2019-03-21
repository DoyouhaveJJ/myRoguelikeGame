using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Loot;

namespace myRougelikeGame.Map.block
{
    class blockRuin:defaultBlock
    {
         public blockRuin() {
            setName("废墟");
            setType(5);
            setBlockLoot(new ruinLoot());
            getBlockLoot().initItemID_canLoot();
            getBlockLoot().initItemID_lootRate();
            getBlockLoot().setTheBlock(this);
        }
    }
}
