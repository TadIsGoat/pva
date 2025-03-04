namespace winforms11_rgb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelSelectedColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxSpectrum_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBoxSpectrum.Image;
            Color color = bitmap.GetPixel(e.X, e.Y);

            labelColorWindow.BackColor = color;
            labelRGB.Text = $"R: {color.R}, G: {color.G}, B: {color.B}";
        }

        private void pictureBoxSpectrum_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = (Bitmap)pictureBoxSpectrum.Image;
            Color color = bitmap.GetPixel(e.X, e.Y);

            panelSelectedColor.BackColor = color;
            textBoxRed.Text = $"{color.R}";
            textBoxGreen.Text = $"{color.G}";
            textBoxBlue.Text = $"{color.B}";
        }
    }
}
