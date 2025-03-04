namespace winforms4_moneyapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelCZK_Click(object sender, EventArgs e)
        {

        }

        private void labelUSD_Click(object sender, EventArgs e)
        {

        }

        private void labelBIT_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCZK_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBIT_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double czk;
            double usd;
            double bit;

            if (!string.IsNullOrEmpty(textBoxCZK.Text))
            {
                czk = double.Parse(textBoxCZK.Text);
                usd = czk * 0.043;
                bit = czk * 0.000016234;

                textBoxUSD.Text = usd.ToString("F2");
                textBoxBIT.Text = bit.ToString("F2");
            }
            else if (!string.IsNullOrEmpty(textBoxUSD.Text))
            {
                usd = double.Parse(textBoxUSD.Text);
                czk = usd * 23.21;
                bit = usd * 0.000016234;

                textBoxCZK.Text = czk.ToString("F2");
                textBoxBIT.Text = bit.ToString("F2");
            }
            else if (!string.IsNullOrEmpty(textBoxBIT.Text))
            {
                bit = double.Parse(textBoxBIT.Text);
                czk = bit * 1559868.13;
                usd = bit * 61600.2;

                textBoxCZK.Text = czk.ToString("F2");
                textBoxUSD.Text = usd.ToString("F2");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCZK.Clear();
            textBoxUSD.Clear();
            textBoxBIT.Clear();
        }
    }
}
