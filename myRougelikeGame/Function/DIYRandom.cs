using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRougelikeGame.Function
{   //用户输入a和b，返回的几率为a/b
    class DIYRandom
    {
        private Random myRandom = new Random();
        private int i;
        public bool startBet(int a, int b){
            i = myRandom.Next(1, b+1);
            if (i <= a) { return true; }
            else { return false; }

        }
        public int getRandomNum(int a,int b) {
            return myRandom.Next(a, b + 1);
        }
    }
}
