using Neptun.data;
using Neptun.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptun
{
    public partial class Form2 : Form
    {
        private DBControl db = new DBControl();
        private List<Subjects> subs = new List<Subjects>();
        private List<Users> users = new List<Users>();
        public Form2()
        {
            InitializeComponent();
            _ = db.Initialize();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Subjects s in db.GetSub().Result)
            {
                subs = db.GetSub().Result;
            }
            foreach (Users u in db.GetUser().Result)
            {
                users = db.GetUser().Result;
            }
            dataGridView1.DataSource = subs;

            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem(subs[0].Name, 0);
            item1.SubItems.Add(Convert.ToString(subs[0].Stock) + " / " + Convert.ToString(subs[0].onclass));
            ListViewItem item2 = new ListViewItem(subs[1].Name, 0);
            item2.SubItems.Add(Convert.ToString(subs[1].Stock) + " / " + Convert.ToString(subs[1].onclass));
            ListViewItem item3 = new ListViewItem(subs[2].Name, 0);
            item3.SubItems.Add(Convert.ToString(subs[2].Stock) + " / " + Convert.ToString(subs[2].onclass));
            ListViewItem item4 = new ListViewItem(subs[3].Name, 0);
            item4.SubItems.Add(Convert.ToString(subs[3].Stock) + " / " + Convert.ToString(subs[3].onclass));

            listView1.Columns.Add("Tárgy neve", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Férőhely", -2, HorizontalAlignment.Left);
            
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 ,item4});
            this.Controls.Add(listView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var firstSelectedItem = listView1.SelectedItems[0];
            Form3 formPopup = new Form3();
            formPopup.index = firstSelectedItem.Index;
            formPopup.LoadSub(subs[firstSelectedItem.Index].Name, subs[firstSelectedItem.Index].Description, subs[firstSelectedItem.Index].Stock, subs[firstSelectedItem.Index].TargyId);
            formPopup.Tag = this;
            formPopup.Show(this);
            Hide();
            //formPopup.Show(this);
            
        }

        public void ClearSelection()
        {
            listView1.SelectedItems.Clear();
            listView1.SelectedIndices.Clear();
        }
    }
}
