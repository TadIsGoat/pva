namespace Winforms16_alphabet
{
    public partial class Form1 : Form
    {
        private bool CapsLock = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = textBox1.Text.ToString().Remove(textBox1.Text.Length - 1);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string filePath = $"text.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
                File.AppendAllText(filePath, textBox1.Text + "\n");
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine;
        }

        private void buttonCapsLock_Click(object sender, EventArgs e)
        {
            if (CapsLock)
                CapsLock = false;
            else if (!CapsLock)
                CapsLock = true;
        }

        private void buttonLetter_Click(object sender, EventArgs e)
        {
            Button clickedButten = sender as Button;

            if (clickedButten != null)
            {
                if (CapsLock)
                {
                    textBox1.Text += clickedButten.Tag.ToString().ToUpper();
                }
                else
                {
                    textBox1.Text += clickedButten.Tag.ToString().ToLower();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Application.Exit(); break;
                case Keys.Enter: break;
                case Keys.CapsLock: buttonCapsLock.PerformClick(); break;
                case Keys.Back: buttonBackspace.PerformClick(); break;
                case Keys.Space: buttonSpace.PerformClick(); break;
                case Keys.End: buttonSave.PerformClick(); break;
            }

            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.W)
            {
                if (CapsLock)
                {
                    textBox1.Text += e.KeyCode.ToString().ToUpper();
                }
                else
                {
                    textBox1.Text += e.KeyCode.ToString().ToLower();
                }
            }
        }
    }
}
