using System;

namespace winforms14_betterCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenNewNumber();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void buttonCaptcha_Click(object sender, EventArgs e)
        {
            GenNewNumber();
        }

        private int tries = 3;

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxUserNumber.Text == labelCaptcha.Text)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else if (tries <= 1)
            {
                MessageBox.Show("You are out of tries!", "Limit reached!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Your number does not match the Captcha!", "Incorrect captcha!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUserNumber.Text = string.Empty;
                GenNewNumber();
                tries--;
            }
        }

        private void GenNewNumber()
        {
            Random rnd = new Random();
            labelCaptcha.Text = rnd.Next(999, 9999).ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
