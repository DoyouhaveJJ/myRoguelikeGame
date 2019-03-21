using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Mob.Enemy;
using myRougelikeGame.Mob;
using myRougelikeGame.Function;
using myRougelikeGame.Battle;
using myRougelikeGame.Player;
namespace myRougelikeGame.Action
{
    class MeetEnemy
    {
        private DIYRandom dr = new DIYRandom();
        public void MeetAnEnemy(theHero hero , BattleField battle) {
            if (dr.startBet(1, 3)) {
                theBattle b = new theBattle();
                battle.setMyHero(hero);

                //新敌人
                if (dr.startBet(1, 2))
                    battle.setTheMob(new enemy_Slime());
                else
                    battle.setTheMob(new enemy_Goblin());
                b.Tag = battle;
                b.ShowDialog();
            }
        }

    }
}
