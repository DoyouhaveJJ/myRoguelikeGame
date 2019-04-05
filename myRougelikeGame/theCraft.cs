using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using myRougelikeGame.Craft;
using myRougelikeGame.Items;

namespace myRougelikeGame
{
    public partial class theCraft : Form
    {

        private DoCraft craft;
        private defaultItem selectedItem;
        private defaultItem nullItem = new NullItem();
        private int index;
        public theCraft()
        {
            InitializeComponent();
            setNull();
        }

        private void theCraft_Load(object sender, EventArgs e)
        {

            craft = (DoCraft)this.Tag;
            craft.setFakeBox(listBox1);
            craft.setTrueBox(listBox2);
            craft.setFakeResBox(listBox3);
            craft.setQ(q);
            craft.setW(w);
            craft.setE(this.e);
            craft.setA(a);
            craft.setS(s);
            craft.setD(d);
            craft.setZ(z);
            craft.setX(x);
            craft.setC(c);
            craft.updata();
        }
        private void setNull()
        {
            q.Text = "";
            q.Tag = nullItem;
            w.Text = "";
            w.Tag = nullItem;
            e.Text = "";
            e.Tag = nullItem;
            a.Text = "";
            a.Tag = nullItem;
            s.Text = "";
            s.Tag = nullItem;
            d.Text = "";
            d.Tag = nullItem;
            z.Text = "";
            z.Tag = nullItem;
            x.Text = "";
            x.Tag = nullItem;
            c.Text = "";
            c.Tag = nullItem;
            selectedItem = null;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                index = listBox1.SelectedIndex;
                selectedItem = (defaultItem)(listBox2.Items[index]);
            }
            else
            {
                selectedItem = null;
            }
        }

