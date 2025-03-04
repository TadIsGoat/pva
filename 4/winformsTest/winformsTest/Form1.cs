using System.ComponentModel;

namespace winformsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            /*
            cm
            m
            ml
            l
            */

            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
            {
                if (comboBoxInputTyp != comboBoxOutputTyp)
                {
                    float input = float.Parse(textBoxInput.Text);
                    if (comboBoxTyp.SelectedIndex == 0) //delka
                    {
                        if (comboBoxInputTyp.SelectedIndex == 0 && comboBoxOutputTyp.SelectedIndex == 1)
                        {
                            textBoxOutput.Text = (input * 100).ToString();
                        }
                        else if (comboBoxInputTyp.SelectedIndex == 1 && comboBoxOutputTyp.SelectedIndex == 0)
                        {
                            textBoxOutput.Text = (input / 100).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else if (comboBoxTyp.SelectedIndex == 1) //objem
                    {
                        if (comboBoxInputTyp.SelectedIndex == 2 && comboBoxOutputTyp.SelectedIndex == 3)
                        {
                            textBoxOutput.Text = (input * 1000).ToString();
                        }
                        else if (comboBoxInputTyp.SelectedIndex == 3 && comboBoxOutputTyp.SelectedIndex == 2)
                        {
                            textBoxOutput.Text = (input / 1000).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Type not selected");
                    }
                }
                else
                {
                    MessageBox.Show("cant convert same values");
                }
            }
            else
            {
                MessageBox.Show("input is empty"/*, MessageBoxIcon.Error()*/);
            }
        }
    }
}
