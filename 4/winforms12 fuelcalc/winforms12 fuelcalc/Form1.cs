namespace winforms12_fuelcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double avg = hScrollBarAvg.Value;
            double fuelCost = hScrollBarFuelCost.Value;
            double trip = Convert.ToDouble(numericUpDownTrip.Value);

            double costPerKm = fuelCost * avg / 100;
            double totalCost = costPerKm * trip;

            labelCostPerKm.Text = costPerKm.ToString("F2");
            labelTotalCost.Text = totalCost.ToString("F2");
        }

        private void hScrollBarAvg_Scroll(object sender, ScrollEventArgs e)
        {
            labelAvg.Text = hScrollBarAvg.Value.ToString();
        }

        private void hScrollBarFuelCost_Scroll(object sender, ScrollEventArgs e)
        {
            labelCost.Text = hScrollBarFuelCost.Value.ToString();
        }
    }
}
