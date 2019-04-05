using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myRougelikeGame.Items.Body;
using myRougelikeGame.Items;
using myRougelikeGame.Items.Materials;
using myRougelikeGame.Player;
using System.Windows.Forms;
using System.Collections;
namespace myRougelikeGame.Craft
{
    class DoCraft
    {
        private CraftList craftList = new CraftList();
        private theHero myHero;
        private ArrayList PreCraftItemList = new ArrayList();
        private ArrayList ResultItemList = new ArrayList();
        private ListBox fakeBox;
        private ListBox trueBox;
        private ListBox fakeResBox;
        private int index;
        private defaultItem selectedItem;
        private Label q, w, e, a, s, d, z, x, c;
        public void init()
        {
           
            
        }

        public void updata()
        {
            trueBox.Items.Clear();
            fakeBox.Items.Clear();
            fakeResBox.Items.Clear();
            for(int i = 0 ; i < getMyHero().getHeroBag().getItemArray().Count ; i++){
                if (!((defaultItem)getMyHero().getHeroBag().getItemArray()[i]).getIsEquited())
                {
                    trueBox.Items.Add((defaultItem)getMyHero().getHeroBag().getItemArray()[i]);
                    fakeBox.Items.Add(((defaultItem)getMyHero().getHeroBag().getItemArray()[i]).getName());
                }  
            }
        }
        public void putAnItemOnTable()
        {
           
            craftList.setTable(((defaultItem)q.Tag).getID(), ((defaultItem)w.Tag).getID(), ((defaultItem)e.Tag).getID(), ((defaultItem)a.Tag).getID(), ((defaultItem)s.Tag).getID(), ((defaultItem)d.Tag).getID(), ((defaultItem)z.Tag).getID(), ((defaultItem)x.Tag).getID(), ((defaultItem)c.Tag).getID());
            ResultItemList = craftList.craftItemByID(craftList.checkCraft());
            fakeResBox.Items.Clear();
            if (ResultItemList != null)
            {
                for (int i = 0; i < ResultItemList.Count; i++)
                {
                    fakeResBox.Items.Add(((defaultItem)ResultItemList[i]).getName());
                }
            }
            else return;
        }

        public bool craftOnce()
        {
            if (getResultItemList() == null )
            {
                return false;
            }

            int spaceRoom;
            spaceRoom = getMyHero().getHeroBag().getMaxSpace() - getMyHero().getHeroBag().getSpaceNow() + getPreCraftItemList().Count;
            if (spaceRoom < getResultItemList().Count)
            {
                MessageBox.Show("背包容量不足", "无法合成", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                for (int i = 0; i < getPreCraftItemList().Count; i++)
                {
                    getMyHero().getHeroBag().getItemArray().Remove(getPreCraftItemList()[i]);
                }
                for (int i = 0; i < getResultItemList().Count; i++)
                {
                    getMyHero().getHeroBag().getItemArray().Add(getResultItemList()[i]);
                }
            }
            getResultItemList().Clear();
            getPreCraftItemList().Clear();
            updata();
            return true;
        }

        public void removeAnItemFromPreList(defaultItem item)
        {
            getPreCraftItemList().Remove(item);
        }

        public void addAnItemToPreList(defaultItem item)
        {
            getPreCraftItemList().Add(item);
        }




        public theHero getMyHero()
        {
            return myHero;
        }
        public void setMyHero(theHero myHero)
        {
            this.myHero = myHero;
        }
        public ArrayList getPreCraftItemList()
        {
            return PreCraftItemList;
        }
        public void setPreCraftItemList(ArrayList preCraftItemList)
        {
            PreCraftItemList = preCraftItemList;
        }
        public ArrayList getResultItemList()
        {
            return ResultItemList;
        }
        public void setResultItemList(ArrayList resultItemList)
        {
            ResultItemList = resultItemList;
        }

        public ListBox getFakeBox()
        {
            return fakeBox;
        }
        public void setFakeBox(ListBox fakeBox)
        {
            this.fakeBox = fakeBox;
        }
        public ListBox getTrueBox()
        {
            return trueBox;
        }
        public void setTrueBox(ListBox trueBox)
        {
            this.trueBox = trueBox;
        }


        public Label getQ()
        {
            return q;
        }

        public void setQ(Label q)
        {
            this.q = q;
        }

        public Label getW()
        {
            return w;
        }

        public void setW(Label w)
        {
            this.w = w;
        }

        public Label getE()
        {
            return e;
        }

        public void setE(Label e)
        {
            this.e = e;
        }

        public Label getA()
        {
            return a;
        }

        public void setA(Label a)
        {
            this.a = a;
        }

        public Label getS()
        {
            return s;
        }

        public void setS(Label s)
        {
            this.s = s;
        }

        public Label getD()
        {
            return d;
        }

        public void setD(Label d)
        {
            this.d = d;
        }

        public Label getZ()
        {
            return z;
        }

        public void setZ(Label z)
        {
            this.z = z;
        }

        public Label getX()
        {
            return x;
        }

        public void setX(Label x)
        {
            this.x = x;
        }

        public Label getC()
        {
            return c;
        }

        public void setC(Label c)
        {
            this.c = c;
        }


        public ListBox getFakeResBox()
        {
            return fakeResBox;
        }

        public void setFakeResBox(ListBox fakeResBox)
        {
            this.fakeResBox = fakeResBox;
        }
    }
}
