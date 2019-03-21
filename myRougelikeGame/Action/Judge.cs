using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Action
{
    class Judge
    {
        int[] itemHasRoom = { 3, 5,6 ,13,15};
        public bool checkTypeIsGetRoom(int Type) {
            for (int i = 0; i < itemHasRoom.Length; i++) {
                if (Type == itemHasRoom[i]) {
                    return true;
              }  
            }
            return false;
        }
    }
}
