namespace winforms3_kelbin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFahrenheit = new Label();
            labelCelsius = new Label();
            labelKelvin = new Label();
            textBoxFahrenheit = new TextBox();
            textBoxCelsius = new TextBox();
            textBoxKelvin = new TextBox();
            buttonFahrenheit = new Button();
            buttonCelsius = new Button();
            buttonKelvin = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // labelFahrenheit
            // 
            labelFahrenheit.AutoSize = true;
            labelFahrenheit.BackColor = Color.Transparent;
            labelFahrenheit.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelFahrenheit.ForeColor = Color.Blue;
            labelFahrenheit.Location = new Point(96, 99);
            labelFahrenheit.Name = "labelFahrenheit";
            labelFahrenheit.Size = new Size(140, 35);
            labelFahrenheit.TabIndex = 0;
            labelFahrenheit.Text = "Fahrenheit";
            labelFahrenheit.Click += labelFahrenheit_Click;
            // 
            // labelCelsius
            // 
            labelCelsius.AutoSize = true;
            labelCelsius.BackColor = Color.Transparent;
            labelCelsius.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelCelsius.ForeColor = Color.Blue;
            labelCelsius.Location = new Point(96, 205);
            labelCelsius.Name = "labelCelsius";
            labelCelsius.Size = new Size(93, 35);
            labelCelsius.TabIndex = 1;
            labelCelsius.Text = "Celsius";
            labelCelsius.Click += labelCelsius_Click;
            // 
            // labelKelvin
            // 
            labelKelvin.AutoSize = true;
            labelKelvin.BackColor = Color.Transparent;
            labelKelvin.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labelKelvin.ForeColor = Color.Blue;
            labelKelvin.Location = new Point(96, 306);
            labelKelvin.Name = "labelKelvin";
            labelKelvin.Size = new Size(82, 35);
            labelKelvin.TabIndex = 2;
            labelKelvin.Text = "Kelvin";
            labelKelvin.Click += labelKelvin_Click;
            // 
            // textBoxFahrenheit
            // 
            textBoxFahrenheit.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxFahrenheit.Location = new Point(345, 100);
            textBoxFahrenheit.Name = "textBoxFahrenheit";
            textBoxFahrenheit.Size = new Size(148, 37);
            textBoxFahrenheit.TabIndex = 3;
            textBoxFahrenheit.TextChanged += textBoxFahrenheit_TextChanged;
            // 
            // textBoxCelsius
            // 
            textBoxCelsius.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxCelsius.Location = new Point(345, 206);
            textBoxCelsius.Name = "textBoxCelsius";
            textBoxCelsius.Size = new Size(148, 37);
            textBoxCelsius.TabIndex = 4;
            textBoxCelsius.TextChanged += textBoxCelsius_TextChanged;
            // 
            // textBoxKelvin
            // 
            textBoxKelvin.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            textBoxKelvin.Location = new Point(345, 307);
            textBoxKelvin.Name = "textBoxKelvin";
            textBoxKelvin.Size = new Size(148, 37);
            textBoxKelvin.TabIndex = 5;
            textBoxKelvin.TextChanged += textBoxKelvin_TextChanged;
            // 
            // buttonFahrenheit
            // 
            buttonFahrenheit.BackColor = Color.FromArgb(128, 128, 255);
            buttonFahrenheit.FlatStyle = FlatStyle.Popup;
            buttonFahrenheit.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonFahrenheit.Location = new Point(595, 99);
            buttonFahrenheit.Name = "buttonFahrenheit";
            buttonFahrenheit.Size = new Size(133, 38);
            buttonFahrenheit.TabIndex = 6;
            buttonFahrenheit.Text = "Convert";
            buttonFahrenheit.UseVisualStyleBackColor = false;
            buttonFahrenheit.Click += buttonFahrenheit_Click;
            // 
            // buttonCelsius
            // 
            buttonCelsius.BackColor = Color.FromArgb(128, 128, 255);
            buttonCelsius.FlatStyle = FlatStyle.Popup;
            buttonCelsius.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonCelsius.Location = new Point(595, 206);
            buttonCelsius.Name = "buttonCelsius";
            buttonCelsius.Size = new Size(133, 38);
            buttonCelsius.TabIndex = 7;
            buttonCelsius.Text = "Convert";
            buttonCelsius.UseVisualStyleBackColor = false;
            buttonCelsius.Click += buttonCelsius_Click;
            // 
            // buttonKelvin
            // 
            buttonKelvin.BackColor = Color.FromArgb(128, 128, 255);
            buttonKelvin.FlatStyle = FlatStyle.Popup;
            buttonKelvin.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonKelvin.Location = new Point(595, 307);
            buttonKelvin.Name = "buttonKelvin";
            buttonKelvin.Size = new Size(133, 38);
            buttonKelvin.TabIndex = 8;
            buttonKelvin.Text = "Convert";
            buttonKelvin.UseVisualStyleBackColor = false;
            buttonKelvin.Click += buttonKelvin_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.FromArgb(128, 128, 255);
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonClear.Location = new Point(345, 380);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(148, 38);
            buttonClear.TabIndex = 9;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cici5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(buttonKelvin);
            Controls.Add(buttonCelsius);
            Controls.Add(buttonFahrenheit);
            Controls.Add(textBoxKelvin);
            Controls.Add(textBoxCelsius);
            Controls.Add(textBoxFahrenheit);
            Controls.Add(labelKelvin);
            Controls.Add(labelCelsius);
            Controls.Add(labelFahrenheit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFahrenheit;
        private Label labelCelsius;
        private Label labelKelvin;
        private TextBox textBoxFahrenheit;
        private TextBox textBoxCelsius;
        private TextBox textBoxKelvin;
        private Button buttonFahrenheit;
        private Button buttonCelsius;
        private Button buttonKelvin;
        private Button buttonClear;
    }
}
