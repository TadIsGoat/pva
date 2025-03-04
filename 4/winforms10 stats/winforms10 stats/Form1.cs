namespace winforms10_stats
{
    public partial class Form1 : Form
    {
        protected List<int> numbers = new List<int>();

        public Form1()
        {
            InitializeComponent();

            string[] grouping = { "lowest to highest", "highest to lowest" };

            foreach (string g in grouping)
            {
                comboBoxGrouping.Items.Add(g);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int newNumber = Convert.ToInt32(numericUpDownNewNumber.Value);

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
            else
            {
                MessageBox.Show("Number cannot be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            labelNumbers.Text = ListToString(numbers);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numbers = new List<int>();

            labelNumbers.Text = ListToString(numbers);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            List<int> sortedNumbers = new List<int>();
            if (comboBoxGrouping.SelectedIndex == 0) //lowest to highest
            {
                sortedNumbers = numbers.OrderByDescending(n => n).ToList();
            }
            else
            {
                sortedNumbers = numbers.OrderBy(n => n).ToList();
            }

            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }

            try
            {
                labelSum.Text = sum.ToString();
                labelLowest.Text = numbers.Min().ToString();
                labelHighest.Text = numbers.Max().ToString();
                labelAvarage.Text = numbers.Average().ToString();
                labelGrouped.Text = ListToString(sortedNumbers);
            }
            catch 
            {
                MessageBox.Show("Your number list cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string ListToString(List<int> numbers)
        {
            string s = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                s += numbers[i].ToString();
                if (i < numbers.Count - 1)
                {
                    s += ", ";
                }
            }
            return s;
        }
    }
}
