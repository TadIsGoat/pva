namespace winformsTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxTyp = new ComboBox();
            comboBoxInputTyp = new ComboBox();
            comboBoxOutputTyp = new ComboBox();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            buttonConvert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Typ převodu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 74);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Vstupní hodnota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 123);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 2;
            label3.Text = "Do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 167);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Převedená hodnota";
            // 
            // comboBoxTyp
            // 
            comboBoxTyp.FormattingEnabled = true;
            comboBoxTyp.Items.AddRange(new object[] { "Délka", "Objem" });
            comboBoxTyp.Location = new Point(221, 26);
            comboBoxTyp.Name = "comboBoxTyp";
            comboBoxTyp.Size = new Size(195, 23);
            comboBoxTyp.TabIndex = 4;
            // 
            // comboBoxInputTyp
            // 
            comboBoxInputTyp.FormattingEnabled = true;
            comboBoxInputTyp.Items.AddRange(new object[] { "cm", "m", "ml", "l" });
            comboBoxInputTyp.Location = new Point(330, 71);
            comboBoxInputTyp.Name = "comboBoxInputTyp";
            comboBoxInputTyp.Size = new Size(86, 23);
            comboBoxInputTyp.TabIndex = 5;
            // 
            // comboBoxOutputTyp
            // 
            comboBoxOutputTyp.FormattingEnabled = true;
            comboBoxOutputTyp.Items.AddRange(new object[] { "cm", "m", "ml", "l" });
            comboBoxOutputTyp.Location = new Point(221, 120);
            comboBoxOutputTyp.Name = "comboBoxOutputTyp";
            comboBoxOutputTyp.Size = new Size(195, 23);
            comboBoxOutputTyp.TabIndex = 6;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(221, 71);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 7;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(221, 167);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(195, 23);
            textBoxOutput.TabIndex = 8;
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(221, 205);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(195, 23);
            buttonConvert.TabIndex = 9;
            buttonConvert.Text = "Převeď";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 240);
            Controls.Add(buttonConvert);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Controls.Add(comboBoxOutputTyp);
            Controls.Add(comboBoxInputTyp);
            Controls.Add(comboBoxTyp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Převodník hodnot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxTyp;
        private ComboBox comboBoxInputTyp;
        private ComboBox comboBoxOutputTyp;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private Button buttonConvert;
    }
}
