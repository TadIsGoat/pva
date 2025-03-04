namespace winforms8_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] delivery = { "PPL", "Packeta", "DPD", "GLS" };
            string[] payment = { "cash", "card" };

            foreach (string d in delivery)
            {
                comboBoxDelivery.Items.Add(d);
            }

            foreach (string p in payment)
            {
                comboBoxPayment.Items.Add(p);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxFirstName.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxLastName.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxStreet.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxCity.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxPostalCode.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxEmail.Text) &&
                    !string.IsNullOrWhiteSpace(textBoxPhone.Text) &&
                    checkboxRules.Checked)
                {
                    string id = DateTime.Now.ToString("yyyyMMddHHmmss"); // Format: YearMonthDayHourMinuteSecond
                    string filePath = $"order_{id}.txt"; //{Environment.SpecialFolder.MyDocuments}/

                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Dispose();
                        File.AppendAllText(filePath, $"First Name: {textBoxFirstName.Text}\n" +
                            $"Last Name: {textBoxLastName.Text}\n" +
                            $"Street: {textBoxStreet.Text}\n" +
                            $"City: {textBoxCity.Text}\n" +
                            $"Postal code: {textBoxPostalCode.Text}\n" +
                            $"Email: {textBoxEmail.Text}\n" +
                            $"Phone: {textBoxPhone.Text}\n" +
                            $"Understands the bussiness rules\n");
                        if (checkBoxNewsletter.Checked)
                        {
                            File.AppendAllText(filePath, "Wants to receive newsletter\n\n");
                        }
                        if (!string.IsNullOrWhiteSpace(textBoxNote.Text))
                        {
                            File.AppendAllText(filePath, $"Note: {textBoxNote.Text}\n");
                        }
                    }
                    else
                    {
                        MessageBox.Show("File with same ID already exists", "Order complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Successfully ordered", "Order complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxFirstName.Clear();
                    textBoxLastName.Clear();
                    textBoxStreet.Clear();
                    textBoxCity.Clear();
                    textBoxPostalCode.Clear();
                    textBoxEmail.Clear();
                    textBoxPhone.Clear();
                    textBoxNote.Clear();
                    checkboxRules.Checked = false;
                    checkBoxNewsletter.Checked = false;
                }
                else
                {
                    MessageBox.Show("All lines except note need to be filled", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
