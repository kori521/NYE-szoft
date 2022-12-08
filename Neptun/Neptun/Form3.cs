using Neptun.data;
using Neptun.model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Form3 : Form
    {
        private DBControl db = new DBControl();
        public List<Subjects> subs = new List<Subjects>();
        private List<Users> users = new List<Users>();
        public int index;
        private int hook;
        public Form3()
        {
            InitializeComponent();
            _ = db.Initialize();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            reloadDB();
        }

        public void reloadDB()
        {
            foreach (Subjects s in db.GetSub().Result)
            {
                subs = db.GetSub().Result;
            }
            foreach (Users u in db.GetUser().Result)
            {
                users = db.GetUser().Result;
            }
        }

        public void LoadSub(string name, string desc, int stock,int targyid)
        {
            nev.Text += name;
            leiras.Text += desc;
            hely.Text += Convert.ToString(stock);
            kod.Text += Convert.ToString(targyid);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ClearSelection();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //felvetel
            reloadDB();
            int a = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].live == true) a = i;
            }
            string util = string.Empty;
            string helper = subs[index].TargyId.ToString();
            if (users[a].classes != null && users[a].classes != "")
            {
                if(repeat(a) != true)
                util = helper + "/" + users[a].classes.ToString();
            }
            else
                util = helper;
            var pickup = new Users()
            {
                Id = users[a].Id,
                Name = users[a].Name,
                Password = users[a].Password,
                live = true,
                classes = util,
            };
            _ =  db.InsertClasses(pickup);
            var classcount = new Subjects()
            {
                TargyId = subs[a].TargyId,
                Name = subs[a].Name,
                Description = subs[a].Name,
                Stock= subs[a].Stock,
                onclass = subs[a].onclass+1,
            };
            _ = db.InsertClasses(null,classcount);
            errorbox.Text = "Sikeres tárgyfelvétel!";
            errorbox.ForeColor = Color.Red;
        }

        public bool repeat(int local)
        {
            string[] dsa = new string[users.Count];
            foreach (var item in users)
            {
                string asd = users[local].classes.ToString();
                dsa = asd.Split('/');
                int cut = Convert.ToInt32(dsa[0]);
                if (cut == subs[index].TargyId)
                {
                    hook = cut;
                    errorbox.Text = "Ez tárgy már fel van véve!";
                    errorbox.ForeColor = Color.Orange;
                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //leadas
            reloadDB();
            int a = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].live == true) a = i;
            }

            if (repeat(a) == true)
            {
                string[] dsa = new string[subs.Count];
                string delete = "";
                foreach (var item in subs)
                {
                    delete = Convert.ToString(hook);
                    dsa = new string[users.Count];
                    string asd = users[a].classes.ToString();
                    dsa = asd.Split('/');                  
                }
                string util = string.Empty;
                for (int i = 0; i < dsa.Length; i++)
                {
                    if (dsa[i] == delete)
                    {
                        dsa[i] = null;
                    }
                    else
                    {
                        if (dsa[i] != string.Empty)
                        {
                            util = dsa[i];
                        }
                        else
                        {
                            util += dsa[i] + "/";
                        }

                    } 
                        
                }

                string helper = subs[index].TargyId.ToString();
                if (users[a].classes != null)
                {
                    if (repeat(a) != true)
                        util = helper + "/" + users[a].classes.ToString();
                }
                else
                    util = helper;
                var pickup = new Users()
                {
                    Id = users[a].Id,
                    Name = users[a].Name,
                    Password = users[a].Password,
                    live = true,
                    classes = util,
                };
                _ = db.InsertClasses(pickup);
                var classcount = new Subjects()
                {
                    TargyId = subs[a].TargyId,
                    Name = subs[a].Name,
                    Description = subs[a].Name,
                    Stock = subs[a].Stock,
                    onclass = subs[a].onclass - 1,
                };
                _ = db.InsertClasses(null, classcount);
                errorbox.Text = "Tárgya sikeresen leadásra került!";
                errorbox.ForeColor = Color.Blue;
            }
            else
            {
                errorbox.Text = "Ez a tárgy még nem került felvételre!";
                errorbox.ForeColor = Color.Red;
            }
        }
    }
}
