using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Function;
using myRougelikeGame.Map.block;

namespace myRougelikeGame.Map
{
    class world
    {
        private defaultBlock[,] blocks = new defaultBlock[400, 400];
        private blockRandom br = new blockRandom();
        //private int x, y;

        public void init() {
            for (int i = 0; i < 400; i++) {
                for (int j = 0; j < 400; j++) {
                    blocks[i, j] = new defaultBlock();
                    switch (br.once()) {
                        case 1: { blocks[i, j] = new blockPain(); blocks[i, j].setID(400 * i + j); blocks[i, j].setLoc_x(i); blocks[i, j].setLoc_x(j); break; }
                        case 2: { blocks[i, j] = new blockForest(); blocks[i, j].setID(400 * i + j); blocks[i, j].setLoc_x(i); blocks[i, j].setLoc_x(j); break; }
                        case 3: { blocks[i, j] = new blockLake(); blocks[i, j].setID(400 * i + j); blocks[i, j].setLoc_x(i); blocks[i, j].setLoc_x(j); break; }
                        case 4: { blocks[i, j] = new blockHill(); blocks[i, j].setID(400 * i + j); blocks[i, j].setLoc_x(i); blocks[i, j].setLoc_x(j); break; }
                        case 5: { blocks[i, j] = new blockRuin(); blocks[i, j].setID(400 * i + j); blocks[i, j].setLoc_x(i); blocks[i, j].setLoc_x(j); break; }
                    }
                }
            }
        }
        public defaultBlock getBlockByXY(int x,int y) {
            return blocks[x, y];
        }   


      

        //public void showWorld() {
        //    for (int i = 0; i < 400; i++)
        //    {
        //        for (int j = 0; j < 400; j++)
        //        {
        //            System.Console.WriteLine(blocks[i, j].getName());
        //        }
        //    }
        //}

        public int getBlockType(int i,int j) {
            return blocks[i, j].getType();
          }

        public string showBlock(int i, int j) {
        return blocks[i, j].getName();
            
        }

    }
}
