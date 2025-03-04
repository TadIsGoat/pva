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
    public partial class Form3 : Form
    {
        private string name;

        public Form3(string _name)
        {
            InitializeComponent();
            name = _name;
            label1.Text = name + "'s list:";

            //listBoxList.Text += String.Join(Environment.NewLine, list);
            foreach (string item in Program.list)
            {
                listBoxList.Items.Add(item);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            /*
            foreach (var item in listBoxList.SelectedItems)
            {
                if (item != null)
                {
                    listBoxList.Items.Remove(item);
                    Program.list.Remove(item.ToString());
                }
            }*/

            for (int i = 0; i < listBoxList.Items.Count; i++)
            {
                if (listBoxList.SelectedItem != null)
                {
                    Program.list.Remove(listBoxList.SelectedItem.ToString());
                    listBoxList.Items.Remove(listBoxList.SelectedItem);
                }
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(name);
            this.Hide();
            form2.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxList.Items.Count > 0) 
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Title = "Save as";
                    save.Filter = "Text file|*.txt";
                    save.FileName = String.Empty;

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllLines(save.FileName, listBoxList.Items.Cast<string>());

                        MessageBox.Show("Done");
                    }
                }
            }
            else
            {
                MessageBox.Show("Emptyyy");
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog()) 
            {
                open.Title = "Load from";
                open.Filter = "Text file|*.txt";
                open.FileName = String.Empty;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    Program.list.Clear();
                    listBoxList.Items.Clear();

                    Program.list.AddRange(File.ReadAllLines(open.FileName));
                    listBoxList.Items.AddRange(File.ReadAllLines(open.FileName));

                    MessageBox.Show("Done");
                }
            }
        }
    }
}
