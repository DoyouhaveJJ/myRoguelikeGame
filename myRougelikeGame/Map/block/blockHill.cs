using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Loot;

namespace myRougelikeGame.Map.block
{
    class blockHill:defaultBlock
    {
        public blockHill() {
            setName("山地");
            setType(4);
            setBlockLoot(new hillLoot());
            setMob_Count(0);
            getBlockLoot().initItemID_canLoot();
            getBlockLoot().initItemID_lootRate();
            getBlockLoot().setTheBlock(this);
        }

    }
}
