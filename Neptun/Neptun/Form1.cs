using Neptun.data;
using Neptun.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptun
{
    public partial class Form1 : Form
    {
        private DBControl db = new DBControl();
        private List<Users> users = new List<Users>();
        private int index = 0;
        public Form1()
        {
            InitializeComponent();
            _ = db.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;
            for (int i = 0; i < users.Count; i++)
            {
                if (textBox2.Text.Equals(users[i].Name) && textBox1.Text.Equals(users[i].Password))
                {
                    index= i;
                    updatelogin();
                    Form2 form2 = new Form2();
                    form2.Tag = this;
                    form2.Show(this);
                    valid = true;
                    Hide();
                }
                else valid = false;
            }
            if (valid == false)
                label2.Text = "Hibás felhasználónév vagy jelszó!";
        }

        public async void updatelogin()
        {
            var log = new Users()
            {
                Name = users[index].Name,
                Password = users[index].Password,
                Id = users[index].Id,
                live = true,
                classes = users[index].classes,
            };
            await db.InsertClasses(log,null,true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DBControl();
            _  = db.Initialize();
            foreach (Users u in db.GetUser().Result)
            {
                users = db.GetUser().Result;
            }
            db.ResetLive(users);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
