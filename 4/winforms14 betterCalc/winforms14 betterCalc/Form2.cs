namespace winforms14_betterCalc
{
    public partial class Form2 : Form
    {
        private string line = "";

        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form2_KeyDown;
        }

        private void AddToLine(string input)
        {
            line += input;
            textBoxScreen.Text = line;
        }
        private void TakeFromLine(bool all)
        {
            if (all == false && !string.IsNullOrEmpty(line))
            {
                line = line.Remove(line.Length - 1);
                textBoxScreen.Text = line;
            }
            else if (all == true)
            {
                line = "";
                textBoxScreen.Text = line;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            AddToLine(buttonZero.Text);
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            AddToLine(buttonOne.Text);
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            AddToLine(buttonTwo.Text);
        }
        private void buttonThree_Click(object sender, EventArgs e)
        {
            AddToLine(buttonThree.Text);
        }
        private void buttonFour_Click(object sender, EventArgs e)
        {
            AddToLine(buttonFour.Text);
        }
        private void buttonFive_Click(object sender, EventArgs e)
        {
            AddToLine(buttonFive.Text);
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            AddToLine(buttonSix.Text);
        }
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            AddToLine(buttonSeven.Text);
        }
        private void buttonEight_Click(object sender, EventArgs e)
        {
            AddToLine(buttonEight.Text);
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            AddToLine(buttonNine.Text);
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            AddToLine(buttonPlus.Text);
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            AddToLine(buttonPlus.Text);
        }
        private void buttonTimes_Click(object sender, EventArgs e)
        {
            AddToLine(buttonTimes.Text);
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            AddToLine(buttonDivide.Text);
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            TakeFromLine(false);
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            TakeFromLine(true);
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(line, null);
                line = result.ToString();
                textBoxScreen.Text = line;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"This code is ass\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                AddToLine(buttonZero.Text);
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                AddToLine(buttonOne.Text);
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                AddToLine(buttonTwo.Text);
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                AddToLine(buttonThree.Text);
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                AddToLine(buttonFour.Text);
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                AddToLine(buttonFive.Text);
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                AddToLine(buttonSix.Text);
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                AddToLine(buttonSeven.Text);
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                AddToLine(buttonEight.Text);
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                AddToLine(buttonNine.Text);
            }
            else if (e.KeyCode == Keys.Add)
            {
                AddToLine(buttonPlus.Text);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                AddToLine(buttonMinus.Text);
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                AddToLine(buttonTimes.Text);
            }
            else if (e.KeyCode == Keys.Divide)
            {
                AddToLine(buttonDivide.Text);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                buttonEquals.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                buttonC.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}