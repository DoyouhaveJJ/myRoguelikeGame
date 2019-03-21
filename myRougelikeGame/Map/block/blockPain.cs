using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Loot;

namespace myRougelikeGame.Map.block
{
    class blockPain:defaultBlock
    {
        public blockPain() {
            setName("平原");
            setType(1);
            setBlockLoot(new painLoot());
            getBlockLoot().initItemID_canLoot();
            getBlockLoot().initItemID_lootRate();
            getBlockLoot().setTheBlock(this);
        }
    }
}
