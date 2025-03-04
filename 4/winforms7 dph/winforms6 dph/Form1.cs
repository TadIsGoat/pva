namespace winforms6_dph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double cenaSDPH = double.Parse(textBoxCenaInput.Text);
                double sazbaDPH = double.Parse(textBoxDPHInput.Text);
                double cenaBezDPH = cenaSDPH / (1 + sazbaDPH / 100);
                double dph = cenaSDPH - cenaBezDPH;

                textBoxCenaOutput.Text = cenaBezDPH.ToString("F2");
                textBoxDPHOutput.Text = dph.ToString("F2");
            }
            catch
            {
                MessageBox.Show("sumting wen wong");
            }
        }
    }
}
