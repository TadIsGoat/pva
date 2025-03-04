namespace winforms3_kelbin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelFahrenheit_Click(object sender, EventArgs e)
        {

        }

        private void labelCelsius_Click(object sender, EventArgs e)
        {

        }

        private void labelKelvin_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFahrenheit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCelsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKelvin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFahrenheit_Click(object sender, EventArgs e)
        {
            float f;
            f = float.Parse(textBoxFahrenheit.Text);
            float c = 5f / 9f * (f - 32);
            float k = c + 273;

            textBoxCelsius.Text = c.ToString("F2");
            textBoxKelvin.Text = k.ToString("F2");
        }

        private void buttonCelsius_Click(object sender, EventArgs e)
        {
            float c;
            c = float.Parse(textBoxCelsius.Text);
            float f = c * (9f / 5f) + 32;
            float k = c + 273;

            textBoxFahrenheit.Text = f.ToString("F2");
            textBoxKelvin.Text = k.ToString("F2");
        }

        private void buttonKelvin_Click(object sender, EventArgs e)
        {
            float k;
            k = float.Parse(textBoxKelvin.Text);
            float c = k - 273;
            double f = (k - 273) * 1.8 + 32;

            textBoxCelsius.Text = c.ToString("F2");
            textBoxFahrenheit.Text = f.ToString("F2");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCelsius.Clear();
            textBoxFahrenheit.Clear();
            textBoxKelvin.Clear();
        }
    }
}
