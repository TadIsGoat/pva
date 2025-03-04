namespace WinForms17_idk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBoxName.Text.ToString());
            this.Hide();
            form2.ShowDialog();
        }
    }
}
