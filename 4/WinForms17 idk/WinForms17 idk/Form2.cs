using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms17_idk
{
    public partial class Form2 : Form
    {
        private string name = "";
        //List<string> list = new List<string>();
        public Form2(string _name)
        {
            InitializeComponent();
            name = _name;
            label1.Text = "Enter something " + name + ":";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxThing.Text != null)
            {
                Program.list.Add(textBoxThing.Text.ToString());
                //list.Add(textBoxThing.Text.ToString());
                textBoxThing.Clear();
            }
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(name);
            this.Hide();
            form3.ShowDialog();
        }
    }
}
