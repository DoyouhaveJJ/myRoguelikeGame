using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using myRougelikeGame.Items.Materials;
using myRougelikeGame.Items.Weapon;
namespace myRougelikeGame.Craft
{
    class CraftList
    {
        private int[,] Table = new int[3, 3];
        ArrayList result = new ArrayList();
        public void setTable(int q,int w,int e,int a,int s,int d,int z,int x,int c)
        {
            Table[0, 0] = q;
            Table[0, 1] = w;
            Table[0, 2] = e;
            Table[1, 0] = a;
            Table[1, 1] = s;
            Table[1, 2] = d;
            Table[2, 0] = z;
            Table[2, 1] = x;
            Table[2, 2] = c;
        }
        public int checkCraft()
        {
            if(Table[0, 0]==-1  &&Table[0, 1]==-1  &&Table[0, 2]==-1  &&
               Table[1, 0]==-1  &&Table[1, 1]==22  &&Table[1, 2]==-1  &&
               Table[2, 0]==-1 &&Table[2, 1]==-1  &&Table[2, 2]==-1  )
            {
                    return 1;
            }

            
            if (Table[0, 0] == -1 && Table[0, 1] == -1 && Table[0, 2] == -1 &&
               Table[1, 0] == -1 && Table[1, 1] == 23 && Table[1, 2] == -1 &&
               Table[2, 0] == -1 && Table[2, 1] == -1 && Table[2, 2] == -1)
            {
                return 2;
            }


            
            if (Table[0, 0] ==-1 && Table[0, 1] == 25 && Table[0, 2] == -1 &&
               Table[1, 0] == -1 && Table[1, 1] == 24 && Table[1, 2] == -1 &&
               Table[2, 0] == -1 && Table[2, 1] == 25 && Table[2, 2] == -1)
            {
                return 3;
            }
 
            /*
             if (Table[0, 0] == 0 && Table[0, 1] == 0 && Table[0, 2] == 0 &&
               Table[1, 0] == 0 && Table[1, 1] == 0 && Table[1, 2] == 0 &&
               Table[2, 0] == 0 && Table[2, 1] == 0 && Table[2, 2] == 0)
            {
                return 1;
            }


 */


            return -1;


        }
        public ArrayList craftItemByID(int ID)
        {
            result.Clear();
            switch (ID)
            {
                case 1: { 
                    result.Add(new material_Glue());
                    result.Add(new material_Glue());
                    result.Add(new material_Glue());
                    return result;
                }//1号合成，1个史莱姆尸体（任意位置） = 3个胶水
                case 2:
                    {
                        result.Add(new material_Bone());
                        result.Add(new material_Bone());
                        result.Add(new material_GreenSkin());
                        return result;
                    }
                case 3:
                    {
                        result.Add(new weapon_BoneStick());
                        return result;
                    }
                case 4: { return null; }
                case 5: { return null; }
                default: { return null; }
                
            }

        }



    }
}
