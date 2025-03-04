namespace winforms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hehelabel1.Text = "hihi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hehelabel2.Text = "not hihi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hehelabel3.Text = "more hihi";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hehelabel1.ForeColor = Color.Yellow;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hehelabel2.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hehelabel3.ForeColor = Color.Pink;
        }

        private void hehelabel1_Click(object sender, EventArgs e)
        {

        }

        private void hehelabel2_Click(object sender, EventArgs e)
        {

        }

        private void hehelabel3_Click(object sender, EventArgs e)
        {

        }
    }
}