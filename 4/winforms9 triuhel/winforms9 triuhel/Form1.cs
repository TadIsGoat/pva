namespace winforms9_triuhel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(numericUpDownSideA.Value);
            double b = Convert.ToDouble(numericUpDownSideB.Value);
            double c = Convert.ToDouble(numericUpDownSideC.Value);

            if (a + b > c &&
                a + c > b &&
                b + c > a)
            {
                labelValid.Text = "This triangle exists";
            }
            else
            {
                labelValid.Text = "This triangle cannot exist";
            }
        }
    }
}
