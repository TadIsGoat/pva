namespace winforms5_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] data = { "Celsius", "Fahrenheit", "Kelvin" };

            foreach (string d in data)
            {
                comboBoxFrom.Items.Add(d);
                comboBoxTo.Items.Add(d);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            /*
            Index 0 = Celsius
            Index 1 = Fahrenheit
            Index 2 = Kelbin
            */
            try
            {
                double from = double.Parse(textBoxInput.Text);
                if (comboBoxFrom.SelectedIndex == 0 && comboBoxTo.SelectedIndex == 1)
                {
                    label4.Text = CtoF(from).ToString("F2") + " degrees Fahrenheit";
                }
                else if (comboBoxFrom.SelectedIndex == 0 && comboBoxTo.SelectedIndex == 2)
                {
                    label4.Text = CtoK(from).ToString("F2") + " degrees Kelvin";
                }
                else if (comboBoxFrom.SelectedIndex == 1 && comboBoxTo.SelectedIndex == 0)
                {
                    label4.Text = FtoC(from).ToString("F2") + " degrees Celsius";
                }
                else if (comboBoxFrom.SelectedIndex == 1 && comboBoxTo.SelectedIndex == 2)
                {
                    label4.Text = FtoK(from).ToString("F2") + " degrees Kelvin";
                }
                else if (comboBoxFrom.SelectedIndex == 2 && comboBoxTo.SelectedIndex == 0)
                {
                    label4.Text = KtoC(from).ToString("F2") + " degrees Celsius";
                }
                else if (comboBoxFrom.SelectedIndex == 2 && comboBoxTo.SelectedIndex == 1)
                {
                    label4.Text = KtoF(from).ToString("F2") + " degrees Fahrenheit";
                }
            }
            catch
            {
                MessageBox.Show("Try again!");
            }
        }

        private double CtoF(double value)
        {
            return value * (9f / 5f) + 32;
        }

        private double CtoK(double value)
        {
            return value + 273;
        }

        private double FtoC(double value)
        {
            return (value - 32) * 5 / 9;
        }

        private double FtoK(double value) 
        {
            return ((value - 32) * 5 / 9) + 273;
        }

        private double KtoC(double value)
        {
            return value - 273;
        }

        private double KtoF(double value) 
        {
            return (value - 273) * 1.8 + 32;
        }
    }
}
