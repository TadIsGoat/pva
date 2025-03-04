using System.Text.RegularExpressions;

namespace winforms13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //get name
                string pattern = "^([A-Z][a-z]+)([\\s\\-'][A-Z][a-z]+)*$"; // "^([A-ZÁÈÏÉÌÍÒÓØŠÚÙİ][a-záèïéìíòóøšúùı]+)(\\s[A-ZÁÈÏÉÌÍÒÓØŠÚÙİ][a-záèïéìíòóøšúùı]+)*$\r\n"
                string fullname = textBoxFullName.Text;
                Regex regex = new Regex(pattern);
                Match match = regex.Match(fullname);
                if (match.Success)
                {
                    fullname = match.Value;
                }
                else
                {
                    MessageBox.Show("The name you entered is not valid\n(only english letters are supported, case sensitive)", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxFullName.Text = string.Empty;
                    return;
                }

                //get gender
                string gender = "";
                if (radioButtonMale.Checked)
                    gender = "Male";
                else if (radioButtonFemale.Checked)
                    gender = "Female";
                else if (radioButtonElse.Checked)
                    gender = "Weirdo";
                else
                {
                    MessageBox.Show("You forgot your gender or what?", "Gender issues", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //get age
                int age = 0;
                if (Convert.ToInt16(numericUpDownAge.Value) <= 6)
                {
                    MessageBox.Show("If you are measuring BMI of a kid this young you are weird", "Weirdo detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDownAge.Value = 0;
                    return;
                }
                else
                {
                    age = Convert.ToInt32(numericUpDownAge.Value);
                }

                //get height
                double height = 1;
                if (Convert.ToDouble(hScrollBar1.Value) < 50)
                {
                    MessageBox.Show("You are way too small for this", "Bánec detekted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    height = Convert.ToDouble(hScrollBar1.Value);
                }

                //get weight
                double weight = 1;
                if (Convert.ToDouble(hScrollBar1.Value) < 20)
                {
                    MessageBox.Show("If you are this light you don't need a calculator to tell you that you are underweight", "Lightweight", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    weight = Convert.ToDouble(hScrollBar2.Value);
                }

                //get bmi
                double bmi = weight / Math.Pow(height / 100, 2);

                //get category and color
                string category = "";
                if (gender == "Male")
                {
                    if (bmi < 20)
                    {
                        labelBMI.ForeColor = Color.FromArgb(189, 31, 224);
                        labelResult.ForeColor = Color.FromArgb(189, 31, 224);
                        category = "Underweight";
                    }
                    else if (bmi >= 20 && bmi < 25)
                    {
                        labelBMI.ForeColor = Color.FromArgb(29, 168, 57);
                        labelResult.ForeColor = Color.FromArgb(29, 168, 57);
                        category = "Normal";
                    }
                    else if (bmi >= 25 && bmi < 30)
                    {
                        labelBMI.ForeColor = Color.FromArgb(219, 159, 55);
                        labelResult.ForeColor = Color.FromArgb(219, 159, 55);
                        category = "Overweight";
                    }
                    else
                    {
                        labelBMI.ForeColor = Color.FromArgb(163, 67, 59);
                        labelResult.ForeColor = Color.FromArgb(163, 67, 59);
                        category = "Obesity";
                    }
                }
                else
                {
                    if (bmi < 19)
                    {
                        labelBMI.ForeColor = Color.FromArgb(189, 31, 224);
                        labelResult.ForeColor = Color.FromArgb(189, 31, 224);
                        category = "Underweight";
                    }
                    else if (bmi >= 19 && bmi < 24)
                    {
                        labelBMI.ForeColor = Color.FromArgb(29, 168, 57);
                        labelResult.ForeColor = Color.FromArgb(29, 168, 57);
                        category = "Normal";
                    }
                    else if (bmi >= 24 && bmi < 30)
                    {
                        labelBMI.ForeColor = Color.FromArgb(219, 159, 55);
                        labelResult.ForeColor = Color.FromArgb(219, 159, 55);
                        category = "Overweight";
                    }
                    else
                    {
                        labelBMI.ForeColor = Color.FromArgb(163, 67, 59);
                        labelResult.ForeColor = Color.FromArgb(163, 67, 59);
                        category = "Obesity";
                    }
                }
                
                //show results
                labelBMI.Text = bmi.ToString("F2");
                labelResult.Text = category;

                //save the thing
                string filePath = $"C:\\Users\\{Environment.UserName}\\{Environment.SpecialFolder.Desktop}\\data.txt";
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Dispose();
                }
                File.AppendAllText(filePath, $"[BMI] Fullname: {fullname}; Gender: {gender}; Age: {age}; Height: {height}cm; Weight: {weight}kg; {bmi.ToString("F2")}; Category: {category}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sum-ting Wen-wong (and nobody knows what)\nThis is the error, you can fix it yourself: {ex.Message}", "(Un)expected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = string.Empty;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonElse.Checked = false;
            numericUpDownAge.Value = 0;
            labelHeight.Text = string.Empty;
            labelWeight.Text = string.Empty;
            labelBMI.Text = string.Empty;
            hScrollBar1.Value = 1;
            hScrollBar2.Value = 1;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            labelHeight.Text = hScrollBar1.Value.ToString("F0");
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            labelWeight.Text = hScrollBar2.Value.ToString("F0");
        }
    }
}