        private void q_Click(object sender, EventArgs e)
        {
            if ((defaultItem)q.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)q.Tag).getName());
            listBox2.Items.Add((defaultItem)q.Tag);
            craft.removeAnItemFromPreList((defaultItem)q.Tag);
            q.Text = "";
            q.Tag = nullItem;
            craft.putAnItemOnTable();

        }

        private void q_DragDrop(object sender, DragEventArgs e)
        {

            if ((q.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)q.Tag);
                listBox1.Items.Add(((defaultItem)q.Tag).getName());
                listBox2.Items.Add((defaultItem)q.Tag);
            }

            q.Text = (selectedItem).getName();
            q.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.Items.Count == 0) { return; }
            if (listBox1.SelectedItem == null) { return; }
            else
            {
                index = listBox1.SelectedIndex;
                selectedItem = (defaultItem)(listBox2.Items[index]);
                DragDropEffects dde1 = DoDragDrop(selectedItem, DragDropEffects.All);
            }
        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_DragLeave(object sender, EventArgs e)
        {

        }

        private void q_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void w_DragDrop(object sender, DragEventArgs e)
        {
            if ((w.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)w.Tag);
                listBox1.Items.Add(((defaultItem)w.Tag).getName());
                listBox2.Items.Add((defaultItem)w.Tag);
            }
            w.Text = (selectedItem).getName();
            w.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();
        }

        private void w_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void e_DragDrop(object sender, DragEventArgs e)
        {
            if ((this.e.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)this.e.Tag);
                listBox1.Items.Add(((defaultItem)this.e.Tag).getName());
                listBox2.Items.Add((defaultItem)this.e.Tag);
            }
            this.e.Text = (selectedItem).getName();
            this.e.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();
        }

        private void e_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void a_DragDrop(object sender, DragEventArgs e)
        {
            if ((a.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)a.Tag);
                listBox1.Items.Add(((defaultItem)a.Tag).getName());
                listBox2.Items.Add((defaultItem)a.Tag);
            }
            a.Text = (selectedItem).getName();
            a.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();
        }

        private void a_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void s_DragDrop(object sender, DragEventArgs e)
        {
            if ((s.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)s.Tag);
                listBox1.Items.Add(((defaultItem)s.Tag).getName());
                listBox2.Items.Add((defaultItem)s.Tag);
            }
            s.Text = (selectedItem).getName();
            s.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);
            craft.putAnItemOnTable();
        }

        private void s_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void d_DragDrop(object sender, DragEventArgs e)
        {
            if ((d.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)d.Tag);
                listBox1.Items.Add(((defaultItem)x.Tag).getName());
                listBox2.Items.Add((defaultItem)x.Tag);
            }
            d.Text = (selectedItem).getName();
            d.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();

        }

        private void d_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void z_DragDrop(object sender, DragEventArgs e)
        {
            if ((z.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)z.Tag);
                listBox1.Items.Add(((defaultItem)z.Tag).getName());
                listBox2.Items.Add((defaultItem)z.Tag);
            }
            z.Text = (selectedItem).getName();
            z.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();
        }

        private void z_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void x_DragDrop(object sender, DragEventArgs e)
        {
            if ((x.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)x.Tag);
                listBox1.Items.Add(((defaultItem)x.Tag).getName());
                listBox2.Items.Add((defaultItem)x.Tag);
            }
            x.Text = (selectedItem).getName();
            x.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();
        }

        private void x_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void c_DragDrop(object sender, DragEventArgs e)
        {
            if ((c.Tag) != nullItem)
            {
                craft.removeAnItemFromPreList((defaultItem)c.Tag);
                listBox1.Items.Add(((defaultItem)c.Tag).getName());
                listBox2.Items.Add((defaultItem)c.Tag);
            }
            c.Text = (selectedItem).getName();
            c.Tag = (selectedItem);
            craft.addAnItemToPreList(selectedItem);
            listBox1.Items.RemoveAt(index);
            listBox2.Items.RemoveAt(index);

            craft.putAnItemOnTable();
        }

        private void c_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void w_Click(object sender, EventArgs e)
        {
            if ((defaultItem)w.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)w.Tag).getName());
            listBox2.Items.Add((defaultItem)w.Tag);
            craft.removeAnItemFromPreList((defaultItem)w.Tag);
            w.Text = "";
            w.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void e_Click(object sender, EventArgs e)
        {
            if ((defaultItem)this.e.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)this.e.Tag).getName());
            listBox2.Items.Add((defaultItem)this.e.Tag);
            craft.removeAnItemFromPreList((defaultItem)this.e.Tag);
            this.e.Text = "";
            this.e.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void a_Click(object sender, EventArgs e)
        {
            if ((defaultItem)a.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)a.Tag).getName());
            listBox2.Items.Add((defaultItem)a.Tag);
            craft.removeAnItemFromPreList((defaultItem)a.Tag);
            a.Text = "";
            a.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void s_Click(object sender, EventArgs e)
        {
            if ((defaultItem)s.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)s.Tag).getName());
            listBox2.Items.Add((defaultItem)s.Tag);
            craft.removeAnItemFromPreList((defaultItem)s.Tag);
            s.Text = "";
            s.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void d_Click(object sender, EventArgs e)
        {
            if ((defaultItem)d.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)d.Tag).getName());
            listBox2.Items.Add((defaultItem)d.Tag);
            craft.removeAnItemFromPreList((defaultItem)d.Tag);
            d.Text = "";
            d.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void z_Click(object sender, EventArgs e)
        {
            if ((defaultItem)z.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)z.Tag).getName());
            listBox2.Items.Add((defaultItem)z.Tag);
            craft.removeAnItemFromPreList((defaultItem)z.Tag);
            z.Text = "";
            z.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void x_Click(object sender, EventArgs e)
        {
            if ((defaultItem)x.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)x.Tag).getName());
            listBox2.Items.Add((defaultItem)x.Tag);
            craft.removeAnItemFromPreList((defaultItem)x.Tag);
            x.Text = "";
            x.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void c_Click(object sender, EventArgs e)
        {
            if ((defaultItem)c.Tag == nullItem) return;
            listBox1.Items.Add(((defaultItem)c.Tag).getName());
            listBox2.Items.Add((defaultItem)c.Tag);
            craft.removeAnItemFromPreList((defaultItem)c.Tag);
            c.Text = "";
            c.Tag = nullItem;
            craft.putAnItemOnTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (craft.craftOnce())
            {
                craft.getMyHero().craftCauseDecreaseEnergy();
                setNull();
            }
            else { return; }


        }
    }
}
