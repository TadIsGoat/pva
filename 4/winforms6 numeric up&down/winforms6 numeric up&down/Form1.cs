namespace winforms6_numeric_up_down
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] operations = {"+", "-", "*", "/" };

            foreach (string o in operations)
            {
                comboBoxOperation.Items.Add(o);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(number1.Value);
                double n2 = Convert.ToDouble(number2.Value);
                
                if (comboBoxOperation.SelectedItem == "+")
                {
                    labelResult.Text = Convert.ToString(n1 + n2);
                }
                else if (comboBoxOperation.SelectedItem == "-")
                {
                    labelResult.Text = Convert.ToString(n1 - n2);
                }
                else if (comboBoxOperation.SelectedItem == "*")
                {
                    labelResult.Text = Convert.ToString(n1 * n2);
                }
                else if (comboBoxOperation.SelectedItem == "/")
                {
                    labelResult.Text = Convert.ToString(n1 / n2);
                }
            }
            catch
            {
                MessageBox.Show("Try again!");
            }
        }
    }
}
