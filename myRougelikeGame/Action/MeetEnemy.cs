using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Mob.Enemy;
using myRougelikeGame.Mob;
using myRougelikeGame.Function;
using myRougelikeGame.Battle;
using myRougelikeGame.Player;
using myRougelikeGame.Map;
namespace myRougelikeGame.Action
{
    class MeetEnemy
    {
        private DIYRandom dr = new DIYRandom();
        public void MeetAnEnemy(theHero hero , BattleField battle) {
            
        }
        public void MeetEnemyAtBlock(theHero hero, BattleField battle)
        {
            if (hero.getStandBlock().getMob_Count() != 0)
            {
                theBattle b = new theBattle();
                battle.setMyHero(hero);
                battle.setTheMobList(hero.getStandBlock().getMob_list());
                b.Tag = battle;
                b.ShowDialog();

            }
        }
        public void initEnemyAtBlock(defaultBlock block,int ID){
            switch(ID){
                case 1: { block.getMob_list().Add(new enemy_Slime()); break; }
                case 2: { block.getMob_list().Add(new enemy_Goblin()); break; }
        }
            block.setMob_Count(block.getMob_list().Count);

        }

    }
}
